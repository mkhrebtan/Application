import { Component, inject } from '@angular/core';
import { CalendarView } from '../../features/calendar/calendar-view/calendar-view';
import { HeroSection } from '../../layout/hero-section/hero-section';
import { EventService } from '../../core/event-service/event-service';
import { Observable, of } from 'rxjs';
import { IUserEvent } from '../../features/event/models/user-event';
import { catchError } from 'rxjs/operators';
import { AsyncPipe } from '@angular/common';
import { faSpinner } from '@fortawesome/free-solid-svg-icons';
import { FaIconComponent } from '@fortawesome/angular-fontawesome';

@Component({
  selector: 'app-my-events',
  imports: [CalendarView, HeroSection, AsyncPipe, FaIconComponent],
  templateUrl: `/my-events.html`,
  styles: ``,
})
export class MyEvents {
  protected heroTitle = 'My Events';
  protected heroDescription = 'View and manage your joined events in calendar view';
  protected events$!: Observable<IUserEvent[]>;
  protected readonly faSpinner = faSpinner;
  private readonly eventService = inject(EventService);

  constructor() {
    this.events$ = this.loadUserEvents();
  }

  private loadUserEvents(): Observable<IUserEvent[]> {
    return this.eventService.getUserEvents().pipe(
      catchError((err) => {
        console.error('Error loading user events', err);
        return of([]);
      }),
    );
  }
}
