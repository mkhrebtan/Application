import { Component, inject, signal } from '@angular/core';
import { AbstractControl, FormBuilder, ReactiveFormsModule, Validators } from '@angular/forms';
import { CommonModule } from '@angular/common';
import { Router, RouterModule } from '@angular/router';
import { faSpinner, faCircleXmark } from '@fortawesome/free-solid-svg-icons';
import { FaIconComponent } from '@fortawesome/angular-fontawesome';
import { FormInput } from '../../shared/components/form-input/form-input';

@Component({
  selector: 'app-login',
  imports: [ReactiveFormsModule, CommonModule, RouterModule, FaIconComponent, FormInput],
  templateUrl: './login.html',
  styles: ``,
})
export class Login {
  protected readonly faSpinner = faSpinner;
  protected readonly faCircleXmark = faCircleXmark;

  private readonly formBuilder = inject(FormBuilder);
  private readonly router = inject(Router);

  protected isLoading = signal(false);
  protected errorMessage = signal('');

  protected readonly loginForm = this.formBuilder.group({
    email: ['', [Validators.required, Validators.email]],
    password: ['', [Validators.required, Validators.minLength(6)]],
    rememberMe: [false],
  });

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

      const formData = this.loginForm.value;
      console.log('Login attempt:', formData);

      // Simulate API call
      setTimeout(() => {
        this.isLoading.set(false);
        // For demo purposes, simulate successful login
        // In real app, this would be an actual API call
        if (formData.email === 'demo@example.com' && formData.password === 'password') {
          console.log('Login successful');
          this.router.navigate(['/events']);
        } else {
          this.errorMessage.set('Invalid email or password. Try demo@example.com / password');
        }
      }, 1500);
    } else {
      console.log('Form is invalid');
      this.loginForm.markAllAsTouched();
    }
  }
}
