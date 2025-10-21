import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DayEventsList } from './day-events-list';

describe('DayEventsList', () => {
  let component: DayEventsList;
  let fixture: ComponentFixture<DayEventsList>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [DayEventsList]
    })
    .compileComponents();

    fixture = TestBed.createComponent(DayEventsList);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
