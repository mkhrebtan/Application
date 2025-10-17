import { Component, Input, OnInit, inject, signal } from '@angular/core';
import { IEvent } from '../models/event';
import { DatePipe } from '@angular/common';
import { faInfinity, faLocationDot, faUsers } from '@fortawesome/free-solid-svg-icons';
import { FaIconComponent } from '@fortawesome/angular-fontawesome';
import { faClock } from '@fortawesome/free-regular-svg-icons';
import { EventListingView } from '../models/event-listing-view';
import { Router } from '@angular/router';

@Component({
  selector: 'app-event-listing-card',
  imports: [DatePipe, FaIconComponent],
  template: `
    <div
      (click)="navigateToDetails()"
      class="border p-4 rounded-lg flex flex-col gap-5 border-gray-300 shadow-md group cursor-pointer hover:scale-[1.02] transition-all duration-300"
    >
      <div class="flex flex-col gap-2">
        <h3 class="text-xl font-semibold line-clamp-1">
          {{ event.title }}
        </h3>
        <p class="leading-normal h-12 line-clamp-2 text-gray-600">{{ event.description }}</p>
      </div>
      <div
        class="flex flex-col "
        [class.flex-col]="viewMode === EventListingView.Grid"
        [class.gap-5]="viewMode === EventListingView.Grid"
      >
        <div
          class="text-gray-600 flex-1"
          [class.flex]="viewMode === EventListingView.List"
          [class.gap-6]="viewMode === EventListingView.List"
        >
          <div class="flex items-center gap-2">
            <fa-icon class="text-sm" [icon]="faClock" />
            <p>{{ event.date | date: 'mediumDate' }} | {{ event.date | date: 'shortTime' }}</p>
          </div>
          <div class="flex items-center gap-2">
            <fa-icon class="text-sm" [icon]="faLocationDot" />
            <p>{{ event.location }}</p>
          </div>
          <div class="flex items-center gap-2">
            <fa-icon class="text-sm" [icon]="faUsers" />
            <div class="flex gap-1 items-center">
              <p>{{ event.participants }}</p>
              <span>/</span>
              @if (event.capacity) {
                <p>{{ event.capacity }}</p>
              } @else {
                <fa-icon class="text-sm" [icon]="faInfinity" />
              }
            </div>
          </div>
        </div>
        <button
          class="rounded-md p-1.5 transition-all duration-300 text-white shadow-md flex-1"
          [class.cursor-pointer]="eventState() != EventState.Full"
          [class.bg-green-600]="eventState() == EventState.CanJoin"
          [class.hover:bg-green-500]="eventState() == EventState.CanJoin"
          [class.cursor-not-allowed]="eventState() != EventState.CanJoin"
          [class.bg-gray-400]="eventState() == EventState.Full"
          [class.bg-red-600]="eventState() == EventState.Joined"
          [class.hover:bg-red-500]="eventState() == EventState.Joined"
        >
          @if (eventState() == EventState.Full) {
            Full
          } @else if (eventState() == EventState.Joined) {
            Joined
          } @else {
            Join Event
          }
        </button>
      </div>
    </div>
  `,
  styles: ``,
})
export class EventListingCard implements OnInit {
  @Input() event!: IEvent;
  @Input() viewMode: EventListingView = EventListingView.Grid;

  private router = inject(Router);
  protected readonly faInfinity = faInfinity;
  protected readonly faClock = faClock;
  protected readonly faLocationDot = faLocationDot;
  protected readonly faUsers = faUsers;
  protected readonly EventListingView = EventListingView;
  protected readonly EventState = EventState;
  protected eventState = signal(EventState.CanJoin);

  ngOnInit() {
    if (this.event.capacity && this.event.participants >= this.event.capacity) {
      this.eventState.set(EventState.Full);
    } else {
      this.eventState.set(EventState.CanJoin);
    }
  }

  navigateToDetails() {
    this.router.navigate(['/events', this.event.id]);
  }
}

export enum EventState {
  CanJoin,
  Joined,
  Full,
}
