import { Component, Input, signal } from '@angular/core';
import { FaIconComponent } from '@fortawesome/angular-fontawesome';
import { faChevronDown } from '@fortawesome/free-solid-svg-icons';

@Component({
  selector: 'app-day-events-list',
  imports: [FaIconComponent],
  template: `
    <div class="p-2 rounded-md" [class.bg-white]="isExpanded()" [class.shadow-sm]="isExpanded()">
      @for (event of events.slice(0, 2); track event.id) {
        <div class="text-xs bg-indigo-200 text-indigo-800 px-1 py-0.5 rounded mb-1 truncate">
          {{ event.title }}
        </div>
      }

      @if (events.length > 2) {
        <div class="max-h-0 overflow-hidden" [class.max-h-fit]="isExpanded()">
          @for (event of events.slice(2); track event.id) {
            <div class="text-xs bg-indigo-200 text-indigo-800 px-1 py-0.5 rounded mb-1 truncate">
              {{ event.title }}
            </div>
          }
        </div>
        <div class="flex justify-between text-xs">
          <div
            class="text-gray-500 mt-1 transition-opacity duration-300"
            [class.opacity-100]="!isExpanded()"
            [class.opacity-0]="isExpanded()"
          >
            +{{ events.length - 2 }} more
          </div>
          <button
            class="cursor-pointer transition-rotate duration-300"
            (click)="toggleExpand()"
            aria-label="Toggle event details"
            [class.-rotate-180]="isExpanded()"
          >
            <fa-icon class="text-indigo-600" [icon]="faChevronDown" />
          </button>
        </div>
      }
    </div>
  `,
  styles: ``,
})
export class DayEventsList {
  protected readonly faChevronDown = faChevronDown;
  protected isExpanded = signal(false);
  @Input() events: any[] = [];

  protected toggleExpand(): void {
    this.isExpanded.update((expanded) => !expanded);
  }
}
