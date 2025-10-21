import { Component } from '@angular/core';
import { RouterLink } from '@angular/router';

@Component({
  selector: 'app-not-found',
  imports: [RouterLink],
  template: `
    <div class="flex flex-col items-center justify-center h-full text-center p-4">
      <h1 class="text-6xl font-bold mb-4">404</h1>
      <h2 class="text-2xl font-semibold mb-2">Page Not Found</h2>
      <p class="text-gray-600 mb-6">The page you are looking for does not exist.</p>
      <a routerLink="/" class="text-blue-500 hover:underline">Go back to Home</a>
    </div>
  `,
  styles: ``,
})
export class NotFound {}
