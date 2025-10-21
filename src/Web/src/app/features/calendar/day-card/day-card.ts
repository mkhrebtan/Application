import { Component, Input, OnInit } from '@angular/core';
import { CalendarViewMode } from '../models/calendar-view-mode';
import { DatePipe } from '@angular/common';
import { DayEventsList } from '../day-events-list/day-events-list';
import { IUserEvent } from '../../event/models/user-event';

@Component({
  selector: 'app-day-card',
  imports: [DatePipe, DayEventsList],
  template: `
    @if (viewMode === calendarViewMode.Month) {
      <div
        class="p-1 flex flex-col aspect-1/2 lg:aspect-3/2 max-h-34 w-full"
        [class.bg-gray-100]="!isDisplayedMonth"
        [class.text-gray-400]="!isDisplayedMonth"
        [class.text-indigo-600]="isPresentDay"
        [class.bg-indigo-50]="isPresentDay"
      >
        <span class="text-xs md:text-base md:font-medium px-2">{{ date | date: 'd' }}</span>
        <div class="mt-1 relative">
          <app-day-events-list [events]="events" class="absolute w-full" />
        </div>
      </div>
    }

    @if (viewMode === calendarViewMode.Week) {
      <div class="border border-gray-300 rounded-xl shadow-sm pt-4 pb-4 px-2 min-h-48">
        <div class="flex flex-col gap-2">
          <div class="text-center">
            <div class="text-sm text-gray-500 font-medium">
              {{ date | date: 'EEE' }}
            </div>
            <div
              class="text-2xl font-semibold mt-1"
              [class.text-indigo-600]="isPresentDay"
              [class.bg-indigo-100]="isPresentDay"
              [class.rounded-full]="isPresentDay"
              [class.text-center]="isPresentDay"
              [class]="{ 'w-1/2': isPresentDay }"
              [class.mx-auto]="isPresentDay"
            >
              {{ date | date: 'd' }}
            </div>
          </div>
          <div class="relative">
            @if (events.length > 0) {
              <app-day-events-list [events]="events" class="absolute w-full" />
            } @else {
              <div class="text-xs text-gray-400 text-center mt-8">No events</div>
            }
          </div>
        </div>
      </div>
    }
  `,
  styles: ``,
})
export class DayCard implements OnInit {
  @Input() date!: Date;
  @Input() events: IUserEvent[] = [];
  @Input() viewMode!: CalendarViewMode;
  @Input() isDisplayedMonth: boolean = true;

  protected isPresentDay = false;
  protected readonly calendarViewMode = CalendarViewMode;

  ngOnInit() {
    this.isPresentDay = this.isToday(this.date);
  }

  private isToday(date: Date): boolean {
    const today = new Date();
    return date.toDateString() === today.toDateString();
  }
}
