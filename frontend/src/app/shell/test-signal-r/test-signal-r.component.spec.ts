import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { TestSignalRComponent } from './test-signal-r.component';

describe('TestSignalRComponent', () => {
  let component: TestSignalRComponent;
  let fixture: ComponentFixture<TestSignalRComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ TestSignalRComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(TestSignalRComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
