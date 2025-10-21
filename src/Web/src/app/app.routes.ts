import { Routes } from '@angular/router';
import { Events } from './pages/events/events';
import { NotFound } from './pages/not-found/not-found';
import { Main } from './layout/main/main';
import { MyEvents } from './pages/my-events/my-events';
import { CreateEvent } from './pages/create-event/create-event';
import { EventDetails } from './pages/event-details/event-details';
import { authGuard } from './core/auth/auth-guard/auth-guard';

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
        path: 'my-events',
        component: MyEvents,
        title: 'My Events',
        canActivate: [authGuard],
      },
      {
        path: 'create-event',
        component: CreateEvent,
        title: 'Create Event',
        canActivate: [authGuard],
      },
      {
        path: 'events/:id',
        component: EventDetails,
        title: 'Event Details',
      },
      { path: '', redirectTo: 'events', pathMatch: 'full' },
    ],
  },
  {
    path: 'login',
    loadComponent: () => import('./pages/login/login').then((m) => m.Login),
    title: 'Login',
  },
  {
    path: 'signup',
    loadComponent: () => import('./pages/signup/sign-up').then((m) => m.SignUp),
    title: 'Register',
  },
  {
    path: '**',
    component: NotFound,
    title: 'Not Found',
  },
];
