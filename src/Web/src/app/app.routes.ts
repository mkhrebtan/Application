import { Routes } from '@angular/router';
import { Events } from './pages/events/events';
import { NotFound } from './pages/not-found/not-found';
import { Main } from './layout/main/main';
import { CreateEvent } from './pages/create-event/create-event';
import { EventDetails } from './pages/event-details/event-details';

export const routes: Routes = [
  {
    path: '',
    component: Main,
    children: [
      {
        path: 'events',
        component: Events,
        title: 'Upcoming Events',
      },
      {
        path: 'create-event',
        component: CreateEvent,
        title: 'Create Event',
      },
      {
        path: 'event-details',
        component: EventDetails,
        title: 'Event Details',
      },
      { path: '', redirectTo: 'events', pathMatch: 'full' },
    ],
  },
  {
    path: '**',
    component: NotFound,
    title: 'Not Found',
  },
];
