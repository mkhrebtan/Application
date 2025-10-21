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
    this.cookieService.set('accessToken', accessToken);
    this.cookieService.set('refreshToken', refreshToken);
  }

  setVisitorId(visitorId: string): void {
    this.cookieService.set('visitorId', visitorId, {
      expires: 365,
      sameSite: 'Strict',
      secure: true,
    });
  }

  clearTokens(): void {
    this.cookieService.delete('accessToken');
    this.cookieService.delete('refreshToken');
  }

  hasAccessToken(): boolean {
    return !!this.getAccessToken();
  }

  hasRefreshToken(): boolean {
    return !!this.getRefreshToken();
  }

  isTokenExpired(token: string): boolean {
    if (!token) return true;

    try {
      const payload = JSON.parse(atob(token.split('.')[1]));
      const currentTime = Math.floor(Date.now() / 1000);
      return payload.exp < currentTime;
    } catch {
      return true;
    }
  }

  isAccessTokenExpired(): boolean {
    const token = this.getAccessToken();
    return this.isTokenExpired(token);
  }
}
