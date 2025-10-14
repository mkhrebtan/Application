import { Routes } from '@angular/router';
import { Events } from './pages/events/events';

export const routes: Routes = [
  {
    path: '',
    redirectTo: 'events',
    pathMatch: 'full',
  },
  {
    path: 'events',
    component: Events,
  },
];
