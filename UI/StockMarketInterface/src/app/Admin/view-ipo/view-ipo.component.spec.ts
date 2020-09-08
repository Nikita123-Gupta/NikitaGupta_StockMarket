import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ViewIPOComponent } from './view-ipo.component';

describe('ViewIPOComponent', () => {
  let component: ViewIPOComponent;
  let fixture: ComponentFixture<ViewIPOComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ViewIPOComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ViewIPOComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
