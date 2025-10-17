import { Component } from '@angular/core';
import { CalendarView } from '../../features/calendar/calendar-view/calendar-view';
import { HeroSection } from '../../layout/hero-section/hero-section';

@Component({
  selector: 'app-my-events',
  imports: [CalendarView, HeroSection],
  templateUrl: `/my-events.html`,
  styles: ``,
})
export class MyEvents {
  protected heroTitle = 'My Events';
  protected heroDescription = 'View and manage your joined events in calendar view';
}
