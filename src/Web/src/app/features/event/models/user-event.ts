import { UUID } from 'node:crypto';

export interface IUserEvent {
  id: UUID;
  title: string;
  date: Date;
  location: string;
  isUserOrganizer: boolean;
}
