import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { UpdateIPOComponent } from './update-ipo.component';

describe('UpdateIPOComponent', () => {
  let component: UpdateIPOComponent;
  let fixture: ComponentFixture<UpdateIPOComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ UpdateIPOComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(UpdateIPOComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
