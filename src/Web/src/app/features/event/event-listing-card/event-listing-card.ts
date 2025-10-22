import { Component, EventEmitter, inject, Input, OnInit, Output, signal } from '@angular/core';
import { DatePipe } from '@angular/common';
import { faInfinity, faLocationDot, faUsers } from '@fortawesome/free-solid-svg-icons';
import { FaIconComponent } from '@fortawesome/angular-fontawesome';
import { faClock } from '@fortawesome/free-regular-svg-icons';
import { EventListingView } from '../models/event-listing-view';
import { Router } from '@angular/router';
import { IEventListingModel } from '../models/event-listing-model';
import { EventState } from '../models/event-state';
import { IJoinEventData, JoinEventDialog } from '../join-event-dialog/join-event-dialog';
import { AuthService } from '../../../core/auth/auth-service/auth-service';
import { EventService } from '../../../core/event-service/event-service';

@Component({
  selector: 'app-event-listing-card',
  imports: [DatePipe, FaIconComponent, JoinEventDialog],
  templateUrl: './event-listing-card.html',
  styles: ``,
})
export class EventListingCard implements OnInit {
  @Input() event!: IEventListingModel;
  @Input() viewMode: EventListingView = EventListingView.Grid;
  @Output() joinClick = new EventEmitter<IEventListingModel>();
  protected readonly faInfinity = faInfinity;
  protected readonly faClock = faClock;
  protected readonly faLocationDot = faLocationDot;
  protected readonly faUsers = faUsers;
  protected readonly EventListingView = EventListingView;
  protected readonly EventState = EventState;
  protected eventState = signal(EventState.CanJoin);
  protected joinEventDialogIsOpen = signal(false);
  private router = inject(Router);
  private authService = inject(AuthService);
  private eventService = inject(EventService);

  ngOnInit() {
    if (this.event.requesterStatus.isOrganizer) {
      this.eventState.set(EventState.Organizer);
    } else if (this.event.requesterStatus.isParticipating) {
      this.eventState.set(EventState.Joined);
    } else if (this.event.capacity && this.event.participantsCount >= this.event.capacity) {
      this.eventState.set(EventState.Full);
    } else {
      this.eventState.set(EventState.CanJoin);
    }
  }

  navigateToDetails() {
    this.router.navigate(['/events', this.event.id]);
  }

  joinEvent(event: Event) {
    event.stopPropagation();
    if (this.authService.isAuthenticated()) {
      this.eventService.joinEvent(this.event.id).subscribe({
        next: () => {
          this.eventState.set(EventState.Joined);
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
    this.eventService
      .joinEvent(this.event.id, data.firstName, data.lastName, data.email)
      .subscribe({
        next: () => {
          this.eventState.set(EventState.Joined);
          this.closeJoinEventDialog();
        },
        error: (err) => {
          alert(err.error.detail || 'An error occurred while joining the event.');
        },
      });
  }

  leaveEvent(event: Event) {
    event.stopPropagation();
    this.eventService.leaveEvent(this.event.id).subscribe({
      next: () => {
        this.eventState.set(EventState.CanJoin);
      },
      error: (err) => {
        alert(err.error.detail || 'An error occurred while leaving the event.');
      },
    });
  }
}
