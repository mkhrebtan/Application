import { Component, inject, signal } from '@angular/core';
import { AbstractControl, FormBuilder, ReactiveFormsModule, Validators } from '@angular/forms';
import { CommonModule } from '@angular/common';
import { Router, RouterModule } from '@angular/router';
import { faCircleCheck, faCircleXmark, faSpinner } from '@fortawesome/free-solid-svg-icons';
import { FaIconComponent } from '@fortawesome/angular-fontawesome';
import { FormInput } from '../../shared/components/form-input/form-input';
import { ConfirmPasswordInput } from '../../features/auth/confirm-password-input/confirm-password-input';
import { passwordMatchValidator } from '../../features/auth/password-match-validator';
import { AuthService } from '../../core/auth/auth-service/auth-service';

@Component({
  selector: 'app-register',
  imports: [
    ReactiveFormsModule,
    CommonModule,
    RouterModule,
    FaIconComponent,
    FormInput,
    ConfirmPasswordInput,
  ],
  templateUrl: './sign-up.html',
  styles: ``,
})
export class SignUp {
  protected readonly faSpinner = faSpinner;
  protected readonly faCircleXmark = faCircleXmark;
  protected readonly faCircleCheck = faCircleCheck;

  protected isLoading = signal(false);
  protected errorMessage = signal('');
  protected successMessage = signal('');

  private readonly formBuilder = inject(FormBuilder);
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

  private readonly router = inject(Router);
  private authService = inject(AuthService);

  constructor() {
    this.signupForm.get('password')?.valueChanges.subscribe(() => {
      const confirmPasswordControl = this.signupForm.get('confirmPassword');
      if (confirmPasswordControl?.value) {
        this.signupForm.updateValueAndValidity();
      }
    });

    this.signupForm.get('confirmPassword')?.valueChanges.subscribe(() => {
      this.signupForm.updateValueAndValidity();
    });
  }

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

      const credentials = this.signupForm.value;
      this.authService
        .signup(
          credentials.firstName!,
          credentials.lastName!,
          credentials.email!,
          credentials.password!,
        )
        .subscribe({
          next: () => {
            this.successMessage.set('Account created successfully! Logging in...');
            setTimeout(() => {
              this.router.navigate(['/events']);
            }, 2000);
          },
          error: (err) => {
            this.errorMessage.set(err.error.detail || 'Signup failed. Please try again.');
            this.isLoading.set(false);
          },
        });
    } else {
      this.signupForm.markAllAsTouched();
    }
  }
}
