import { Component } from '@angular/core';
import { CalendarView } from '../../features/calendar/calendar-view/calendar-view';

@Component({
  selector: 'app-my-events',
  imports: [CalendarView],
  templateUrl: `/my-events.html`,
  styles: ``,
})
export class MyEvents {}
