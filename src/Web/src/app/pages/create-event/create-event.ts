import { Component, inject } from '@angular/core';
import { HeroSection } from '../../layout/hero-section/hero-section';
import { AbstractControl, FormBuilder, ReactiveFormsModule, Validators } from '@angular/forms';
import { CommonModule } from '@angular/common';
import { FormInput } from '../../shared/components/form-input/form-input';

@Component({
  selector: 'app-create-event',
  imports: [HeroSection, ReactiveFormsModule, CommonModule, FormInput],
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

  get title(): AbstractControl | null {
    return this.eventCreationForm.get('title');
  }
  get description(): AbstractControl | null {
    return this.eventCreationForm.get('description');
  }
  get date(): AbstractControl | null {
    return this.eventCreationForm.get('date');
  }
  get location(): AbstractControl | null {
    return this.eventCreationForm.get('location');
  }
  get capacity(): AbstractControl | null {
    return this.eventCreationForm.get('capacity');
  }

  onSubmit() {
    if (this.eventCreationForm.valid) {
      const formData = this.eventCreationForm.value;
      console.log('Event Created:', formData);
    } else {
      console.log('Form is invalid');
    }
  }
}
