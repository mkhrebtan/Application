import { ComponentFixture, TestBed } from '@angular/core/testing';

import { EventListingCard } from './event-listing-card';

describe('EventListingCard', () => {
  let component: EventListingCard;
  let fixture: ComponentFixture<EventListingCard>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [EventListingCard]
    })
    .compileComponents();

    fixture = TestBed.createComponent(EventListingCard);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
