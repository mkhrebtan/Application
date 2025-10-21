import { Component, EventEmitter, inject, Input, OnInit, Output } from '@angular/core';
import { Backdrop } from '../../../shared/components/backdrop/backdrop';
import { FormBuilder, FormControl, ReactiveFormsModule, Validators } from '@angular/forms';
import { IEvent } from '../models/event';
import { EventForm } from '../event-form/event-form';
import { faXmark } from '@fortawesome/free-solid-svg-icons';
import { FaIconComponent } from '@fortawesome/angular-fontawesome';

@Component({
  selector: 'app-edit-event-dialog',
  imports: [Backdrop, ReactiveFormsModule, EventForm, FaIconComponent],
  templateUrl: './edit-event-dialog.html',
  styles: ``,
})
export class EditEventDialog implements OnInit {
  @Output() closeDialog = new EventEmitter<void>();
  @Input() event!: IEvent;

  private readonly formBuilder = inject(FormBuilder);
  protected readonly eventCreationForm = this.formBuilder.group({
    title: ['', [Validators.required, Validators.maxLength(100)]],
    description: ['', [Validators.required, Validators.maxLength(500)]],
    date: ['', [Validators.required]],
    location: ['', [Validators.required, Validators.maxLength(200)]],
    capacity: new FormControl<number | undefined>(undefined, [Validators.min(1)]),
    visibility: ['public', [Validators.required]],
  });

  protected readonly faXmark = faXmark;

  ngOnInit() {
    if (this.event) {
      const localDate = new Date(
        this.event.date.getTime() - this.event.date.getTimezoneOffset() * 60000,
      );
      this.eventCreationForm.patchValue({
        title: this.event.title,
        description: this.event.description,
        date: localDate.toISOString().slice(0, 16),
        location: this.event.location,
        capacity: this.event.capacity,
        visibility: this.event.visibility,
      });
    }
  }

  onSubmit() {
    if (this.eventCreationForm.valid) {
      const formData = this.eventCreationForm.value;
      console.log('Event Created:', formData);
    } else {
      console.log('Form is invalid');
    }
  }

  onClose() {
    this.closeDialog.emit();
  }
}
