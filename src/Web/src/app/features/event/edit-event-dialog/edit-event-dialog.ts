import { Component, EventEmitter, inject, Input, OnInit, Output } from '@angular/core';
import { Backdrop } from '../../../shared/components/backdrop/backdrop';
import { FormBuilder, FormControl, ReactiveFormsModule, Validators } from '@angular/forms';
import { EventForm } from '../event-form/event-form';
import { faXmark } from '@fortawesome/free-solid-svg-icons';
import { FaIconComponent } from '@fortawesome/angular-fontawesome';
import { IEventDetails } from '../models/event-details';
import { IEventTag } from '../models/event-tag';
import { UUID } from 'node:crypto';

export interface IEventUpdateData {
  title: string | null;
  description: string | null;
  date: string | null;
  location: string | null;
  capacity: {
    isSpecified: boolean;
    value: number | null;
  };
  isPublic: boolean | null;
  tagIds: UUID[];
}

@Component({
  selector: 'app-edit-event-dialog',
  imports: [Backdrop, ReactiveFormsModule, EventForm, FaIconComponent],
  templateUrl: './edit-event-dialog.html',
  styles: ``,
})
export class EditEventDialog implements OnInit {
  @Output() closeDialog = new EventEmitter<void>();
  @Output() submitEvent = new EventEmitter<IEventUpdateData>();
  @Input() event!: IEventDetails;
  @Input() tagsOptions: IEventTag[] = [];
  protected readonly faXmark = faXmark;
  private readonly formBuilder = inject(FormBuilder);
  protected readonly eventCreationForm = this.formBuilder.group({
    title: ['', [Validators.required, Validators.maxLength(100)]],
    description: ['', [Validators.required, Validators.maxLength(500)]],
    date: ['', [Validators.required]],
    location: ['', [Validators.required, Validators.maxLength(200)]],
    capacity: new FormControl<number | undefined>(undefined, [Validators.min(1)]),
    visibility: ['public', [Validators.required]],
    tags: new FormControl<IEventTag[]>([], [Validators.required, Validators.maxLength(5)]),
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
        tags: this.event.tags,
      });
    }
  }

  onSubmit() {
    if (this.eventCreationForm.valid) {
      const formData = this.eventCreationForm.value;
      formData.date = new Date(formData.date!).toISOString();

      const updateData: IEventUpdateData = {
        title: formData.title! === this.event.title ? null : formData.title!,
        description:
          formData.description! === this.event.description ? null : formData.description!,
        date: formData.date! === this.event.date ? null : formData.date!,
        location: formData.location! === this.event.location ? null : formData.location!,
        capacity: {
          isSpecified: formData.capacity !== this.event.capacity,
          value: formData.capacity !== this.event.capacity ? formData.capacity! : null,
        },
        isPublic:
          (formData.visibility! === 'public') === this.event.isPublic
            ? null
            : formData.visibility! === 'public',
        tagIds: formData.tags!.filter((tag) => tag.id !== '1-1-1-1-1').map((tag) => tag.id),
      };

      this.submitEvent.emit(updateData);
      this.onClose();
    } else {
      this.eventCreationForm.markAsTouched();
    }
  }

  onClose() {
    this.closeDialog.emit();
  }
}
