export interface RequesterStatus {
  isParticipating: boolean;
  isOrganizer: boolean;
}

export interface IEventListingModel {
  id: string;
  title: string;
  description: string;
  date: string;
  location: string;
  capacity: number | null;
  participantsCount: number;
  requesterStatus: RequesterStatus;
}
