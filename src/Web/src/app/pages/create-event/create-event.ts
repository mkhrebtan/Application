import { Component, inject } from '@angular/core';
import { HeroSection } from '../../layout/hero-section/hero-section';
import { FormBuilder, ReactiveFormsModule, Validators } from '@angular/forms';
import { CommonModule } from '@angular/common';
import { EventForm } from '../../features/event/event-form/event-form';

@Component({
  selector: 'app-create-event',
  imports: [HeroSection, ReactiveFormsModule, CommonModule, EventForm],
  templateUrl: './create-event.html',
  styles: ``,
})
export class CreateEvent {
  protected readonly heroTitle = 'Create New Event';
  protected readonly heroDescription = 'Fill in the details below to create a new event.';

  private readonly formBuilder = inject(FormBuilder);
  protected readonly eventCreationForm = this.formBuilder.group({
    title: ['', [Validators.required, Validators.maxLength(100)]],
    description: ['', [Validators.required, Validators.maxLength(500)]],
    date: ['', [Validators.required]],
    location: ['', [Validators.required, Validators.maxLength(200)]],
    capacity: [null, [Validators.min(1)]],
    visibility: ['public', [Validators.required]],
  });

  onSubmit() {
    if (this.eventCreationForm.valid) {
      const formData = this.eventCreationForm.value;
      formData.date = new Date(formData.date!).toISOString();
      console.log('Event Created:', formData);
    } else {
      console.log('Form is invalid');
    }
  }
}
