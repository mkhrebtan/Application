import { Component, inject, signal } from '@angular/core';
import {
  AbstractControl,
  FormBuilder,
  ReactiveFormsModule,
  Validators,
  ValidatorFn,
  ValidationErrors,
} from '@angular/forms';
import { CommonModule } from '@angular/common';
import { Router, RouterModule } from '@angular/router';
import { faSpinner, faCircleXmark, faCircleCheck } from '@fortawesome/free-solid-svg-icons';
import { FaIconComponent } from '@fortawesome/angular-fontawesome';

// Custom validator for password confirmation
export const passwordMatchValidator: ValidatorFn = (
  control: AbstractControl,
): ValidationErrors | null => {
  const password = control.get('password');
  const confirmPassword = control.get('confirmPassword');

  if (password && confirmPassword && password.value !== confirmPassword.value) {
    return { passwordMismatch: true }; // Return an error object
  }
  return null; // No error
};

@Component({
  selector: 'app-register',
  imports: [ReactiveFormsModule, CommonModule, RouterModule, FaIconComponent],
  templateUrl: './sign-up.html',
  styles: ``,
})
export class SignUp {
  protected readonly faSpinner = faSpinner;
  protected readonly faCircleXmark = faCircleXmark;
  protected readonly faCircleCheck = faCircleCheck;

  private readonly formBuilder = inject(FormBuilder);
  private readonly router = inject(Router);

  protected isLoading = signal(false);
  protected errorMessage = signal('');
  protected successMessage = signal('');

  protected readonly signupForm = this.formBuilder.group(
    {
      firstName: ['', [Validators.required]],
      lastName: ['', [Validators.required]],
      email: ['', [Validators.required, Validators.email]],
      password: ['', [Validators.required, Validators.minLength(6)]],
      confirmPassword: ['', [Validators.required]],
    },
    { validators: passwordMatchValidator },
  );
  get firstName(): AbstractControl | null {
    return this.signupForm.get('firstName');
  }
  get lastName(): AbstractControl | null {
    return this.signupForm.get('lastName');
  }
  get email(): AbstractControl | null {
    return this.signupForm.get('email');
  }
  get password(): AbstractControl | null {
    return this.signupForm.get('password');
  }

  get confirmPassword(): AbstractControl | null {
    return this.signupForm.get('confirmPassword');
  }

  onSubmit() {
    if (this.signupForm.valid) {
      this.isLoading.set(true);
      this.errorMessage.set('');
      this.successMessage.set('');

      const formData = this.signupForm.value;
      console.log('Registration attempt:', formData);

      // Simulate API call
      setTimeout(() => {
        this.isLoading.set(false);
        // For demo purposes, simulate successful registration
        // In real app, this would be an actual API call
        if (formData.email && !formData.email.includes('taken')) {
          this.successMessage.set('Account created successfully! Redirecting to login...');
          console.log('Registration successful');

          // Redirect to login after success
          setTimeout(() => {
            this.router.navigate(['/login']);
          }, 2000);
        } else {
          this.errorMessage.set('Email address is already taken. Please try a different email.');
        }
      }, 1500);
    } else {
      console.log('Form is invalid');
      // Mark all fields as touched to show validation errors
      Object.keys(this.signupForm.controls).forEach((key) => {
        this.signupForm.get(key)?.markAsTouched();
      });
    }
  }
}
