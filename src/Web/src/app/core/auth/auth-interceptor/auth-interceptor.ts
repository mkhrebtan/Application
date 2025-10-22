import {
  HttpClient,
  HttpErrorResponse,
  HttpHandlerFn,
  HttpInterceptorFn,
  HttpRequest,
} from '@angular/common/http';
import { inject } from '@angular/core';
import { catchError, switchMap } from 'rxjs/operators';
import { BehaviorSubject, filter, take, throwError } from 'rxjs';
import { TokenService } from '../token-service/token.service';

let isRefreshing = false;
const refreshTokenSubject: BehaviorSubject<any> = new BehaviorSubject<any>(null);

export const authInterceptor: HttpInterceptorFn = (
  req: HttpRequest<unknown>,
  next: HttpHandlerFn,
) => {
  const tokenService = inject(TokenService);
  const visitorId = tokenService.getVisitorId();
  const token = tokenService.getAccessToken();

  if (req.url.includes('/auth/')) {
    if (visitorId) {
      req = req.clone({ setHeaders: { 'X-Visitor-Id': visitorId } });
    }
    return next(req);
  }

  let authReq = req;
  if (token) {
    authReq = addTokenHeader(req, token);
  } else if (visitorId) {
    authReq = req.clone({ setHeaders: { 'X-Visitor-Id': visitorId } });
  }

  return next(authReq).pipe(
    catchError((error) => {
      if (error instanceof HttpErrorResponse && error.status === 401 && token) {
        return handle401Error(authReq, next, tokenService);
      }
      return throwError(() => error);
    }),
  );
};

const handle401Error = (req: HttpRequest<any>, next: HttpHandlerFn, tokenService: TokenService) => {
  if (!isRefreshing) {
    isRefreshing = true;
    refreshTokenSubject.next(null);

    const refreshToken = tokenService.getRefreshToken();
    if (!refreshToken) {
      isRefreshing = false;
      tokenService.clearTokens();
      return throwError(() => new Error('No refresh token available'));
    }

    const httpClient = inject(HttpClient);
    const authUrl = 'https://localhost:5001/auth';

    return httpClient
      .post<{
        accessToken: string;
        refreshToken: string;
      }>(`${authUrl}/refresh-token`, { refreshToken })
      .pipe(
        switchMap((tokenResponse) => {
          isRefreshing = false;
          tokenService.setTokens(tokenResponse.accessToken, tokenResponse.refreshToken);
          refreshTokenSubject.next(tokenResponse.accessToken);
          return next(addTokenHeader(req, tokenResponse.accessToken));
        }),
        catchError((err) => {
          isRefreshing = false;
          tokenService.clearTokens();
          return throwError(() => err);
        }),
      );
  } else {
    return refreshTokenSubject.pipe(
      filter((token) => token != null),
      take(1),
      switchMap((jwt) => next(addTokenHeader(req, jwt))),
    );
  }
};

const addTokenHeader = (request: HttpRequest<any>, token: string) => {
  return request.clone({
    setHeaders: {
      Authorization: `Bearer ${token}`,
    },
  });
};
