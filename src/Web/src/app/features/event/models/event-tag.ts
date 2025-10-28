import { UUID } from 'node:crypto';

export interface IEventTag {
  id: UUID;
  name: string;
}
