import { Component, signal } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { SsrCookieService } from 'ngx-cookie-service-ssr';

@Component({
  selector: 'app-root',
  imports: [RouterOutlet],
  template: ` <router-outlet /> `,
  styles: [],
  providers: [SsrCookieService],
})
export class App {
  protected readonly title = signal('Web');
}
