import { Component, inject, signal } from '@angular/core';
import { HeroSection } from '../../layout/hero-section/hero-section';
import { ActivatedRoute, Router } from '@angular/router';
import { IEvent } from '../../features/event/models/event';
import { EventService } from '../../core/services/event-service';
import { DatePipe } from '@angular/common';
import { FaIconComponent } from '@fortawesome/angular-fontawesome';
import { faClock } from '@fortawesome/free-regular-svg-icons';
import { faLocationDot, faUsers, faInfinity } from '@fortawesome/free-solid-svg-icons';
import { EventState } from '../../features/event/event-listing-card/event-listing-card';

@Component({
  selector: 'app-event-details',
  imports: [HeroSection, DatePipe, FaIconComponent],
  templateUrl: './event-details.html',
  styles: ``,
})
export class EventDetails {
  protected event!: IEvent;
  protected readonly participants = [
    'Alice',
    'Bob',
    'Charlie',
    'Diana',
    'Ethan',
    'Fiona',
    'George',
    'Hannah',
    'Ian',
    'Julia',
    'Kevin',
    'Laura',
    'Michael',
  ];
  private activatedRoute = inject(ActivatedRoute);
  private eventService = inject(EventService);
  private router = inject(Router);

  protected readonly faClock = faClock;
  protected readonly faLocationDot = faLocationDot;
  protected readonly faUsers = faUsers;
  protected readonly faInfinity = faInfinity;

  protected readonly EventState = EventState;
  protected eventState = signal(EventState.CanJoin);

  constructor() {
    let eventId: number = 0;
    this.activatedRoute.params.subscribe((params) => {
      eventId = params['id'];
    });
    const eventFetch = this.eventService.getEventById(eventId);
    if (eventFetch) {
      this.event = eventFetch;
    } else {
      this.router.navigate(['/404']);
    }
  }
}
