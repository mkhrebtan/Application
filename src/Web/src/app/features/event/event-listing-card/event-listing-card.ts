import { Component, inject, Input, OnInit, signal } from '@angular/core';
import { DatePipe } from '@angular/common';
import { faInfinity, faLocationDot, faUsers } from '@fortawesome/free-solid-svg-icons';
import { FaIconComponent } from '@fortawesome/angular-fontawesome';
import { faClock } from '@fortawesome/free-regular-svg-icons';
import { EventListingView } from '../models/event-listing-view';
import { Router } from '@angular/router';
import { IEventListingModel } from '../models/event-listing-model';
import { EventState } from '../models/event-state';
import { JoinEventDialog } from '../join-event-dialog/join-event-dialog';
import { EventService } from '../../../core/event-service/event-service';
import { AuthService } from '../../../core/auth/auth-service/auth-service';

@Component({
  selector: 'app-event-listing-card',
  imports: [DatePipe, FaIconComponent, JoinEventDialog],
  templateUrl: './event-listing-card.html',
  styles: ``,
})
export class EventListingCard implements OnInit {
  @Input() event!: IEventListingModel;
  @Input() viewMode: EventListingView = EventListingView.Grid;
  protected readonly faInfinity = faInfinity;
  protected readonly faClock = faClock;
  protected readonly faLocationDot = faLocationDot;
  protected readonly faUsers = faUsers;
  protected readonly EventListingView = EventListingView;
  protected readonly EventState = EventState;
  protected eventState = signal(EventState.CanJoin);
  protected joinEventDialogIsOpen = signal(false);
  private router = inject(Router);
  private readonly eventService = inject(EventService);
  private readonly authService = inject(AuthService);

  ngOnInit() {
    if (this.event.requesterStatus.isOrganizer) {
      this.eventState.set(EventState.Organizer);
    } else if (this.event.requesterStatus.isParticipating) {
      this.eventState.set(EventState.Joined);
    } else if (this.event.capacity && this.event.participantsCount >= this.event.capacity) {
      this.eventState.set(EventState.Full);
    }
  }

  protected navigateToDetails() {
    this.router.navigate(['/events', this.event.id]);
  }

  protected joinEvent(event: Event) {
    event.stopPropagation();
    if (this.authService.isAuthenticated()) {
      this.eventService.joinEvent(this.event.id).subscribe({
        next: () => {
          this.eventState.set(EventState.Joined);
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
    this.eventService.joinEvent(this.event.id, firstName, lastName, email).subscribe({
      next: () => {
        this.eventState.set(EventState.Joined);
        this.closeJoinEventDialog();
      },
      error: (err) => {
        alert(err.error.detail || 'Failed to join event. Please try again later.');
      },
    });
  }

  protected leaveEvent(event: Event) {
    event.stopPropagation();
    this.eventService.leaveEvent(this.event.id).subscribe({
      next: () => {
        this.eventState.set(EventState.CanJoin);
      },
      error: (err) => {
        alert(err.error.detail || 'Failed to leave event. Please try again later.');
      },
    });
  }
}
