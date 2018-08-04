import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { DashboardsPageComponent } from './dashboards-page.component';

describe('DashboardsPageComponent', () => {
  let component: DashboardsPageComponent;
  let fixture: ComponentFixture<DashboardsPageComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ DashboardsPageComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(DashboardsPageComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
