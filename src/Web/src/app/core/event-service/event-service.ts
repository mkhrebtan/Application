import { inject, Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { IEventListingModel } from '../../features/event/models/event-listing-model';
import { IEvent } from '../../features/event/models/event';
import { AuthService } from '../auth/auth-service/auth-service';
import { IPagedList } from '../../shared/models/paged-list';
import { map } from 'rxjs';

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

  getEventById(id: number) {
    const event: IEvent = {
      id: id,
      title: 'Sample Event',
      description: 'This is a sample event description.',
      date: new Date(),
      location: 'Sample Location',
      capacity: 100,
      participants: 50,
      visibility: 'public',
    };
    return event;
  }

  getEvents() {
    const sampleEvents: IEvent[] = [
      {
        id: 1,
        title: 'Sample Event 1',
        description: 'This is a sample event description 1.',
        date: new Date(),
        location: 'Sample Location 1',
        capacity: 100,
        participants: 50,
        visibility: 'public',
      },
      {
        id: 2,
        title: 'Sample Event 2',
        description: 'This is a sample event description 2.',
        date: new Date(),
        location: 'Sample Location 2',
        capacity: 200,
        participants: 150,
        visibility: 'private',
      },
    ];
    return sampleEvents;
  }
}
