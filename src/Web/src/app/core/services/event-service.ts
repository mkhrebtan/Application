import { Injectable } from '@angular/core';
import { IEvent } from '../../features/event/models/event';

@Injectable({
  providedIn: 'root',
})
export class EventService {
  getEvents(): IEvent[] {
    return this.events;
  }

  getEventById(id: number): IEvent | undefined {
    return this.events.find((event) => event.id == id);
  }

  private readonly events: IEvent[] = [
    {
      id: 1,
      title: 'Angular Conference',
      description: 'A conference about Angular and its ecosystem.',
      date: new Date('2025-10-05T09:00:00'),
      location: 'New York',
      capacity: 300,
      participants: 150,
      visibility: 'public',
    },
    {
      id: 2,
      title: 'React Summit',
      description: 'The biggest React conference in the world.',
      date: new Date('2025-10-05T10:00:00'),
      location: 'San Francisco',
      participants: 400,
      visibility: 'public',
    },
    {
      id: 3,
      title: 'Vue.js Meetup',
      description: 'Monthly meetup for Vue.js.',
      date: new Date('2025-10-20T18:00:00'),
      location: 'Los Angeles',
      participants: 80,
      visibility: 'public',
    },
    {
      id: 4,
      title: 'JavaScript Workshop',
      description: 'Hands-on workshop covering modern JavaScript features.',
      date: new Date('2025-09-25T14:00:00'),
      location: 'Chicago',
      capacity: 100,
      participants: 100,
      visibility: 'public',
    },
    {
      id: 5,
      title: 'Tech Expo 2023',
      description: 'Annual technology exposition showcasing the latest innovations.',
      date: new Date('2025-11-30T09:00:00'),
      location: 'Miami',
      capacity: 1000,
      participants: 100,
      visibility: 'public',
    },
    {
      id: 6,
      title: 'Full Stack Developer Bootcamp',
      description: 'Intensive bootcamp for aspiring full stack developers.',
      date: new Date('2025-12-10T08:00:00'),
      location: 'Seattle',
      participants: 50,
      visibility: 'public',
    },
    {
      id: 7,
      title: 'AI & Machine Learning Conference',
      description: 'Exploring the future of AI and machine learning technologies.',
      date: new Date('2025-01-15T09:00:00'),
      location: 'Boston',
      capacity: 400,
      participants: 350,
      visibility: 'public',
    },
    {
      id: 8,
      title: 'Cybersecurity Seminar',
      description: 'Seminar on the latest trends in cybersecurity.',
      date: new Date('2025-10-05T11:00:00'),
      location: 'Austin',
      capacity: 200,
      participants: 180,
      visibility: 'public',
    },
    {
      id: 9,
      title: 'Cloud Computing Workshop',
      description: 'Workshop on cloud computing platforms and services.',
      date: new Date('2025-09-15T13:00:00'),
      location: 'Denver',
      participants: 70,
      visibility: 'public',
    },
    {
      id: 10,
      title: 'DevOps Days',
      description: 'Conference focused on DevOps practices and culture.',
      date: new Date('2025-11-20T09:00:00'),
      location: 'Portland',
      capacity: 250,
      participants: 200,
      visibility: 'public',
    },
  ];
}
