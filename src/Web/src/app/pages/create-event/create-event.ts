import { Component, inject } from '@angular/core';
import { HeroSection } from '../../layout/hero-section/hero-section';
import { FormBuilder, FormControl, ReactiveFormsModule, Validators } from '@angular/forms';
import { CommonModule } from '@angular/common';
import { EventForm } from '../../features/event/event-form/event-form';
import { IEvent } from '../../features/event/models/event';
import { EventService } from '../../core/event-service/event-service';
import { Router } from '@angular/router';
import { IEventTag } from '../../features/event/models/event-tag';
import { catchError } from 'rxjs/operators';
import { Observable } from 'rxjs';

@Component({
  selector: 'app-create-event',
  imports: [HeroSection, ReactiveFormsModule, CommonModule, EventForm],
  templateUrl: './create-event.html',
  styles: ``,
})
export class CreateEvent {
  protected readonly heroTitle = 'Create New Event';
  protected readonly heroDescription = 'Fill in the details below to create a new event.';
  protected tags$: Observable<IEventTag[]>;
  private readonly formBuilder = inject(FormBuilder);
  protected readonly eventCreationForm = this.formBuilder.group({
    title: ['', [Validators.required, Validators.maxLength(100)]],
    description: ['', [Validators.maxLength(500)]],
    date: ['', [Validators.required]],
    location: ['', [Validators.required, Validators.maxLength(200)]],
    capacity: [null, [Validators.min(1)]],
    visibility: ['public', [Validators.required]],
    tags: new FormControl<IEventTag[]>([], [Validators.required, Validators.maxLength(5)]),
  });
  private eventService = inject(EventService);
  private router = inject(Router);

  constructor() {
    this.tags$ = this.loadTags();
  }

  onSubmit() {
    if (this.eventCreationForm.valid) {
      const formData = this.eventCreationForm.value;
      formData.date = new Date(formData.date!).toISOString();

      const tagIds = formData.tags!.filter((tag) => tag.id !== '1-1-1-1-1').map((tag) => tag.id);

      const newEvent: IEvent = {
        title: formData.title!,
        description: formData.description!,
        date: new Date(formData.date!),
        location: formData.location!,
        capacity: formData.capacity || undefined,
        isPublic: formData.visibility === 'public',
        tagIds: tagIds,
      };

      this.eventService.createEvent(newEvent).subscribe({
        next: (id) => {
          this.router.navigate(['/events', id]);
        },
        error: (err) => {
          alert(
            err.error.detail || 'An error occurred while creating the event. Please try again.',
          );
          throw err;
        },
      });
    } else {
      this.eventCreationForm.markAllAsTouched();
    }
  }

  private loadTags() {
    return this.eventService.getTags().pipe(
      catchError((err) => {
        console.error('Error fetching tags:', err);
        throw err;
      }),
    );
  }
}
