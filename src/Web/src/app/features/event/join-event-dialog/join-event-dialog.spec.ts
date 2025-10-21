import { ComponentFixture, TestBed } from '@angular/core/testing';

import { JoinEventDialog } from './join-event-dialog';

describe('JoinEventDialog', () => {
  let component: JoinEventDialog;
  let fixture: ComponentFixture<JoinEventDialog>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [JoinEventDialog],
    }).compileComponents();

    fixture = TestBed.createComponent(JoinEventDialog);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
