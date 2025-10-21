import { Component, EventEmitter, inject, Input, OnInit, Output } from '@angular/core';
import { Backdrop } from '../../../shared/components/backdrop/backdrop';
import { FormBuilder, FormControl, ReactiveFormsModule, Validators } from '@angular/forms';
import { EventForm } from '../event-form/event-form';
import { faXmark } from '@fortawesome/free-solid-svg-icons';
import { FaIconComponent } from '@fortawesome/angular-fontawesome';
import { IEventDetailsModel } from '../models/event-details-model';
import { IEventUpdateModel } from '../models/event-update-model';

@Component({
  selector: 'app-edit-event-dialog',
  imports: [Backdrop, ReactiveFormsModule, EventForm, FaIconComponent],
  templateUrl: './edit-event-dialog.html',
  styles: ``,
})
export class EditEventDialog implements OnInit {
  @Output() closeDialog = new EventEmitter<void>();
  @Output() submitForm = new EventEmitter<IEventUpdateModel>();
  @Input() event!: IEventDetailsModel;
  protected readonly faXmark = faXmark;
  private readonly formBuilder = inject(FormBuilder);
  protected readonly eventCreationForm = this.formBuilder.group({
    title: ['', [Validators.required, Validators.maxLength(100)]],
    description: ['', [Validators.required, Validators.maxLength(500)]],
    date: ['', [Validators.required]],
    location: ['', [Validators.required, Validators.maxLength(200)]],
    capacity: new FormControl<number | undefined>(undefined, [Validators.min(1)]),
    visibility: ['public', [Validators.required]],
  });

  ngOnInit() {
    if (this.event) {
      const eventDate = new Date(this.event.date);
      const localDate = new Date(eventDate.getTime() - eventDate.getTimezoneOffset() * 60000);
      this.eventCreationForm.patchValue({
        title: this.event.title,
        description: this.event.description,
        date: localDate.toISOString().slice(0, 16),
        location: this.event.location,
        capacity: this.event.capacity,
        visibility: this.event.isPublic ? 'public' : 'private',
      });
    }
  }

  onSubmit() {
    if (this.eventCreationForm.invalid) {
      this.eventCreationForm.markAllAsTouched();
      return;
    }

    const formData = this.eventCreationForm.value;
    formData.date = new Date(formData.date!).toISOString();

    const newEvent: IEventUpdateModel = {
      title: this.event.title === formData.title ? null : formData.title!,
      description: this.event.description === formData.description ? null : formData.description!,
      date:
        new Date(this.event.date).toISOString() === formData.date ? null : new Date(formData.date!),
      location: this.event.location === formData.location ? null : formData.location!,
      capacity: {
        isSpecified: this.event.capacity === formData.capacity,
        value: formData.capacity ?? null,
      },
      isPublic:
        this.event.isPublic === (formData.visibility === 'public')
          ? null
          : formData.visibility === 'public',
      id: this.event.id,
    };

    this.submitForm.emit(newEvent);
  }

  onClose() {
    this.closeDialog.emit();
  }
}
