import { Routes } from '@angular/router';
import { Events } from './pages/events/events';
import { NotFound } from './pages/not-found/not-found';
import { Main } from './layout/main/main';
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
        loadComponent: () => import('./pages/my-events/my-events').then((m) => m.MyEvents),
        title: 'My Events',
        canActivate: [authGuard],
      },
      {
        path: 'create-event',
        loadComponent: () => import('./pages/create-event/create-event').then((m) => m.CreateEvent),
        title: 'Create Event',
        canActivate: [authGuard],
      },
      {
        path: 'events/:id',
        loadComponent: () =>
          import('./pages/event-details/event-details').then((m) => m.EventDetails),
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
