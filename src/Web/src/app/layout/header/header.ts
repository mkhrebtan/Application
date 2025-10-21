import { Component, inject } from '@angular/core';
import { faArrowRightFromBracket, faListUl, faPlus } from '@fortawesome/free-solid-svg-icons';
import { faCalendar, faUser } from '@fortawesome/free-regular-svg-icons';
import { FaIconComponent } from '@fortawesome/angular-fontawesome';
import { Router, RouterLink, RouterLinkActive } from '@angular/router';
import { AuthService } from '../../core/auth/auth-service/auth-service';
import { AsyncPipe } from '@angular/common';

@Component({
  selector: 'app-header',
  imports: [FaIconComponent, RouterLinkActive, RouterLink, AsyncPipe],
  templateUrl: './header.html',
  styles: ``,
})
export class Header {
  protected readonly faListUl = faListUl;
  protected readonly faPlus = faPlus;
  protected readonly faCalendar = faCalendar;
  protected readonly faUser = faUser;
  protected readonly faArrowRightFromBracket = faArrowRightFromBracket;
  protected authService = inject(AuthService);
  private router = inject(Router);

  logout(): void {
    this.authService.logout();
    if (this.router.url !== '/events') {
      this.router.navigate(['/events']);
    } else {
      window.location.reload();
    }
  }
}
