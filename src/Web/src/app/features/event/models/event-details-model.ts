import { UUID } from 'node:crypto';

export interface IEventDetailsModel {
  id: UUID;
  title: string;
  description: string;
  date: Date;
  location: string;
  capacity?: number;
  participantsCount: number;
  isUserParticipating: boolean;
  isUserOrganizer: boolean;
  isPublic: boolean;
}
