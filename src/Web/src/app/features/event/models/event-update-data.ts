import { UUID } from 'node:crypto';

export interface IEventUpdateData {
  title: string | null;
  description: string | null;
  date: string | null;
  location: string | null;
  capacity: {
    isSpecified: boolean;
    value: number | null;
  };
  isPublic: boolean | null;
  tagIds: UUID[];
  userTagNames: string[];
}
