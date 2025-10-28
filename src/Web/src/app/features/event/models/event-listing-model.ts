import { UUID } from 'node:crypto';
import { IEventTag } from './event-tag';

export interface RequesterStatus {
  isParticipating: boolean;
  isOrganizer: boolean;
}

export interface IEventListingModel {
  id: UUID;
  title: string;
  description: string;
  date: string;
  location: string;
  capacity: number | null;
  participantsCount: number;
  requesterStatus: RequesterStatus;
  tags: IEventTag[];
}
