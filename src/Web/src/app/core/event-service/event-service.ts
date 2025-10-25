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
import { IEvent } from '../../features/event/models/event';
import { IEventUpdateData } from '../../features/event/edit-event-dialog/edit-event-dialog';
import { IEventTag } from '../../features/event/models/event-tag';

@Injectable({
  providedIn: 'root',
})
export class EventService {
  private apiUrl: string = 'https://localhost:5001';
  private eventsUrl = `${this.apiUrl}/events`;

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
    return this.http
      .get<{ event: IEventDetails }>(`${this.eventsUrl}/${eventId}`)
      .pipe(map((response) => response.event));
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

  getTags() {
    return this.http
      .get<{ tags: IEventTag[] }>(`${this.apiUrl}/tags`)
      .pipe(map((response) => response.tags));
  }

  createEvent(eventData: IEvent) {
    return this.http
      .post<{ eventId: UUID }>(this.eventsUrl, eventData)
      .pipe(map((response) => response.eventId));
  }

  updateEvent(eventId: UUID, eventData: IEventUpdateData) {
    const requestBody: any = {
      title: eventData.title,
      description: eventData.description,
      date: eventData.date,
      location: eventData.location,
      isPublic: eventData.isPublic,
      capacity: {
        isSpecified: eventData.capacity.isSpecified,
        value: eventData.capacity.value,
      },
      tagIds: eventData.tagIds,
    };

    return this.http.patch(`${this.eventsUrl}/${eventId}`, requestBody);
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
