import { Component, inject, PLATFORM_ID, signal } from '@angular/core';
import { HeroSection } from '../../layout/hero-section/hero-section';
import { ActivatedRoute, Router } from '@angular/router';
import { EventService } from '../../core/event-service/event-service';
import { AsyncPipe, DatePipe, isPlatformBrowser } from '@angular/common';
import { FaIconComponent } from '@fortawesome/angular-fontawesome';
import { faClock } from '@fortawesome/free-regular-svg-icons';
import { faInfinity, faLocationDot, faSpinner, faUsers } from '@fortawesome/free-solid-svg-icons';
import { EventState } from '../../features/event/models/event-state';
import { EditEventDialog } from '../../features/event/edit-event-dialog/edit-event-dialog';
import { UUID } from 'node:crypto';
import { Observable, throwError } from 'rxjs';
import { IEventDetailsModel } from '../../features/event/models/event-details-model';
import { catchError, map } from 'rxjs/operators';
import { IEventParticipant } from '../../features/event/models/event-participant';
import { IEventUpdateModel } from '../../features/event/models/event-update-model';
import { JoinEventDialog } from '../../features/event/join-event-dialog/join-event-dialog';
import { AuthService } from '../../core/auth/auth-service/auth-service';

@Component({
  selector: 'app-event-details',
  imports: [HeroSection, DatePipe, FaIconComponent, EditEventDialog, AsyncPipe, JoinEventDialog],
  templateUrl: './event-details.html',
  styles: ``,
})
export class EventDetails {
  protected readonly faClock = faClock;
  protected readonly faLocationDot = faLocationDot;
  protected readonly faUsers = faUsers;
  protected readonly faInfinity = faInfinity;
  protected readonly faSpinner = faSpinner;
  protected readonly EventState = EventState;
  protected eventState = signal<EventState | null>(null);
  protected editDialogIsOpen = signal(false);
  protected event$!: Observable<IEventDetailsModel | null>;
  protected participants$!: Observable<IEventParticipant[] | null>;
  protected joinEventDialogIsOpen = signal(false);
  private eventService = inject(EventService);
  private readonly authService = inject(AuthService);
  private router = inject(Router);
  private platformId = inject(PLATFORM_ID);
  private route: ActivatedRoute = inject(ActivatedRoute);
  private eventId: UUID;

  constructor() {
    this.eventId = this.route.snapshot.params['id'];
    this.event$ = this.loadEventDetails(this.eventId);

    this.event$.subscribe((event) => {
      if (event) {
        this.eventState.set(this.determineEventState(event));
      }
    });

    this.participants$ = this.loadParticipants(this.eventId);
  }

  openEditDialog() {
    this.editDialogIsOpen.set(true);
    if (isPlatformBrowser(this.platformId)) {
      document.body.style.overflow = 'hidden';
    }
  }

  closeEditDialog() {
    this.editDialogIsOpen.set(false);
    if (isPlatformBrowser(this.platformId)) {
      document.body.style.overflow = 'auto';
    }
  }

  onEditEventSubmit(updatedEvent: IEventUpdateModel) {
    this.eventService.updateEvent(updatedEvent).subscribe({
      next: (response) => {
        this.event$ = this.loadEventDetails(this.eventId);
        this.closeEditDialog();
      },
      error: (err) => {
        alert(err.error.detail || 'Failed to create event. Please try again later.');
      },
    });
  }

  protected joinEvent() {
    if (this.authService.isAuthenticated()) {
      this.eventService.joinEvent(this.eventId).subscribe({
        next: () => {
          this.eventState.set(EventState.Joined);
          this.event$ = this.loadEventDetails(this.eventId);
          this.participants$ = this.loadParticipants(this.eventId);
        },
        error: (err) => {
          alert(err.error.detail || 'Failed to join event. Please try again later.');
        },
      });
    } else {
      this.joinEventDialogIsOpen.set(true);
      document.body.style.overflow = 'hidden';
    }
  }

  protected closeJoinEventDialog() {
    this.joinEventDialogIsOpen.set(false);
    document.body.style.overflow = 'auto';
  }

  protected onJoinEventFormSubmit({
    firstName,
    lastName,
    email,
  }: {
    firstName: string;
    lastName: string;
    email: string;
  }) {
    this.eventService.joinEvent(this.eventId, firstName, lastName, email).subscribe({
      next: () => {
        this.eventState.set(EventState.Joined);
        this.event$ = this.loadEventDetails(this.eventId);
        this.participants$ = this.loadParticipants(this.eventId);
        this.closeJoinEventDialog();
      },
      error: (err) => {
        alert(err.error.detail || 'Failed to join event. Please try again later.');
      },
    });
  }

  protected leaveEvent() {
    this.eventService.leaveEvent(this.eventId).subscribe({
      next: () => {
        this.eventState.set(EventState.CanJoin);
        this.event$ = this.loadEventDetails(this.eventId);
        this.participants$ = this.loadParticipants(this.eventId);
      },
      error: (err) => {
        alert(err.error.detail || 'Failed to leave event. Please try again later.');
      },
    });
  }

  protected deleteEvent() {
    if (confirm('Are you sure you want to delete this event? This action cannot be undone.')) {
      this.eventService.deleteEvent(this.eventId).subscribe({
        next: () => {
          this.router.navigate(['/events']);
        },
        error: (err) => {
          alert(err.error.detail || 'Failed to delete event. Please try again later.');
        },
      });
    }
  }

  private loadEventDetails(id: IEventDetailsModel['id']): Observable<IEventDetailsModel> {
    return this.eventService.getEventById(id).pipe(
      catchError((err) => {
        this.router.navigate(['/404']);
        throw err;
      }),
    );
  }

  private loadParticipants(id: IEventDetailsModel['id']): Observable<IEventParticipant[]> {
    return this.eventService.getEventParticipants(id).pipe(
      map((participants) =>
        participants.sort(
          (a, b) => new Date(a.joinedAt).getTime() - new Date(b.joinedAt).getTime(),
        ),
      ),
      catchError((err) => {
        this.router.navigate(['/404']);
        return throwError(() => err);
      }),
    );
  }

  private determineEventState(event: IEventDetailsModel): EventState {
    if (event.isUserOrganizer) {
      return EventState.Organizer;
    } else if (event.isUserParticipating) {
      return EventState.Joined;
    } else if (event.capacity && event.participantsCount >= event.capacity) {
      return EventState.Full;
    }

    return EventState.CanJoin;
  }
}
