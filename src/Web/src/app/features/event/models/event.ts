export interface IEvent {
  id: number;
  title: string;
  description: string;
  date: Date;
  location: string;
  capacity?: number;
  participants: number;
}
