import { UUID } from 'node:crypto';

export interface IUserModel {
  id: UUID;
  firstName: string;
  lastName: string;
  email: string;
}
