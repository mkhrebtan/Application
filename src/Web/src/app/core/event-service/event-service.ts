import { inject, Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { IEventListingModel } from '../../features/event/models/event-listing-model';
import { AuthService } from '../auth/auth-service/auth-service';
import { IPagedList } from '../../shared/models/paged-list';
import { map } from 'rxjs';
import { UUID } from 'node:crypto';
import { IEventDetails } from '../../features/event/models/event-details';
import { IEventParticipant } from '../../features/event/models/event-participant';
import { IUserEvent } from '../../features/event/models/user-event';

@Injectable({
  providedIn: 'root',
})
export class EventService {
  private eventsUrl = 'https://localhost:5001/events';

  private http = inject(HttpClient);
  private authService = inject(AuthService);

  getEventsList(params: {
    searchTerm: string | null;
    today: boolean | null;
    weekend: boolean | null;
    page: number;
    pageSize: number;
  }) {
    let queryParams = new HttpParams();
    if (params.searchTerm) {
      queryParams = queryParams.append('searchTerm', params.searchTerm);
    }

    if (params.today) {
      queryParams = queryParams.append('today', 'true');
    } else if (params.weekend) {
      queryParams = queryParams.append('weekend', 'true');
    }

    queryParams = queryParams.append('pageNumber', params.page.toString());
    queryParams = queryParams.append('pageSize', params.pageSize.toString());

    return this.http
      .get<{ events: IPagedList<IEventListingModel> }>(this.eventsUrl, { params: queryParams })
      .pipe(map((response) => response.events));
  }

  getEventById(eventId: UUID) {
    return this.http.get<IEventDetails>(`${this.eventsUrl}/${eventId}`);
  }

  getEventParticipants(eventId: UUID) {
    return this.http
      .get<{ participants: IEventParticipant[] }>(`${this.eventsUrl}/${eventId}/participants`)
      .pipe(map((response) => response.participants));
  }

  getUserEvents() {
    return this.http
      .get<{ events: IUserEvent[] }>(`${this.eventsUrl}/me`)
      .pipe(map((response) => response.events));
  }

  createEvent(eventData: {
    title: string;
    description: string;
    date: string;
    location: string;
    capacity?: number;
    isPublic: boolean;
  }) {
    return this.http
      .post<{ eventId: UUID }>(this.eventsUrl, eventData)
      .pipe(map((response) => response.eventId));
  }

  updateEvent(
    eventId: UUID,
    eventData: {
      title: string | null;
      description: string | null;
      date: string | null;
      location: string | null;
      capacity: {
        isSpecified: boolean;
        value: number | null;
      };
      isPublic: boolean | null;
    },
  ) {
    return this.http.put(`${this.eventsUrl}/${eventId}`, eventData);
  }

  joinEvent(eventId: UUID, firstName?: string, lastName?: string, email?: string) {
    return this.http.post(`${this.eventsUrl}/${eventId}/join`, {
      visitorFirstName: firstName,
      visitorLastName: lastName,
      visitorEmail: email,
    });
  }

  leaveEvent(eventId: UUID) {
    return this.http.post(`${this.eventsUrl}/${eventId}/leave`, {});
  }

  deleteEvent(eventId: UUID) {
    return this.http.delete(`${this.eventsUrl}/${eventId}`);
  }
}
