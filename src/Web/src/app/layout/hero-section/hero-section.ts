import { Component, Input } from '@angular/core';

@Component({
  selector: 'app-hero-section',
  imports: [],
  template: `
    <section class="flex flex-col gap-5 text-left">
      <h1 class="text-5xl font-semibold">{{ title }}</h1>
      <p class="text-gray-600 text-md">
        {{ description }}
      </p>
    </section>
  `,
  styles: ``,
})
export class HeroSection {
  @Input() title!: string;
  @Input() description!: string;
}
