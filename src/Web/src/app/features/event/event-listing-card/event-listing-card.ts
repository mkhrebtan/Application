import { Component, EventEmitter, inject, Input, OnInit, Output, signal } from '@angular/core';
import { DatePipe } from '@angular/common';
import { faInfinity, faLocationDot, faUsers } from '@fortawesome/free-solid-svg-icons';
import { FaIconComponent } from '@fortawesome/angular-fontawesome';
import { faClock } from '@fortawesome/free-regular-svg-icons';
import { EventListingView } from '../models/event-listing-view';
import { Router } from '@angular/router';
import { IEventListingModel } from '../models/event-listing-model';

@Component({
  selector: 'app-event-listing-card',
  imports: [DatePipe, FaIconComponent],
  templateUrl: './event-listing-card.html',
  styles: ``,
})
export class EventListingCard implements OnInit {
  @Input() event!: IEventListingModel;
  @Input() viewMode: EventListingView = EventListingView.Grid;
  @Output() joinClick = new EventEmitter<IEventListingModel>();
  protected readonly faInfinity = faInfinity;
  protected readonly faClock = faClock;
  protected readonly faLocationDot = faLocationDot;
  protected readonly faUsers = faUsers;
  protected readonly EventListingView = EventListingView;
  protected readonly EventState = EventState;
  protected eventState = signal(EventState.CanJoin);
  private router = inject(Router);

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

  joinEvent(event: Event) {
    event.stopPropagation();
    this.joinClick.emit(this.event);
  }
}

export enum EventState {
  CanJoin,
  Joined,
  Full,
}
