import { inject, Injectable, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { catchError, tap } from 'rxjs/operators';
import { BehaviorSubject } from 'rxjs';
import { Router } from '@angular/router';
import { SsrCookieService } from 'ngx-cookie-service-ssr';

@Injectable({
  providedIn: 'root',
})
export class AuthService implements OnInit {
  private authUrl = '/api/auth';

  private http = inject(HttpClient);
  private router = inject(Router);
  private cookieService = inject(SsrCookieService);

  private isAuthenticatedSubject = new BehaviorSubject<boolean>(this.hasToken());
  public isAuthenticated$ = this.isAuthenticatedSubject.asObservable();

  ngOnInit() {
    const visitorId = this.cookieService.get('visitorId');
    if (!visitorId) {
      const newVisitorId = crypto.randomUUID();
      this.cookieService.set('visitorId', newVisitorId);
    }
  }

  login(username: string, password: string) {
    const visitorId = this.cookieService.get('visitorId');
    return this.http
      .post<{ accessToken: string; refreshToken: string }>(`${this.authUrl}/login`, {
        username,
        password,
        visitorId,
      })
      .pipe(
        tap((response) => {
          this.cookieService.set('accessToken', response.accessToken);
          this.cookieService.set('refreshToken', response.accessToken);
          this.isAuthenticatedSubject.next(true);
        }),
        catchError((err) => {
          this.isAuthenticatedSubject.next(false);
          throw err;
        }),
      );
  }

  logout() {
    this.cookieService.delete('accessToken');
    this.cookieService.delete('refreshToken');
    this.isAuthenticatedSubject.next(false);
    this.router.navigate(['/events']);
  }

  getToken(): string {
    return this.cookieService.get('accessToken');
  }

  getVisitorId(): string {
    return this.cookieService.get('visitorId');
  }

  isAuthenticated(): boolean {
    return this.isAuthenticatedSubject.value;
  }

  private hasToken(): boolean {
    return this.cookieService.get('accessToken') !== null;
  }
}
