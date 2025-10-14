import { Component, signal } from '@angular/core';
import { faTableCells, faListUl, faMagnifyingGlass } from '@fortawesome/free-solid-svg-icons';
import { FaIconComponent } from '@fortawesome/angular-fontawesome';

@Component({
  selector: 'app-events',
  imports: [FaIconComponent],
  template: `
    <div class="w-full px-12 pt-8 pb-8 flex flex-col gap-10">
      <section class="flex flex-col gap-5">
        <h1 class="text-5xl text-center">Discover Events</h1>
        <p class="text-center">
          Join exciting events near your and connect with like-minded people
        </p>
      </section>
      <section class="flex items-center justify-between">
        <!--          <h2 class="text-2xl">Upcoming Events</h2>-->
        <div class="flex items-center gap-8 w-full h-full">
          <div class="relative flex items-center">
            <fa-icon [icon]="faMagnifyingGlass" class="absolute left-4 text-gray-400" />
            <input
              type="text"
              placeholder="Search events..."
              id="eventSearch"
              class="w-full pt-2 pb-2 pr-2 pl-12 placeholder:text-gray-400 border rounded-4xl border-gray-300 shadow-sm focus:outline-none focus:border-gray-400"
            />
          </div>
          <div class="flex gap-2">
            <button
              [class.active]="selectedFilter() === Filter.AllEvents"
              (click)="selectFilter(Filter.AllEvents)"
              class="relative overflow-hidden px-3 cursor-pointer before:content-['']
                    before:absolute before:bottom-0 before:left-1/2 before:w-0 before:h-px before:bg-black before:transition-all before:duration-300
                    [&.active]:before:w-11/12 [&.active]:before:left-[5%] [&.active]:font-semibold"
            >
              All Events
            </button>
            <button
              [class.active]="selectedFilter() === Filter.Today"
              (click)="selectFilter(Filter.Today)"
              class="relative overflow-hidden px-3 cursor-pointer before:content-['']
                    before:absolute before:bottom-0 before:left-1/2 before:w-0 before:h-px before:bg-black before:transition-all before:duration-300
                    [&.active]:before:w-11/12 [&.active]:before:left-[5%] [&.active]:font-semibold"
            >
              Today
            </button>
            <button
              [class.active]="selectedFilter() === Filter.Weekend"
              (click)="selectFilter(Filter.Weekend)"
              class="relative overflow-hidden px-3 cursor-pointer before:content-['']
                    before:absolute before:bottom-0 before:left-1/2 before:w-0 before:h-px before:bg-black before:transition-all before:duration-300
                    [&.active]:before:w-11/12 [&.active]:before:left-[5%] [&.active]:font-semibold"
            >
              Weekend
            </button>
          </div>
        </div>
        <div class="flex gap-1 p-1 border border-gray-300 shadow-sm rounded-4xl">
          <button
            [class.active]="viewMode() === ViewMode.Grid"
            (click)="selectViewMode(ViewMode.Grid)"
            class="px-2 pt-1 pb-1 transition-all duration-300 rounded-4xl cursor-pointer hover:bg-gray-200 [&.active]:bg-gray-200"
          >
            <fa-icon [icon]="faTableCells" class="text-xl" />
          </button>
          <button
            [class.active]="viewMode() === ViewMode.List"
            (click)="selectViewMode(ViewMode.List)"
            class="px-2 pt-1 pb-1 transition-all duration-300 rounded-4xl cursor-pointer hover:bg-gray-200 [&.active]:bg-gray-200"
          >
            <fa-icon [icon]="faListUl" class="text-xl" />
          </button>
        </div>
      </section>
    </div>
  `,
  styles: ``,
})
export class Events {
  protected Filter = Filter;
  protected selectedFilter = signal(Filter.AllEvents);
  protected ViewMode = ViewMode;
  protected viewMode = signal(ViewMode.Grid);

  protected selectFilter(filter: Filter): void {
    this.selectedFilter.set(filter);
  }

  protected selectViewMode(mode: ViewMode): void {
    this.viewMode.set(mode);
  }

  protected readonly faTableCells = faTableCells;
  protected readonly faListUl = faListUl;
  protected readonly faMagnifyingGlass = faMagnifyingGlass;
}

enum Filter {
  AllEvents,
  Today,
  Weekend,
}

enum ViewMode {
  Grid,
  List,
}
