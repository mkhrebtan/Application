import { inject, Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { IEventListingModel } from '../../features/event/models/event-listing-model';
import { AuthService } from '../auth/auth-service/auth-service';
import { IPagedList } from '../../shared/models/paged-list';
import { map } from 'rxjs';
import { IUserEvent } from '../../features/event/models/user-event';
import { IEventDetailsModel } from '../../features/event/models/event-details-model';
import { IEventParticipant } from '../../features/event/models/event-participant';
import { IEvent } from '../../features/event/models/event';
import { UUID } from 'node:crypto';
import { IEventUpdateModel } from '../../features/event/models/event-update-model';

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

  getEventById(id: IEventDetailsModel['id']) {
    return this.http
      .get<{ event: IEventDetailsModel }>(`${this.eventsUrl}/${id}`)
      .pipe(map((response) => response.event));
  }

  getUserEvents() {
    return this.http
      .get<{ events: IUserEvent[] }>(`${this.eventsUrl}/me`)
      .pipe(map((response) => response.events));
  }

  getEventParticipants(eventId: IEventDetailsModel['id']) {
    return this.http
      .get<{ participants: IEventParticipant[] }>(`${this.eventsUrl}/${eventId}/participants`)
      .pipe(map((response) => response.participants));
  }

  createEvent(event: IEvent) {
    return this.http.post<{ eventId: UUID }>(this.eventsUrl, event);
  }

  updateEvent(event: IEventUpdateModel) {
    return this.http.patch(`${this.eventsUrl}/${event.id}`, event);
  }

  joinEvent(
    eventId: UUID,
    firstName: string | null = null,
    lastName: string | null = null,
    email: string | null = null,
  ) {
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
