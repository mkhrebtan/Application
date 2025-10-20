import { Component, inject, OnInit, signal } from '@angular/core';
import { faListUl, faMagnifyingGlass, faTableCellsLarge } from '@fortawesome/free-solid-svg-icons';
import { FaIconComponent } from '@fortawesome/angular-fontawesome';
import { EventFilter } from '../../features/event/models/event-filter';
import { EventListingView } from '../../features/event/models/event-listing-view';
import { EventListingCard } from '../../features/event/event-listing-card/event-listing-card';
import { HeroSection } from '../../layout/hero-section/hero-section';
import { ToggleOption } from '../../shared/models/toggle-option';
import { ViewToggle } from '../../shared/components/view-toggle/view-toggle';
import { EventService } from '../../core/event-service/event-service';
import { JoinEventDialog } from '../../features/event/join-event-dialog/join-event-dialog';
import { Observable } from 'rxjs';
import { IEventListingModel } from '../../features/event/models/event-listing-model';
import { catchError } from 'rxjs/operators';
import { AsyncPipe } from '@angular/common';

@Component({
  selector: 'app-events',
  imports: [FaIconComponent, EventListingCard, HeroSection, ViewToggle, JoinEventDialog, AsyncPipe],
  templateUrl: './events.html',
  styles: ``,
})
export class Events implements OnInit {
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
  protected isEventsLoading = signal(false);
  protected events$!: Observable<IEventListingModel[]>;
  private readonly eventService = inject(EventService);

  ngOnInit() {
    this.loadEvents();
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

  private loadEvents(): void {
    this.isEventsLoading.set(true);

    this.events$ = this.eventService.getEventsList({ page: 1, pageSize: 16 }).pipe(
      catchError((error) => {
        this.isEventsLoading.set(false);
        throw error;
      }),
    );

    this.isEventsLoading.set(false);
  }
}
