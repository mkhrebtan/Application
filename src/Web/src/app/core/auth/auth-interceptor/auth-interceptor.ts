import { HttpHandlerFn, HttpInterceptorFn, HttpRequest } from '@angular/common/http';
import { inject } from '@angular/core';
import { BehaviorSubject } from 'rxjs';
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

  return next(authReq);
};

const addTokenHeader = (request: HttpRequest<any>, token: string) => {
  return request.clone({
    setHeaders: {
      Authorization: `Bearer ${token}`,
    },
  });
};
