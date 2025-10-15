import { Component, signal } from '@angular/core';
import { faTableCellsLarge, faListUl, faMagnifyingGlass } from '@fortawesome/free-solid-svg-icons';
import { FaIconComponent } from '@fortawesome/angular-fontawesome';
import { EventFilter } from '../../features/event/models/event-filter';
import { EventListingView } from '../../features/event/models/event-listing-view';
import { IEvent } from '../../features/event/models/event';
import { EventListingCard } from '../../features/event/event-listing-card/event-listing-card';

@Component({
  selector: 'app-events',
  imports: [FaIconComponent, EventListingCard],
  templateUrl: './events.html',
  styles: ``,
})
export class Events {
  protected Filter = EventFilter;
  protected selectedFilter = signal(EventFilter.AllEvents);
  protected viewMode = signal(EventListingView.Grid);
  protected filteredEvents: IEvent[] = [];

  constructor() {
    this.filteredEvents = this.events;
  }

  protected selectFilter(filter: EventFilter): void {
    this.selectedFilter.set(filter);
  }

  protected selectViewMode(mode: EventListingView): void {
    this.viewMode.set(mode);
  }

  protected readonly faTableCells = faTableCellsLarge;
  protected readonly faListUl = faListUl;
  protected readonly faMagnifyingGlass = faMagnifyingGlass;
  protected readonly events: IEvent[] = [
    {
      id: '1',
      title: 'Angular Conference',
      description: 'A conference about Angular and its ecosystem.',
      date: new Date('2023-11-15T09:00:00'),
      location: 'New York',
      capacity: 300,
      participants: 150,
    },
    {
      id: '2',
      title: 'React Summit',
      description: 'The biggest React conference in the world.',
      date: new Date('2023-12-05T10:00:00'),
      location: 'San Francisco',
      participants: 400,
    },
    {
      id: '3',
      title: 'Vue.js Meetup',
      description: 'Monthly meetup for Vue.js.',
      date: new Date('2023-10-20T18:00:00'),
      location: 'Los Angeles',
      participants: 80,
    },
    {
      id: '4',
      title: 'JavaScript Workshop',
      description: 'Hands-on workshop covering modern JavaScript features.',
      date: new Date('2023-09-25T14:00:00'),
      location: 'Chicago',
      capacity: 100,
      participants: 100,
    },
    {
      id: '5',
      title: 'Tech Expo 2023',
      description: 'Annual technology exposition showcasing the latest innovations.',
      date: new Date('2023-11-30T09:00:00'),
      location: 'Miami',
      capacity: 1000,
      participants: 100,
    },
    {
      id: '6',
      title: 'Full Stack Developer Bootcamp',
      description: 'Intensive bootcamp for aspiring full stack developers.',
      date: new Date('2023-12-10T08:00:00'),
      location: 'Seattle',
      participants: 50,
    },
    {
      id: '7',
      title: 'AI & Machine Learning Conference',
      description: 'Exploring the future of AI and machine learning technologies.',
      date: new Date('2024-01-15T09:00:00'),
      location: 'Boston',
      capacity: 400,
      participants: 350,
    },
    {
      id: '8',
      title: 'Cybersecurity Seminar',
      description: 'Seminar on the latest trends in cybersecurity.',
      date: new Date('2023-10-05T11:00:00'),
      location: 'Austin',
      capacity: 200,
      participants: 180,
    },
    {
      id: '9',
      title: 'Cloud Computing Workshop',
      description: 'Workshop on cloud computing platforms and services.',
      date: new Date('2023-09-15T13:00:00'),
      location: 'Denver',
      participants: 70,
    },
    {
      id: '10',
      title: 'DevOps Days',
      description: 'Conference focused on DevOps practices and culture.',
      date: new Date('2023-11-20T09:00:00'),
      location: 'Portland',
      capacity: 250,
      participants: 200,
    },
  ];
  protected readonly EventListingView = EventListingView;
}
