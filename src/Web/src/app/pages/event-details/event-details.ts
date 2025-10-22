import { Component, inject, signal } from '@angular/core';
import { HeroSection } from '../../layout/hero-section/hero-section';
import { ActivatedRoute, Router } from '@angular/router';
import { EventService } from '../../core/event-service/event-service';
import { AsyncPipe, DatePipe } from '@angular/common';
import { FaIconComponent } from '@fortawesome/angular-fontawesome';
import { faClock } from '@fortawesome/free-regular-svg-icons';
import { faInfinity, faLocationDot, faSpinner, faUsers } from '@fortawesome/free-solid-svg-icons';
import { EventState } from '../../features/event/models/event-state';
import {
  EditEventDialog,
  IEventUpdateData,
} from '../../features/event/edit-event-dialog/edit-event-dialog';
import { UUID } from 'node:crypto';
import { Subject } from 'rxjs';
import { IEventDetails } from '../../features/event/models/event-details';
import { catchError, tap } from 'rxjs/operators';
import {
  IJoinEventData,
  JoinEventDialog,
} from '../../features/event/join-event-dialog/join-event-dialog';
import { AuthService } from '../../core/auth/auth-service/auth-service';
import { IEventParticipant } from '../../features/event/models/event-participant';

@Component({
  selector: 'app-event-details',
  imports: [HeroSection, DatePipe, FaIconComponent, EditEventDialog, JoinEventDialog, AsyncPipe],
  templateUrl: './event-details.html',
  styles: ``,
})
export class EventDetails {
  protected readonly faClock = faClock;
  protected readonly faLocationDot = faLocationDot;
  protected readonly faUsers = faUsers;
  protected readonly faInfinity = faInfinity;
  protected readonly EventState = EventState;
  protected eventState = signal(EventState.CanJoin);
  protected editDialogIsOpen = signal(false);
  protected isEventsLoading = signal(true);
  protected isParticipantsLoading = signal(true);
  protected joinEventDialogIsOpen = signal(false);
  protected readonly faSpinner = faSpinner;
  private eventService = inject(EventService);
  private router = inject(Router);
  private route: ActivatedRoute = inject(ActivatedRoute);
  private authService = inject(AuthService);
  private eventId: UUID;
  private refetchEvent$ = new Subject<IEventDetails>();
  protected event$ = this.refetchEvent$.asObservable();
  private refetchParticipants$ = new Subject<IEventParticipant[]>();
  protected participants$ = this.refetchParticipants$.asObservable();

  constructor() {
    this.eventId = this.route.snapshot.params['id'];

    this.loadEventDetails().subscribe({
      next: (event) => {
        this.refetchEvent$.next(event);
      },
    });
    this.loadEventParticipants().subscribe({
      next: (participants) => {
        this.refetchParticipants$.next(participants);
      },
    });

    this.event$.subscribe((event) => {
      if (event.isUserOrganizer) {
        this.eventState.set(EventState.Organizer);
      } else if (event.isUserParticipating) {
        this.eventState.set(EventState.Joined);
      } else if (event.capacity !== null && event.participantsCount >= event.capacity!) {
        this.eventState.set(EventState.Full);
      } else {
        this.eventState.set(EventState.CanJoin);
      }
    });
  }

  openEditDialog() {
    this.editDialogIsOpen.set(true);
    document.body.style.overflow = 'hidden';
  }

  closeEditDialog() {
    this.editDialogIsOpen.set(false);
    document.body.style.overflow = 'auto';
  }

  editEventSubmit(eventData: IEventUpdateData) {
    this.eventService
      .updateEvent(this.eventId, {
        title: eventData.title,
        description: eventData.description,
        date: eventData.date,
        location: eventData.location,
        capacity: eventData.capacity,
        isPublic: eventData.isPublic,
      })
      .subscribe({
        next: () => {
          this.loadEventDetails().subscribe({
            next: (event) => {
              this.refetchEvent$.next(event);
            },
          });
          this.loadEventParticipants().subscribe({
            next: (participants) => {
              this.refetchParticipants$.next(participants);
            },
          });
          this.closeEditDialog();
        },
        error: (err) => {
          alert(err.error.detail || 'An error occurred while updating the event.');
        },
      });
  }

  joinEvent() {
    if (this.authService.isAuthenticated()) {
      this.eventService.joinEvent(this.eventId).subscribe({
        next: () => {
          this.eventState.set(EventState.Joined);
          this.loadEventDetails().subscribe({
            next: (event) => {
              this.refetchEvent$.next(event);
            },
          });
          this.loadEventParticipants().subscribe({
            next: (participants) => {
              this.refetchParticipants$.next(participants);
            },
          });
        },
        error: (err) => {
          alert(err.error.detail || 'An error occurred while joining the event.');
        },
      });
    } else {
      this.openJoinEventDialog();
    }
  }

  openJoinEventDialog() {
    this.joinEventDialogIsOpen.set(true);
    document.body.style.overflow = 'hidden';
  }

  closeJoinEventDialog() {
    this.joinEventDialogIsOpen.set(false);
    document.body.style.overflow = 'auto';
  }

  onJoinEventSubmit(data: IJoinEventData) {
    this.eventService.joinEvent(this.eventId, data.firstName, data.lastName, data.email).subscribe({
      next: () => {
        this.eventState.set(EventState.Joined);
        this.loadEventDetails().subscribe({
          next: (event) => {
            this.refetchEvent$.next(event);
          },
        });
        this.loadEventParticipants().subscribe({
          next: (participants) => {
            this.refetchParticipants$.next(participants);
          },
        });
        this.closeJoinEventDialog();
      },
      error: (err) => {
        alert(err.error.detail || 'An error occurred while joining the event.');
      },
    });
  }

  leaveEvent() {
    this.eventService.leaveEvent(this.eventId).subscribe({
      next: () => {
        this.eventState.set(EventState.CanJoin);
        this.loadEventDetails().subscribe({
          next: (event) => {
            this.refetchEvent$.next(event);
          },
        });
        this.loadEventParticipants().subscribe({
          next: (participants) => {
            this.refetchParticipants$.next(participants);
          },
        });
      },
      error: (err) => {
        alert(err.error.detail || 'An error occurred while leaving the event.');
      },
    });
  }

  deleteEvent() {
    if (confirm('Are you sure you want to delete this event? This action cannot be undone.')) {
      this.eventService.deleteEvent(this.eventId).subscribe({
        next: () => {
          this.router.navigate(['/events']);
        },
        error: (err) => {
          alert(err.error.detail || 'An error occurred while deleting the event.');
        },
      });
    }
  }

  private loadEventDetails() {
    return this.eventService.getEventById(this.eventId).pipe(
      tap(() => {
        this.isEventsLoading.set(false);
      }),
      catchError((err) => {
        console.error('Error fetching event details:', err);
        this.router.navigate(['/404']);
        throw err;
      }),
    );
  }

  private loadEventParticipants() {
    return this.eventService.getEventParticipants(this.eventId).pipe(
      tap(() => {
        this.isParticipantsLoading.set(false);
      }),
      catchError((err) => {
        console.error('Error fetching event participants:', err);
        this.router.navigate(['/404']);
        throw err;
      }),
    );
  }
}
