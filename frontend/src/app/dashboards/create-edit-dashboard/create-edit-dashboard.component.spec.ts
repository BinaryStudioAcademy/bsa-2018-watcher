import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { CreateEditDashboardComponent } from './create-edit-dashboard.component';

describe('CreateEditDashboardComponent', () => {
  let component: CreateEditDashboardComponent;
  let fixture: ComponentFixture<CreateEditDashboardComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ CreateEditDashboardComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(CreateEditDashboardComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
