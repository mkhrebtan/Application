import { Component, EventEmitter, Input, Output } from '@angular/core';
import { FormInput } from '../../../shared/components/form-input/form-input';
import { FormGroup, ReactiveFormsModule } from '@angular/forms';
import { NgClass } from '@angular/common';

@Component({
  selector: 'app-event-form',
  imports: [FormInput, ReactiveFormsModule, NgClass],
  templateUrl: './event-form.html',
  styles: ``,
})
export class EventForm {
  @Input() submitButtonText: string = 'Submit';
  @Input() formGroup!: FormGroup;
  @Output() formSubmit = new EventEmitter<void>();

  get title() {
    return this.formGroup.get('title');
  }
  get description() {
    return this.formGroup.get('description');
  }
  get date() {
    return this.formGroup.get('date');
  }
  get location() {
    return this.formGroup.get('location');
  }
  get capacity() {
    return this.formGroup.get('capacity');
  }
  get visibility() {
    return this.formGroup.get('visibility');
  }

  onSubmit() {
    this.formSubmit.emit();
  }
}
