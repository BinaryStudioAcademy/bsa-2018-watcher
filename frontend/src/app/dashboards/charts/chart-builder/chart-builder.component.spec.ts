import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ChartBuilderComponent } from './chart-builder.component';

describe('ChartBuilderComponent', () => {
  let component: ChartBuilderComponent;
  let fixture: ComponentFixture<ChartBuilderComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ChartBuilderComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ChartBuilderComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
