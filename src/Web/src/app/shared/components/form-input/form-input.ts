import { Component, Input } from '@angular/core';
import { AbstractControl, FormsModule, ReactiveFormsModule, Validators } from '@angular/forms';
import { NgClass } from '@angular/common';

@Component({
  selector: 'app-form-input',
  imports: [FormsModule, ReactiveFormsModule, NgClass],
  template: `
    <div class="flex flex-col gap-2">
      <label [for]="id" class="text-sm font-medium text-gray-700">
        {{ label }}
        @if (control.hasValidator(Validators.required)) {
          <span class="text-red-500">*</span>
        }
      </label>
      <input
        [id]="id"
        [formControl]="formControl"
        [type]="type"
        [placeholder]="placeholder"
        [autocomplete]="autocomplete"
        class="w-full py-2 px-3 placeholder:text-gray-400 border border-gray-300 rounded-md shadow-sm focus:outline-none focus:ring-1 focus:ring-gray-400 focus:border-gray-400 text-sm transition-colors"
        [ngClass]="{
          'border-red-500 focus:border-red-500 focus:ring-red-500':
            (control.invalid && control.touched) || hasExternalError,
        }"
      />
      @if ((control.invalid && control.touched) || hasExternalError) {
        <div class="text-red-500 text-xs mt-1">
          <ng-content select="[error-message]"></ng-content>
        </div>
      }
    </div>
  `,
  styles: ``,
})
export class FormInput {
  @Input() control!: AbstractControl;
  @Input() label!: string;
  @Input() id!: string;
  @Input() hasExternalError: boolean = false;

  @Input() type: string = 'text';
  @Input() placeholder: string = '';
  @Input() autocomplete: string = 'off';

  get formControl() {
    return this.control as any;
  }

  protected readonly Validators = Validators;
}
