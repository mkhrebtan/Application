import { UUID } from 'node:crypto';

export interface IEventDetails {
  id: UUID;
  title: string;
  description: string;
  date: string;
  location: string;
  capacity?: number;
  participantsCount: number;
  isUserParticipating: boolean;
  isUserOrganizer: boolean;
  isPublic: boolean;
}
