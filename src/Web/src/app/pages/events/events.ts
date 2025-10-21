import { Component, inject, signal } from '@angular/core';
import {
  faListUl,
  faMagnifyingGlass,
  faSpinner,
  faTableCellsLarge,
} from '@fortawesome/free-solid-svg-icons';
import { FaIconComponent } from '@fortawesome/angular-fontawesome';
import { EventFilter } from '../../features/event/models/event-filter';
import { EventListingView } from '../../features/event/models/event-listing-view';
import { EventListingCard } from '../../features/event/event-listing-card/event-listing-card';
import { HeroSection } from '../../layout/hero-section/hero-section';
import { ToggleOption } from '../../shared/models/toggle-option';
import { ViewToggle } from '../../shared/components/view-toggle/view-toggle';
import { EventService } from '../../core/event-service/event-service';
import { JoinEventDialog } from '../../features/event/join-event-dialog/join-event-dialog';
import {
  combineLatest,
  debounceTime,
  distinctUntilChanged,
  Observable,
  of,
  startWith,
  switchMap,
} from 'rxjs';
import { IEventListingModel } from '../../features/event/models/event-listing-model';
import { catchError, finalize } from 'rxjs/operators';
import { AsyncPipe } from '@angular/common';
import { IPagedList } from '../../shared/models/paged-list';
import { FormControl, ReactiveFormsModule } from '@angular/forms';
import { toObservable } from '@angular/core/rxjs-interop';

@Component({
  selector: 'app-events',
  imports: [
    FaIconComponent,
    EventListingCard,
    HeroSection,
    ViewToggle,
    JoinEventDialog,
    AsyncPipe,
    ReactiveFormsModule,
  ],
  templateUrl: './events.html',
  styles: ``,
})
export class Events {
  protected heroTitle = 'Explore Upcoming Events';
  protected heroDescription = 'Join exciting events near your and connect with like-minded people';

  protected readonly faMagnifyingGlass = faMagnifyingGlass;
  protected readonly Filter = EventFilter;
  protected readonly EventListingView = EventListingView;

  protected selectedFilter = signal(EventFilter.AllEvents);
  protected viewMode = signal(EventListingView.Grid);
  protected joinEventDialogIsOpen = signal(false);
  protected readonly viewOptions: ToggleOption<EventListingView>[] = [
    { label: 'Grid View', value: EventListingView.Grid, icon: faTableCellsLarge },
    { label: 'List View', value: EventListingView.List, icon: faListUl },
  ];
  protected isEventsLoading = signal(true);
  protected events$!: Observable<IPagedList<IEventListingModel>>;
  protected readonly faSpinner = faSpinner;
  protected searchControl = new FormControl('');
  private readonly eventService = inject(EventService);

  constructor() {
    // Combine search term changes and filter changes
    const searchTerm$ = this.searchControl.valueChanges.pipe(
      startWith(''),
      debounceTime(300),
      distinctUntilChanged(),
    );

    const filter$ = toObservable(this.selectedFilter);

    this.events$ = combineLatest([searchTerm$, filter$]).pipe(
      switchMap(([searchTerm, filter]) => this.loadEvents(searchTerm, filter)),
    );
  }

  protected selectFilter(filter: EventFilter): void {
    this.selectedFilter.set(filter);
  }

  protected onJoinEventClick(event: IEventListingModel) {
    this.joinEventDialogIsOpen.set(true);
    document.body.style.overflow = 'hidden';
  }

  protected closeJoinEventDialog() {
    this.joinEventDialogIsOpen.set(false);
    document.body.style.overflow = 'auto';
  }

  protected onJoinEventFormSubmit() {
    this.closeJoinEventDialog();
    // Additional logic for handling the form submission can be added here
  }

  private loadEvents(
    searchTerm: string | null,
    filter: EventFilter,
  ): Observable<IPagedList<IEventListingModel>> {
    this.isEventsLoading.set(true);

    console.log('Events loading started with search term:', searchTerm, 'and filter:', filter);

    return this.eventService
      .getEventsList({
        searchTerm: searchTerm || null,
        today: filter === EventFilter.Today ? true : null,
        weekend: filter === EventFilter.Weekend ? true : null,
        page: 1,
        pageSize: 9,
      })
      .pipe(
        catchError((error) => {
          console.error('Failed to load events:', error);

          const emptyPagedList: IPagedList<IEventListingModel> = {
            items: [],
            page: 1,
            pageSize: 16,
            totalCount: 0,
            hasNextPage: false,
            hasPreviousPage: false,
          };

          return of(emptyPagedList);
        }),
        finalize(() => {
          this.isEventsLoading.set(false);
        }),
      );
  }
}
