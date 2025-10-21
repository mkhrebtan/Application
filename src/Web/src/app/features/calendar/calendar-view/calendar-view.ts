import { Component, computed, Input, signal } from '@angular/core';
import { FaIconComponent } from '@fortawesome/angular-fontawesome';
import { faChevronLeft, faChevronRight } from '@fortawesome/free-solid-svg-icons';
import { IEvent } from '../../event/models/event';
import { CalendarViewMode } from '../models/calendar-view-mode';
import { DayCard } from '../day-card/day-card';
import { ToggleOption } from '../../../shared/models/toggle-option';
import { ViewToggle } from '../../../shared/components/view-toggle/view-toggle';
import { CalendarDay } from '../models/calendar-day';

@Component({
  selector: 'app-calendar-view',
  imports: [FaIconComponent, DayCard, ViewToggle],
  templateUrl: './calendar-view.html',
  styles: ``,
})
export class CalendarView {
  private _events: IEvent[] = [];
  private _eventsByDay = new Map<string, IEvent[]>();
  @Input()
  set events(value: IEvent[]) {
    this._events = value || [];
    this.buildEventsMap();
  }
  protected readonly calendarViewMode = CalendarViewMode;
  protected viewMode = signal(CalendarViewMode.Month);
  protected readonly calendarViewOptions: ToggleOption<CalendarViewMode>[] = [
    { label: 'Month', value: CalendarViewMode.Month },
    { label: 'Week', value: CalendarViewMode.Week },
  ];
  protected readonly faChevronLeft = faChevronLeft;
  protected readonly faChevronRight = faChevronRight;
  protected currentDate = signal(new Date());
  protected weeks = computed((): CalendarDay[][] => {
    const date = this.currentDate();
    const year = date.getFullYear();
    const month = date.getMonth();

    const firstDay = new Date(year, month, 1);
    const daysInMonth = new Date(year, month + 1, 0).getDate();
    const startDayOfWeek = firstDay.getDay();

    const prevMonthDays: CalendarDay[] = Array.from({ length: startDayOfWeek }, (_, i) => ({
      date: new Date(year, month - 1, new Date(year, month, 0).getDate() - startDayOfWeek + i + 1),
      isDisplayedMonth: false,
    }));

    const currentMonthDays: CalendarDay[] = Array.from({ length: daysInMonth }, (_, i) => ({
      date: new Date(year, month, i + 1),
      isDisplayedMonth: true,
    }));

    const nextMonthDays: CalendarDay[] = Array.from(
      { length: (7 - ((startDayOfWeek + daysInMonth) % 7)) % 7 },
      (_, i) => ({
        date: new Date(year, month + 1, i + 1),
        isDisplayedMonth: false,
      }),
    );

    const allDays = [...prevMonthDays, ...currentMonthDays, ...nextMonthDays];
    return Array.from({ length: allDays.length / 7 }, (_, i) => allDays.slice(i * 7, i * 7 + 7));
  });

  protected currentWeek = computed((): CalendarDay[] => {
    const current = this.currentDate();
    const startOfWeek = new Date(current);
    startOfWeek.setDate(current.getDate() - current.getDay());

    return Array.from({ length: 7 }, (_, i) => {
      const day = new Date(startOfWeek);
      day.setDate(startOfWeek.getDate() + i);
      return {
        date: day,
        isDisplayedMonth: true,
      };
    });
  });

  get events(): IEvent[] {
    return this._events;
  }

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

  protected displayedDateRange = computed(() => {
    if (this.viewMode() === CalendarViewMode.Week) {
      const current = this.currentDate();
      const startOfWeek = new Date(current);
      startOfWeek.setDate(current.getDate() - current.getDay());

      const endOfWeek = new Date(startOfWeek);
      endOfWeek.setDate(startOfWeek.getDate() + 6);

      const format = (date: Date) =>
        date.toLocaleDateString('en-US', { month: 'short', day: 'numeric' });
      return `${format(startOfWeek)} - ${format(endOfWeek)}`;
    }

    const format = (date: Date) =>
      date.toLocaleDateString('en-US', { month: 'long', year: 'numeric' });
    return format(this.currentDate());
  });

  getEventsForDay(date: Date): IEvent[] {
    const key = date.toDateString();
    return this._eventsByDay.get(key) || [];
  }

  private buildEventsMap(): void {
    this._eventsByDay.clear();

    for (const event of this._events) {
      const eventDate = new Date(event.date);
      const key = eventDate.toDateString();

      if (!this._eventsByDay.has(key)) {
        this._eventsByDay.set(key, []);
      }

      this._eventsByDay.get(key)!.push(event);
    }
  }
}
