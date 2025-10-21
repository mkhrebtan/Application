import { HttpInterceptorFn } from '@angular/common/http';
import { inject } from '@angular/core';
import { AuthService } from '../auth-service/auth-service';

export const authInterceptor: HttpInterceptorFn = (req, next) => {
  const authService = inject(AuthService);
  const token = authService.getToken();
  const visitorId = authService.getVisitorId();

  if (token) {
    const cloned = req.clone({
      setHeaders: {
        Authorization: `Bearer ${token}`,
      },
    });

    return next(cloned);
  }

  if (visitorId) {
    const cloned = req.clone({
      setHeaders: {
        'X-Visitor-Id': visitorId,
      },
    });

    return next(cloned);
  }

  return next(req);
};
