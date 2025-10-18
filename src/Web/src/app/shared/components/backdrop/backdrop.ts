import { Component, EventEmitter, Output } from '@angular/core';

@Component({
  selector: 'app-backdrop',
  imports: [],
  template: `
    <div
      class="fixed top-0 left-0 w-full h-full bg-black/50 z-20 animate-fade-in"
      (click)="onClick()"
    ></div>
  `,
  styles: ``,
})
export class Backdrop {
  @Output() backdropClick = new EventEmitter<void>();

  onClick() {
    this.backdropClick.emit();
  }
}
