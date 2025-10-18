import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ConfirmPasswordInput } from './confirm-password-input';

describe('ConfirmPasswordInput', () => {
  let component: ConfirmPasswordInput;
  let fixture: ComponentFixture<ConfirmPasswordInput>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [ConfirmPasswordInput]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ConfirmPasswordInput);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
