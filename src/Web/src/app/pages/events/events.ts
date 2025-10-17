import { Component, signal, inject } from '@angular/core';
import { faTableCellsLarge, faListUl, faMagnifyingGlass } from '@fortawesome/free-solid-svg-icons';
import { FaIconComponent } from '@fortawesome/angular-fontawesome';
import { EventFilter } from '../../features/event/models/event-filter';
import { EventListingView } from '../../features/event/models/event-listing-view';
import { IEvent } from '../../features/event/models/event';
import { EventListingCard } from '../../features/event/event-listing-card/event-listing-card';
import { HeroSection } from '../../layout/hero-section/hero-section';
import { ToggleOption } from '../../shared/models/toggle-option';
import { ViewToggle } from '../../shared/components/view-toggle/view-toggle';
import { EventService } from '../../core/services/event-service';

@Component({
  selector: 'app-events',
  imports: [FaIconComponent, EventListingCard, HeroSection, ViewToggle],
  templateUrl: './events.html',
  styles: ``,
})
export class Events {
  protected heroTitle = 'Explore Upcoming Events';
  protected heroDescription = 'Join exciting events near your and connect with like-minded people';
  protected readonly faMagnifyingGlass = faMagnifyingGlass;
  protected readonly Filter = EventFilter;
  protected selectedFilter = signal(EventFilter.AllEvents);
  protected readonly EventListingView = EventListingView;
  protected viewMode = signal(EventListingView.Grid);
  protected readonly viewOptions: ToggleOption<EventListingView>[] = [
    { label: 'Grid View', value: EventListingView.Grid, icon: faTableCellsLarge },
    { label: 'List View', value: EventListingView.List, icon: faListUl },
  ];
  protected readonly events: IEvent[] = [];
  protected filteredEvents: IEvent[] = [];
  private readonly eventService = inject(EventService);

  constructor() {
    this.events = this.eventService.getEvents();
    this.filteredEvents = this.events;
  }

  protected selectFilter(filter: EventFilter): void {
    this.selectedFilter.set(filter);
  }

  protected selectViewMode(mode: EventListingView): void {
    this.viewMode.set(mode);
  }
}
