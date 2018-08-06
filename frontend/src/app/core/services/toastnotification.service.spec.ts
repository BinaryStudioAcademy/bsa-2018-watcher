import { TestBed, inject } from '@angular/core/testing';

import { ToastnotificationService } from './toastnotification.service';

describe('ToastnotificationService', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [ToastnotificationService]
    });
  });

  it('should be created', inject([ToastnotificationService], (service: ToastnotificationService) => {
    expect(service).toBeTruthy();
  }));
});
