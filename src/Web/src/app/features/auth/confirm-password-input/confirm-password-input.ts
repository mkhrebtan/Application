import { Component, Input } from '@angular/core';
import { FormInput } from '../../../shared/components/form-input/form-input';
import { AbstractControl } from '@angular/forms';

@Component({
  selector: 'app-confirm-password-input',
  imports: [FormInput],
  template: `
    <app-form-input
      [control]="control!"
      [type]="'password'"
      [label]="label"
      [id]="id"
      [autocomplete]="'new-password'"
      [placeholder]="'Confirm your password'"
      [hasExternalError]="hasPasswordMismatchError"
    >
      <ng-content select="[error-message-confirm]" error-message></ng-content>
    </app-form-input>
  `,
  styles: ``,
})
export class ConfirmPasswordInput {
  @Input() control!: AbstractControl;
  @Input() label!: string;
  @Input() id!: string;
  @Input() hasPasswordMismatchError: boolean = false;
}
