import { Component, inject, signal } from '@angular/core';
import { CalendarView } from '../../features/calendar/calendar-view/calendar-view';
import { HeroSection } from '../../layout/hero-section/hero-section';
import { EventService } from '../../core/event-service/event-service';
import { Observable } from 'rxjs';
import { IUserEvent } from '../../features/event/models/user-event';
import { catchError, tap } from 'rxjs/operators';
import { AsyncPipe } from '@angular/common';

@Component({
  selector: 'app-my-events',
  imports: [CalendarView, HeroSection, AsyncPipe],
  templateUrl: `/my-events.html`,
  styles: ``,
})
export class MyEvents {
  protected heroTitle = 'My Events';
  protected heroDescription = 'View and manage your joined events in calendar view';
  protected events$: Observable<IUserEvent[]>;
  protected isLoading = signal(true);
  private readonly eventService = inject(EventService);

  constructor() {
    this.events$ = this.eventService.getUserEvents().pipe(
      tap(() => {
        this.isLoading.set(false);
      }),
      catchError((error: Error) => {
        this.isLoading.set(false);
        throw error;
      }),
    );
  }
}
