import { Component, Input, signal } from '@angular/core';
import { FaIconComponent } from '@fortawesome/angular-fontawesome';
import { faChevronDown } from '@fortawesome/free-solid-svg-icons';
import { RouterLink } from '@angular/router';
import { IUserEvent } from '../../event/models/user-event';

@Component({
  selector: 'app-day-events-list',
  imports: [FaIconComponent, RouterLink],
  template: `
    <div class="p-2 rounded-md" [class.bg-white]="isExpanded()" [class.shadow-sm]="isExpanded()">
      @for (event of events.slice(0, 2); track event.id) {
        <div
          class="text-xs px-1 py-0.5 rounded mb-1 truncate cursor-pointer"
          [class.bg-indigo-200]="!event.isUserOrganizer"
          [class.bg-green-600]="event.isUserOrganizer"
          [class.text-indigo-800]="!event.isUserOrganizer"
          [class.text-white]="event.isUserOrganizer"
          [routerLink]="['/events', event.id]"
        >
          {{ event.title }}
        </div>
      }

      @if (events.length > 2) {
        <div class="max-h-0 overflow-hidden" [class.max-h-fit]="isExpanded()">
          @for (event of events.slice(2); track event.id) {
            <div
              class="text-xs px-1 py-0.5 rounded mb-1 truncate cursor-pointer"
              [class.bg-indigo-200]="!event.isUserOrganizer"
              [class.bg-green-600]="event.isUserOrganizer"
              [class.text-indigo-800]="!event.isUserOrganizer"
              [class.text-white]="event.isUserOrganizer"
              [routerLink]="['/events', event.id]"
            >
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
  @Input() events: IUserEvent[] = [];
  protected readonly faChevronDown = faChevronDown;
  protected isExpanded = signal(false);

  protected toggleExpand(): void {
    this.isExpanded.update((expanded) => !expanded);
  }
}
