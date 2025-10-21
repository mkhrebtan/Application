import { Component, inject, signal } from '@angular/core';
import { AbstractControl, FormBuilder, ReactiveFormsModule, Validators } from '@angular/forms';
import { CommonModule } from '@angular/common';
import { Router, RouterModule } from '@angular/router';
import { faCircleXmark, faSpinner } from '@fortawesome/free-solid-svg-icons';
import { FaIconComponent } from '@fortawesome/angular-fontawesome';
import { FormInput } from '../../shared/components/form-input/form-input';
import { AuthService } from '../../core/auth/auth-service/auth-service';

@Component({
  selector: 'app-login',
  imports: [ReactiveFormsModule, CommonModule, RouterModule, FaIconComponent, FormInput],
  templateUrl: './login.html',
  styles: ``,
})
export class Login {
  protected readonly faSpinner = faSpinner;
  protected readonly faCircleXmark = faCircleXmark;
  protected isLoading = signal(false);
  protected errorMessage = signal('');
  private readonly formBuilder = inject(FormBuilder);
  protected readonly loginForm = this.formBuilder.group({
    email: ['', [Validators.required, Validators.email]],
    password: ['', [Validators.required, Validators.minLength(6)]],
    rememberMe: [false],
  });
  private readonly router = inject(Router);
  private authService = inject(AuthService);

  get email(): AbstractControl | null {
    return this.loginForm.get('email');
  }
  get password(): AbstractControl | null {
    return this.loginForm.get('password');
  }

  onSubmit() {
    if (this.loginForm.valid) {
      this.isLoading.set(true);
      this.errorMessage.set('');

      const credentials = this.loginForm.value;
      this.authService.login(credentials.email!, credentials.password!).subscribe({
        next: () => {
          this.router.navigate(['/events']);
        },
        error: (err) => {
          this.errorMessage.set(
            err.error.detail || 'Login failed. Please check your credentials and try again.',
          );
          this.isLoading.set(false);
        },
      });
    } else {
      this.loginForm.markAllAsTouched();
    }
  }
}
