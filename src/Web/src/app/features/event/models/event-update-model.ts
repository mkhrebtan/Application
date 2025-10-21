import { UUID } from 'node:crypto';

export interface IEventUpdateModel {
  id: UUID;
  title: string | null;
  description: string | null;
  date: Date | null;
  location: string | null;
  capacity: {
    isSpecified: boolean;
    value: number | null;
  };
  isPublic: boolean | null;
}
