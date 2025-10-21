import { inject } from '@angular/core';
import {
  HttpErrorResponse,
  HttpEvent,
  HttpHandlerFn,
  HttpInterceptorFn,
  HttpRequest,
} from '@angular/common/http';
import { BehaviorSubject, Observable, throwError } from 'rxjs';
import { catchError, filter, switchMap, take } from 'rxjs/operators';
import { TokenService } from '../token-service/token-service';

let isRefreshing = false;
const refreshTokenSubject: BehaviorSubject<string | null> = new BehaviorSubject<string | null>(
  null,
);

export const authInterceptor: HttpInterceptorFn = (
  req: HttpRequest<any>,
  next: HttpHandlerFn,
): Observable<HttpEvent<any>> => {
  const tokenService = inject(TokenService);

  let request = req;

  if (tokenService.hasValidToken() && !isAuthRequest(request)) {
    request = addTokenHeader(request, tokenService.getAccessToken());
  } else {
    request = addVisitorIdHeader(request, tokenService.getVisitorId());
  }

  return next(request).pipe(
    catchError((error: HttpErrorResponse) => {
      if (error.status === 401 && !isAuthRequest(request)) {
        return handle401Error(request, next, tokenService);
      }
      return throwError(() => error);
    }),
  );
};

function addTokenHeader(request: HttpRequest<any>, token: string): HttpRequest<any> {
  return request.clone({
    headers: request.headers.set('Authorization', `Bearer ${token}`),
  });
}

function addVisitorIdHeader(request: HttpRequest<any>, visitorId: string): HttpRequest<any> {
  return request.clone({
    headers: request.headers.set('X-Visitor-Id', visitorId),
  });
}

function isAuthRequest(request: HttpRequest<any>): boolean {
  return request.url.includes('/auth/');
}

function handle401Error(
  request: HttpRequest<any>,
  next: HttpHandlerFn,
  tokenService: TokenService,
): Observable<HttpEvent<any>> {
  if (!isRefreshing) {
    isRefreshing = true;
    refreshTokenSubject.next(null);

    return tokenService.refreshTokens().pipe(
      switchMap((tokenResponse) => {
        isRefreshing = false;
        refreshTokenSubject.next(tokenResponse.accessToken);
        return next(addTokenHeader(request, tokenResponse.accessToken));
      }),
      catchError((err) => {
        isRefreshing = false;
        return throwError(() => err);
      }),
    );
  }

  return refreshTokenSubject.pipe(
    filter((token) => token !== null),
    take(1),
    switchMap((token) => next(addTokenHeader(request, token!))),
  );
}
