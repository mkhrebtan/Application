import { Component, inject } from '@angular/core';
import { CalendarView } from '../../features/calendar/calendar-view/calendar-view';
import { HeroSection } from '../../layout/hero-section/hero-section';
import { EventService } from '../../core/event-service/event-service';
import { IEvent } from '../../features/event/models/event';

@Component({
  selector: 'app-my-events',
  imports: [CalendarView, HeroSection],
  templateUrl: `/my-events.html`,
  styles: ``,
})
export class MyEvents {
  protected heroTitle = 'My Events';
  protected heroDescription = 'View and manage your joined events in calendar view';
  protected readonly events: IEvent[] = [];

  private readonly eventService = inject(EventService);

  constructor() {
    this.events = this.eventService.getEvents();
  }
}
