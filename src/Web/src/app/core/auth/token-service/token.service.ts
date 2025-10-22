import { inject, Injectable } from '@angular/core';
import { SsrCookieService } from 'ngx-cookie-service-ssr';

@Injectable({
  providedIn: 'root',
})
export class TokenService {
  private cookieService = inject(SsrCookieService);

  getAccessToken(): string {
    return this.cookieService.get('accessToken');
  }

  getRefreshToken(): string {
    return this.cookieService.get('refreshToken');
  }

  getVisitorId(): string {
    return this.cookieService.get('visitorId');
  }

  setTokens(accessToken: string, refreshToken: string): void {
    const accessTokenExpiry = new Date();
    accessTokenExpiry.setDate(accessTokenExpiry.getDate() + 7);
    this.cookieService.set('accessToken', accessToken, { expires: accessTokenExpiry, path: '/' });

    const refreshTokenExpiry = new Date();
    refreshTokenExpiry.setDate(refreshTokenExpiry.getDate() + 30);
    this.cookieService.set('refreshToken', refreshToken, {
      expires: refreshTokenExpiry,
      path: '/',
    });
  }

  setVisitorId(visitorId: string): void {
    const visitorIdExpiry = new Date();
    visitorIdExpiry.setDate(visitorIdExpiry.getDate() + 365);
    this.cookieService.set('visitorId', visitorId, { expires: visitorIdExpiry, path: '/' });
  }

  clearTokens(): void {
    this.cookieService.delete('accessToken');
    this.cookieService.delete('refreshToken');
  }

  hasAccessToken(): boolean {
    return !!this.getAccessToken();
  }
}
