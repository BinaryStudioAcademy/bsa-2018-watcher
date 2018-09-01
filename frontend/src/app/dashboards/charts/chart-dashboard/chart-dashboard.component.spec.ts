import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ChartDashboardComponent } from './chart-dashboard.component';

describe('ChartDashboardComponent', () => {
  let component: ChartDashboardComponent;
  let fixture: ComponentFixture<ChartDashboardComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ChartDashboardComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ChartDashboardComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
