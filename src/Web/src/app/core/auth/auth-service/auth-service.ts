import { inject, Injectable, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { catchError, tap } from 'rxjs/operators';
import { BehaviorSubject } from 'rxjs';
import { Router } from '@angular/router';

@Injectable({
  providedIn: 'root',
})
export class AuthService implements OnInit {
  private authUrl = 'https://localhost:5001/auth';

  private http = inject(HttpClient);
  private router = inject(Router);

  private isAuthenticatedSubject = new BehaviorSubject<boolean>(this.hasToken());
  public isAuthenticated$ = this.isAuthenticatedSubject.asObservable();

  ngOnInit() {
    const visitorId = localStorage.getItem('visitorId');
    if (!visitorId) {
      const newVisitorId = crypto.randomUUID();
      localStorage.setItem('visitorId', newVisitorId);
    }
  }

  login(username: string, password: string) {
    const visitorId = localStorage.getItem('visitorId') || '';
    return this.http
      .post<{ accessToken: string; refreshToken: string }>(`${this.authUrl}/login`, {
        username,
        password,
        visitorId,
      })
      .pipe(
        tap((response) => {
          localStorage.setItem('accessToken', response.accessToken);
          localStorage.setItem('refreshToken', response.refreshToken);
          this.isAuthenticatedSubject.next(true);
        }),
        catchError((err) => {
          this.isAuthenticatedSubject.next(false);
          throw err;
        }),
      );
  }

  logout() {
    localStorage.removeItem('accessToken');
    localStorage.removeItem('refreshToken');
    this.isAuthenticatedSubject.next(false);
    this.router.navigate(['/events']);
  }

  getToken(): string {
    return localStorage.getItem('accessToken') || '';
  }

  isAuthenticated(): boolean {
    return this.isAuthenticatedSubject.value;
  }

  private hasToken(): boolean {
    return !!localStorage.getItem('accessToken');
  }
}
