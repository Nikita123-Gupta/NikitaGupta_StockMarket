import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { AdminLandPageComponent } from './admin-land-page.component';

describe('AdminLandPageComponent', () => {
  let component: AdminLandPageComponent;
  let fixture: ComponentFixture<AdminLandPageComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ AdminLandPageComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(AdminLandPageComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
