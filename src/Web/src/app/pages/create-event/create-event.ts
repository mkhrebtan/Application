import { Component, inject, signal } from '@angular/core';
import { HeroSection } from '../../layout/hero-section/hero-section';
import { FormBuilder, ReactiveFormsModule, Validators } from '@angular/forms';
import { CommonModule } from '@angular/common';
import { EventForm } from '../../features/event/event-form/event-form';
import { IEvent } from '../../features/event/models/event';
import { EventService } from '../../core/event-service/event-service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-create-event',
  imports: [HeroSection, ReactiveFormsModule, CommonModule, EventForm],
  templateUrl: './create-event.html',
  styles: ``,
})
export class CreateEvent {
  protected readonly heroTitle = 'Create New Event';
  protected readonly heroDescription = 'Fill in the details below to create a new event.';
  protected isLoading = signal(false);
  protected errorMessage = signal('');
  private readonly formBuilder = inject(FormBuilder);
  protected readonly eventCreationForm = this.formBuilder.group({
    title: ['', [Validators.required, Validators.maxLength(100)]],
    description: ['', [Validators.required, Validators.maxLength(500)]],
    date: ['', [Validators.required]],
    location: ['', [Validators.required, Validators.maxLength(200)]],
    capacity: [null, [Validators.min(1)]],
    visibility: ['public', [Validators.required]],
  });
  private eventService = inject(EventService);
  private router = inject(Router);

  onSubmit() {
    if (this.eventCreationForm.invalid) {
      this.eventCreationForm.markAllAsTouched();
      return;
    }

    this.isLoading.set(true);
    this.errorMessage.set('');

    const formData = this.eventCreationForm.value;
    formData.date = new Date(formData.date!).toISOString();

    const newEvent: IEvent = {
      title: formData.title!,
      description: formData.description!,
      date: new Date(formData.date!),
      location: formData.location!,
      capacity: formData.capacity ?? undefined,
      isPublic: formData.visibility === 'public',
    };

    this.eventService.createEvent(newEvent).subscribe({
      next: (response) => {
        this.isLoading.set(false);
        this.router.navigate(['/events', response.eventId]);
      },
      error: (err) => {
        this.isLoading.set(false);
        this.errorMessage.set(
          err.error.detail || 'Failed to create event. Please try again later.',
        );
      },
    });
  }
}
