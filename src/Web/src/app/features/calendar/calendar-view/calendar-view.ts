import { Component, computed, signal } from '@angular/core';
import { DatePipe } from '@angular/common';
import { FaIconComponent } from '@fortawesome/angular-fontawesome';
import { faChevronDown, faChevronLeft, faChevronRight } from '@fortawesome/free-solid-svg-icons';
import { IEvent } from '../../event/models/event';
import { CalendarViewMode } from '../models/calendar-view-mode';
import { DayCard } from '../day-card/day-card';

@Component({
  selector: 'app-calendar-view',
  imports: [DatePipe, FaIconComponent, DayCard],
  template: `
    <div class="flex flex-col gap-6">
      <section class="flex items-center justify-between">
        <div class="flex gap-4 items-center">
          <button
            class="px-3 pt-1 pb-1 border border-gray-300 shadow-sm rounded-4xl hover:bg-gray-200 cursor-pointer"
            (click)="decrementDate()"
          >
            <fa-icon [icon]="faChevronLeft" class="text-sm" />
          </button>
          <span class="text-xl font-semibold">{{
            viewMode() === calendarViewMode.Month
              ? (currentDate() | date: 'MMMM yyyy')
              : getWeekRange()
          }}</span>
          <button
            class="px-3 pt-1 pb-1 p-1 border border-gray-300 shadow-sm rounded-4xl hover:bg-gray-200 cursor-pointer"
            (click)="incrementDate()"
          >
            <fa-icon [icon]="faChevronRight" class="text-sm" />
          </button>
        </div>
        <div class="flex gap-1 p-1 border border-gray-300 shadow-sm rounded-4xl">
          <button
            [class.active]="viewMode() === calendarViewMode.Month"
            (click)="selectViewMode(calendarViewMode.Month)"
            class="px-3 pt-1 pb-1 transition-all duration-300 rounded-4xl cursor-pointer text-gray-500 hover:text-black [&.active]:text-black [&.active]:bg-gray-200"
          >
            Month
          </button>
          <button
            [class.active]="viewMode() === calendarViewMode.Week"
            (click)="selectViewMode(calendarViewMode.Week)"
            class="px-3 pt-1 pb-1 transition-all duration-300 rounded-4xl cursor-pointer text-gray-500 hover:text-black [&.active]:text-black [&.active]:bg-gray-200"
          >
            Week
          </button>
        </div>
      </section>

      @if (viewMode() === calendarViewMode.Month) {
        <section class="shadow-sm rounded-b-xl">
          <div
            class="grid grid-cols-7 text-center bg-gray-200 border-b rounded-t-xl border-gray-300"
          >
            @for (day of ['Sun', 'Mon', 'Tue', 'Wed', 'Thu', 'Fri', 'Sat']; track day) {
              <div class="p-2">{{ day }}</div>
            }
          </div>
          <div class="rounded-b-xl border-l border-b border-r border-gray-300 overflow-hidden">
            @for (week of weeks(); track week) {
              <div class="grid grid-cols-7 border-b last:border-0 border-gray-300 max-h-35">
                @for (day of week; track day) {
                  <app-day-card
                    [date]="day"
                    [events]="getEventsForDay(day)"
                    [viewMode]="viewMode()"
                    [isDisplayedMonth]="isDisplayedMonth(day)"
                    class="border-r border-gray-300 last:border-0"
                  />
                }
              </div>
            }
          </div>
        </section>
      }

      @if (viewMode() === calendarViewMode.Week) {
        <section class="grid grid-cols-7 gap-4">
          @for (day of currentWeek(); track day) {
            <app-day-card
              [date]="day"
              [events]="getEventsForDay(day)"
              [viewMode]="viewMode()"
              [isDisplayedMonth]="isDisplayedMonth(day)"
            />
          }
        </section>
      }
    </div>
  `,
  styles: ``,
})
export class CalendarView {
  protected readonly calendarViewMode = CalendarViewMode;
  protected viewMode = signal(CalendarViewMode.Month);
  protected readonly faChevronLeft = faChevronLeft;
  protected readonly faChevronRight = faChevronRight;
  protected readonly faChevronDown = faChevronDown;
  protected currentDate = signal(new Date());

  protected weeks = computed(() => {
    const date = this.currentDate();
    const year = date.getFullYear();
    const month = date.getMonth();

    const firstDay = new Date(year, month, 1);
    const daysInMonth = new Date(year, month + 1, 0).getDate();
    const startDayOfWeek = firstDay.getDay();

    const prevMonthDays = Array.from(
      { length: startDayOfWeek },
      (_, i) =>
        new Date(year, month - 1, new Date(year, month, 0).getDate() - startDayOfWeek + i + 1),
    );

    const currentMonthDays = Array.from(
      { length: daysInMonth },
      (_, i) => new Date(year, month, i + 1),
    );

    const nextMonthDays = Array.from(
      { length: (7 - ((startDayOfWeek + daysInMonth) % 7)) % 7 },
      (_, i) => new Date(year, month + 1, i + 1),
    );

    const allDays = [...prevMonthDays, ...currentMonthDays, ...nextMonthDays];
    return Array.from({ length: allDays.length / 7 }, (_, i) => allDays.slice(i * 7, i * 7 + 7));
  });

  protected currentWeek = computed(() => {
    const current = this.currentDate();
    const startOfWeek = new Date(current);
    startOfWeek.setDate(current.getDate() - current.getDay());

    return Array.from({ length: 7 }, (_, i) => {
      const day = new Date(startOfWeek);
      day.setDate(startOfWeek.getDate() + i);
      return day;
    });
  });

  decrementDate() {
    const date = this.currentDate();
    this.currentDate.set(
      this.viewMode() === CalendarViewMode.Month
        ? new Date(date.getFullYear(), date.getMonth() - 1, 1)
        : new Date(date.getFullYear(), date.getMonth(), date.getDate() - 7),
    );
  }

  incrementDate() {
    const date = this.currentDate();
    this.currentDate.set(
      this.viewMode() === CalendarViewMode.Month
        ? new Date(date.getFullYear(), date.getMonth() + 1, 1)
        : new Date(date.getFullYear(), date.getMonth(), date.getDate() + 7),
    );
  }

  getWeekRange(): string {
    const current = this.currentDate();
    const startOfWeek = new Date(current);
    startOfWeek.setDate(current.getDate() - current.getDay());

    const endOfWeek = new Date(startOfWeek);
    endOfWeek.setDate(startOfWeek.getDate() + 6);

    const format = (date: Date) =>
      date.toLocaleDateString('en-US', { month: 'short', day: 'numeric' });
    return `${format(startOfWeek)} - ${format(endOfWeek)}`;
  }

  isDisplayedMonth(date: Date): boolean {
    const current = this.currentDate();
    return date.getMonth() === current.getMonth() && date.getFullYear() === current.getFullYear();
  }

  selectViewMode(view: CalendarViewMode) {
    this.viewMode.set(view);
  }

  getEventsForDay(date: Date): IEvent[] {
    return this.events.filter((event) => {
      const eventDate = new Date(event.date);
      return (
        eventDate.getFullYear() === date.getFullYear() &&
        eventDate.getMonth() === date.getMonth() &&
        eventDate.getDate() === date.getDate()
      );
    });
  }

  protected readonly events: IEvent[] = [
    {
      id: 1,
      title: 'Angular Conference',
      description: 'A conference about Angular and its ecosystem.',
      date: new Date('2025-10-16T09:00:00'),
      location: 'New York',
      capacity: 300,
      participants: 150,
    },
    {
      id: 2,
      title: 'React Summit',
      description: 'The biggest React conference in the world.',
      date: new Date('2025-10-16T10:00:00'),
      location: 'San Francisco',
      participants: 400,
    },
    {
      id: 3,
      title: 'Vue.js Meetup',
      description: 'Monthly meetup for Vue.js.',
      date: new Date('2025-10-16T18:00:00'),
      location: 'Los Angeles',
      participants: 80,
    },
    {
      id: 3,
      title: 'Vue.js Meetup',
      description: 'Monthly meetup for Vue.js.',
      date: new Date('2025-10-16T18:00:00'),
      location: 'Los Angeles',
      participants: 80,
    },
    {
      id: 4,
      title: 'JavaScript Workshop',
      description: 'Hands-on workshop covering modern JavaScript features.',
      date: new Date('2025-09-25T14:00:00'),
      location: 'Chicago',
      capacity: 100,
      participants: 100,
    },
    {
      id: 5,
      title: 'Tech Expo 2023',
      description: 'Annual technology exposition showcasing the latest innovations.',
      date: new Date('2025-11-30T09:00:00'),
      location: 'Miami',
      capacity: 1000,
      participants: 100,
    },
    {
      id: 6,
      title: 'Full Stack Developer Bootcamp',
      description: 'Intensive bootcamp for aspiring full stack developers.',
      date: new Date('2025-12-10T08:00:00'),
      location: 'Seattle',
      participants: 50,
    },
    {
      id: 7,
      title: 'AI & Machine Learning Conference',
      description: 'Exploring the future of AI and machine learning technologies.',
      date: new Date('2025-01-15T09:00:00'),
      location: 'Boston',
      capacity: 400,
      participants: 350,
    },
    {
      id: 8,
      title: 'Cybersecurity Seminar',
      description: 'Seminar on the latest trends in cybersecurity.',
      date: new Date('2025-10-05T11:00:00'),
      location: 'Austin',
      capacity: 200,
      participants: 180,
    },
    {
      id: 9,
      title: 'Cloud Computing Workshop',
      description: 'Workshop on cloud computing platforms and services.',
      date: new Date('2025-09-15T13:00:00'),
      location: 'Denver',
      participants: 70,
    },
    {
      id: 10,
      title: 'DevOps Days',
      description: 'Conference focused on DevOps practices and culture.',
      date: new Date('2025-11-20T09:00:00'),
      location: 'Portland',
      capacity: 250,
      participants: 200,
    },
  ];
}
