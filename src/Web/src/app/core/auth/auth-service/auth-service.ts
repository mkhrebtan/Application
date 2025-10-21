import { inject, Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { catchError, switchMap, tap } from 'rxjs/operators';
import { BehaviorSubject, Observable, of, throwError } from 'rxjs';
import { IUserModel } from '../../../features/auth/models/user-model';
import { TokenResponse, TokenService } from '../token-service/token-service';

@Injectable({
  providedIn: 'root',
})
export class AuthService {
  public userData: IUserModel | null = null;
  private authUrl = 'https://localhost:5001/auth';
  private usersUrl = 'https://localhost:5001/users';
  private http = inject(HttpClient);
  private tokenService = inject(TokenService);
  private isAuthenticatedSubject = new BehaviorSubject<boolean>(false);
  public isAuthenticated$ = this.isAuthenticatedSubject.asObservable();
  private userDataSubject = new BehaviorSubject<IUserModel | null>(null);
  public userData$ = this.userDataSubject.asObservable();

  constructor() {
    this.initializeAuth();

    this.tokenService.tokenRefreshed$.subscribe((token) => {
      if (!token) {
        this.clearUserData();
      }
    });
  }

  login(email: string, password: string): Observable<TokenResponse> {
    return this.http.post<TokenResponse>(`${this.authUrl}/login`, { email, password }).pipe(
      tap((response) => {
        this.tokenService.setTokens(response.accessToken, response.refreshToken);
        this.isAuthenticatedSubject.next(true);
      }),
      switchMap((response) => {
        return this.getUserData().pipe(
          switchMap(() => of(response)),
        );
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
  ): Observable<TokenResponse> {
    return this.http
      .post<TokenResponse>(`${this.authUrl}/signup`, {
        firstName,
        lastName,
        email,
        password,
      })
      .pipe(
        tap((response) => {
          this.tokenService.setTokens(response.accessToken, response.refreshToken);
          this.isAuthenticatedSubject.next(true);
        }),
        switchMap((response) => {
          return this.getUserData().pipe(
            switchMap(() => of(response)),
          );
        }),
        catchError((err) => {
          this.isAuthenticatedSubject.next(false);
          return throwError(() => err);
        }),
      );
  }

  logout(): void {
    this.tokenService.clearTokens();
    this.clearUserData();
  }

  getToken(): string {
    return this.tokenService.getAccessToken();
  }

  isAuthenticated(): boolean {
    return this.isAuthenticatedSubject.value;
  }

  getUserData(): Observable<IUserModel> {
    return this.http.get<IUserModel>(`${this.usersUrl}/me`).pipe(
      tap((user) => {
        this.userData = user;
        this.userDataSubject.next(user);
        this.isAuthenticatedSubject.next(true);
      }),
      catchError((err) => {
        return this.tokenService.refreshTokens().pipe(
          switchMap(() => this.http.get<IUserModel>(`${this.usersUrl}/me`)),
          tap((user) => {
            this.userData = user;
            this.userDataSubject.next(user);
            this.isAuthenticatedSubject.next(true);
          }),
          catchError(() => {
            this.logout();
            return throwError(() => err);
          }),
        );
      }),
    );
  }

  refreshToken(): Observable<TokenResponse> {
    return this.tokenService.refreshTokens();
  }

  private initializeAuth(): void {
    if (this.tokenService.hasValidToken()) {
      this.getUserData().subscribe({
        next: () => {
        },
        error: () => {
          this.logout();
        },
      });
    }
  }

  private clearUserData(): void {
    this.userData = null;
    this.userDataSubject.next(null);
    this.isAuthenticatedSubject.next(false);
  }
}
