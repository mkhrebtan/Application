import { Component, EventEmitter, inject, Output } from '@angular/core';
import { FormBuilder, ReactiveFormsModule, Validators } from '@angular/forms';
import { Backdrop } from '../../../shared/components/backdrop/backdrop';
import { FormInput } from '../../../shared/components/form-input/form-input';
import { FaIconComponent } from '@fortawesome/angular-fontawesome';
import { faXmark } from '@fortawesome/free-solid-svg-icons';

export interface IJoinEventData {
  firstName: string;
  lastName: string;
  email: string;
}

@Component({
  selector: 'app-join-event-dialog',
  imports: [Backdrop, FaIconComponent, FormInput, ReactiveFormsModule],
  template: `
    <app-backdrop (backdropClick)="onClose()" />
    <div
      class="fixed lg:max-w-lg mx-auto w-11/12 md:w-1/2 z-30 top-1/2 left-0 right-0 -translate-y-1/2 p-4 md:p-8 bg-white rounded-lg shadow-lg animate-slide-in
            flex flex-col gap-4 overflow-y-auto max-h-[90vh] lg:max-h-none"
    >
      <div class="flex justify-between">
        <h2 class="text-2xl font-semibold">Join Event</h2>
        <fa-icon [icon]="faXmark" (click)="onClose()" class="cursor-pointer text-xl" />
      </div>

      <form [formGroup]="joinForm" (ngSubmit)="onSubmit()" class="flex flex-col gap-4">
        <app-form-input
          [control]="joinForm.get('firstName')!"
          label="First Name"
          id="firstName"
          placeholder="Enter your first name"
          autocomplete="given-name"
        >
          @if (firstName?.hasError('required')) {
            <span error-message>First name is required</span>
          }
        </app-form-input>

        <app-form-input
          [control]="joinForm.get('lastName')!"
          label="Last Name"
          id="lastName"
          placeholder="Enter your last name"
          autocomplete="family-name"
        >
          @if (lastName?.hasError('required')) {
            <span error-message>Last name is required</span>
          }
        </app-form-input>

        <app-form-input
          [control]="joinForm.get('email')!"
          label="Email"
          id="email"
          type="email"
          placeholder="Enter your email address"
          autocomplete="email"
        >
          @if (email?.hasError('required')) {
            <span error-message>Email is required</span>
          } @else if (email?.hasError('email')) {
            <span error-message>Please enter a valid email address</span>
          }
        </app-form-input>

        <div class="flex justify-center mt-4">
          <button
            type="submit"
            [disabled]="joinForm.invalid"
            class="px-6 py-2 bg-indigo-600 text-white rounded-md hover:bg-indigo-500 disabled:bg-gray-400 disabled:cursor-not-allowed transition-colors cursor-pointer"
          >
            Join Event
          </button>
        </div>
      </form>
    </div>
  `,
  styles: ``,
})
export class JoinEventDialog {
  @Output() closeDialog = new EventEmitter<void>();
  @Output() joinEventSubmit = new EventEmitter<IJoinEventData>();
  protected readonly faXmark = faXmark;
  private readonly formBuilder = inject(FormBuilder);
  protected readonly joinForm = this.formBuilder.group({
    firstName: ['', [Validators.required, Validators.minLength(2)]],
    lastName: ['', [Validators.required, Validators.minLength(2)]],
    email: ['', [Validators.required, Validators.email]],
  });

  get firstName() {
    return this.joinForm.get('firstName');
  }

  get lastName() {
    return this.joinForm.get('lastName');
  }

  get email() {
    return this.joinForm.get('email');
  }

  onClose() {
    this.closeDialog.emit();
  }

  onSubmit() {
    if (this.joinForm.valid) {
      const formData: IJoinEventData = {
        firstName: this.joinForm.value.firstName!,
        lastName: this.joinForm.value.lastName!,
        email: this.joinForm.value.email!,
      };
      this.joinEventSubmit.emit(formData);
    } else {
      this.joinForm.markAllAsTouched();
    }
  }
}
