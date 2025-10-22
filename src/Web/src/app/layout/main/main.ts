import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { Header } from '../header/header';

@Component({
  selector: 'app-main',
  imports: [RouterOutlet, Header],
  template: `
    <app-header />
    <main class="px-4 md:px-12">
      <router-outlet />
    </main>
  `,
  styles: ``,
})
export class Main {}
