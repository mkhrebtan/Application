import {
  HttpErrorResponse,
  HttpHandlerFn,
  HttpInterceptorFn,
  HttpRequest,
} from '@angular/common/http';
import { inject } from '@angular/core';
import { catchError, switchMap } from 'rxjs/operators';
import { BehaviorSubject, filter, take, throwError } from 'rxjs';
import { AuthService } from '../auth-service/auth-service';

let isRefreshing = false;
const refreshTokenSubject: BehaviorSubject<any> = new BehaviorSubject<any>(null);

export const authInterceptor: HttpInterceptorFn = (
  req: HttpRequest<unknown>,
  next: HttpHandlerFn,
) => {
  const authService = inject(AuthService);

  if (req.url.includes('/auth/')) {
    return next(req);
  }

  const token = authService.getToken();
  const visitorId = authService.getVisitorId();
  let authReq = req;

  if (!token && visitorId) {
    authReq = req.clone({
      setHeaders: {
        'X-Visitor-Id': visitorId,
      },
    });
  }

  if (token) {
    authReq = authReq.clone({
      setHeaders: {
        Authorization: `Bearer ${token}`,
      },
    });
  }

  return next(authReq).pipe(
    catchError((error: HttpErrorResponse) => {
      if (error.status === 401 && token && !isRefreshing) {
        return handleTokenRefresh(authService, authReq, next);
      } else if (error.status === 401 && token && isRefreshing) {
        return refreshTokenSubject.pipe(
          filter((result) => result !== null),
          take(1),
          switchMap(() => {
            const newToken = authService.getToken();
            const newAuthReq = authReq.clone({
              setHeaders: {
                Authorization: `Bearer ${newToken}`,
              },
            });
            return next(newAuthReq);
          }),
        );
      }

      return throwError(() => error);
    }),
  );
};

function handleTokenRefresh(
  authService: AuthService,
  request: HttpRequest<any>,
  next: HttpHandlerFn,
) {
  if (!isRefreshing) {
    isRefreshing = true;
    refreshTokenSubject.next(null);

    return authService.refreshToken().pipe(
      switchMap((tokenResponse) => {
        isRefreshing = false;
        refreshTokenSubject.next(tokenResponse.accessToken);

        const newAuthReq = request.clone({
          setHeaders: {
            Authorization: `Bearer ${tokenResponse.accessToken}`,
          },
        });
        return next(newAuthReq);
      }),
      catchError((error) => {
        isRefreshing = false;
        refreshTokenSubject.next(null);
        authService.logout();
        return throwError(() => error);
      }),
    );
  }

  return refreshTokenSubject.pipe(
    filter((result) => result !== null),
    take(1),
    switchMap(() => {
      const newToken = authService.getToken();
      const newAuthReq = request.clone({
        setHeaders: {
          Authorization: `Bearer ${newToken}`,
        },
      });
      return next(newAuthReq);
    }),
  );
}
