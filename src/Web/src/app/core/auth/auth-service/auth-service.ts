import { inject, Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { catchError, tap } from 'rxjs/operators';
import { BehaviorSubject, Observable, throwError } from 'rxjs';
import { TokenService } from '../token-service/token.service';

export interface User {
  firstName: string;
  lastName: string;
  email: string;
}

export interface LoginResponse {
  accessToken: string;
  refreshToken: string;
}

export interface RefreshTokenResponse {
  accessToken: string;
  refreshToken: string;
}

@Injectable({
  providedIn: 'root',
})
export class AuthService {
  private authUrl = 'https://localhost:5001/auth';
  private userUrl = 'https://localhost:5001/users';
  private http = inject(HttpClient);
  private tokenService = inject(TokenService);
  private isAuthenticatedSubject = new BehaviorSubject<boolean>(this.tokenService.hasAccessToken());
  public isAuthenticated$ = this.isAuthenticatedSubject.asObservable();
  private currentUserSubject = new BehaviorSubject<User | null>(null);
  public currentUser$ = this.currentUserSubject.asObservable();

  constructor() {
    const visitorId = this.tokenService.getVisitorId();
    if (!visitorId) {
      const newVisitorId = crypto.randomUUID();
      this.tokenService.setVisitorId(newVisitorId);
    }

    if (this.tokenService.hasAccessToken()) {
      this.loadCurrentUser();
    }
  }

  login(email: string, password: string): Observable<LoginResponse> {
    return this.http
      .post<LoginResponse>(`${this.authUrl}/login`, {
        email,
        password,
      })
      .pipe(
        tap((response) => {
          this.tokenService.setTokens(response.accessToken, response.refreshToken);
          this.isAuthenticatedSubject.next(true);
          this.loadCurrentUser();
        }),
        catchError((err) => {
          this.isAuthenticatedSubject.next(false);
          return throwError(() => err);
        }),
      );
  }

  signup(
    firstName: string,
    lastName: string,
    email: string,
    password: string,
  ): Observable<LoginResponse> {
    return this.http
      .post<LoginResponse>(`${this.authUrl}/signup`, {
        firstName,
        lastName,
        email,
        password,
      })
      .pipe(
        tap((response) => {
          this.tokenService.setTokens(response.accessToken, response.refreshToken);
          this.isAuthenticatedSubject.next(true);
          this.loadCurrentUser();
        }),
        catchError((err) => {
          this.isAuthenticatedSubject.next(false);
          return throwError(() => err);
        }),
      );
  }

  refreshToken(): Observable<RefreshTokenResponse> {
    const refreshToken = this.tokenService.getRefreshToken();
    if (!refreshToken) {
      return throwError(() => new Error('No refresh token available'));
    }

    return this.http
      .post<RefreshTokenResponse>(`${this.authUrl}/refresh-token`, {
        refreshToken,
      })
      .pipe(
        tap((response) => {
          this.tokenService.setTokens(response.accessToken, response.refreshToken);
        }),
        catchError((err) => {
          this.logout();
          return throwError(() => err);
        }),
      );
  }

  logout(): void {
    this.tokenService.clearTokens();
    this.currentUserSubject.next(null);
    this.isAuthenticatedSubject.next(false);
  }

  getToken(): string {
    return this.tokenService.getAccessToken();
  }

  getRefreshToken(): string {
    return this.tokenService.getRefreshToken();
  }

  getVisitorId(): string {
    return this.tokenService.getVisitorId();
  }

  getCurrentUser(): User | null {
    return this.currentUserSubject.value;
  }

  isAuthenticated(): boolean {
    return this.isAuthenticatedSubject.value;
  }

  private loadCurrentUser() {
    this.http.get<User>(`${this.userUrl}/me`).subscribe({
      next: (user) => {
        this.currentUserSubject.next(user);
      },
      error: (err) => {
        console.error('Failed to load current user:', err);
        this.currentUserSubject.next(null);
      },
    })
  }
}
