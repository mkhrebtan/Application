import { inject, Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { SsrCookieService } from 'ngx-cookie-service-ssr';
import { BehaviorSubject, Observable, throwError } from 'rxjs';
import { catchError, shareReplay, tap } from 'rxjs/operators';

export interface TokenResponse {
  accessToken: string;
  refreshToken: string;
}

@Injectable({
  providedIn: 'root'
})
export class TokenService {
  private http = inject(HttpClient);
  private cookieService = inject(SsrCookieService);
  private authUrl = 'https://localhost:5001/auth';

  private refreshTokenInProgress: Observable<TokenResponse> | null = null;
  private tokenRefreshedSubject = new BehaviorSubject<string | null>(null);
  public tokenRefreshed$ = this.tokenRefreshedSubject.asObservable();

  constructor() {
    this.initializeVisitorId();
  }

  getAccessToken(): string {
    return this.cookieService.get('accessToken');
  }

  getRefreshToken(): string {
    return this.cookieService.get('refreshToken');
  }

  getVisitorId(): string {
    return this.cookieService.get('visitorId');
  }

  hasValidToken(): boolean {
    return !!this.getAccessToken();
  }

  setTokens(accessToken: string, refreshToken: string): void {
    this.cookieService.set('accessToken', accessToken);
    this.cookieService.set('refreshToken', refreshToken);
    this.tokenRefreshedSubject.next(accessToken);
  }

  clearTokens(): void {
    this.cookieService.delete('accessToken');
    this.cookieService.delete('refreshToken');
    this.tokenRefreshedSubject.next(null);
  }

  refreshTokens(): Observable<TokenResponse> {
    if (this.refreshTokenInProgress) {
      return this.refreshTokenInProgress;
    }

    const refreshToken = this.getRefreshToken();
    if (!refreshToken) {
      this.clearTokens();
      return throwError(() => new Error('No refresh token available'));
    }

    this.refreshTokenInProgress = this.http
      .post<TokenResponse>(`${this.authUrl}/refresh-token`, { refreshToken })
      .pipe(
        tap((response) => {
          this.setTokens(response.accessToken, response.refreshToken);
        }),
        catchError((error) => {
          this.clearTokens();
          this.refreshTokenInProgress = null;
          return throwError(() => error);
        }),
        shareReplay(1),
      );

    this.refreshTokenInProgress.subscribe({
      complete: () => {
        this.refreshTokenInProgress = null;
      },
      error: () => {
        this.refreshTokenInProgress = null;
      },
    });

    return this.refreshTokenInProgress;
  }

  private initializeVisitorId(): void {
    const visitorId = this.cookieService.get('visitorId');
    if (!visitorId) {
      const newVisitorId = crypto.randomUUID();
      this.cookieService.set('visitorId', newVisitorId);
    }
  }
}
