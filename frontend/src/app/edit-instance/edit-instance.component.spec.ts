import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { EditInstanceComponent } from './edit-instance.component';

describe('EditInstanceComponent', () => {
  let component: EditInstanceComponent;
  let fixture: ComponentFixture<EditInstanceComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ EditInstanceComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(EditInstanceComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
