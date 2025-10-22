export interface IEvent {
  title: string;
  description: string;
  date: Date;
  location: string;
  capacity?: number;
  isPublic: boolean;
}
