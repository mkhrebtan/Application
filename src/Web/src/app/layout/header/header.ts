import { Component } from '@angular/core';
import { faListUl, faPlus } from '@fortawesome/free-solid-svg-icons';
import { faCalendar } from '@fortawesome/free-regular-svg-icons';
import { FaIconComponent } from '@fortawesome/angular-fontawesome';
import { RouterLink, RouterLinkActive } from '@angular/router';

@Component({
  selector: 'app-header',
  imports: [FaIconComponent, RouterLinkActive, RouterLink],
  templateUrl: './header.html',
  styles: ``,
})
export class Header {
  protected readonly faListUl = faListUl;
  protected readonly faPlus = faPlus;
  protected readonly faCalendar = faCalendar;
}
