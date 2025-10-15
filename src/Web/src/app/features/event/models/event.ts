export interface IEvent {
  id: string;
  title: string;
  description: string;
  date: Date;
  location: string;
  capacity?: number;
  participants: number;
}
