export interface IEventListingModel {
  id: number;
  title: string;
  description: string;
  date: Date;
  location: string;
  capacity?: number;
  participants: number;
  requesterStatus: {
    isParticipating: boolean;
    isOrganizer: boolean;
  };
}
