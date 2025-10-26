import { UUID } from 'node:crypto';

export interface IEvent {
  title: string;
  description: string;
  date: Date;
  location: string;
  capacity?: number;
  isPublic: boolean;
  tagIds: UUID[];
  userTagNames: string[];
}
