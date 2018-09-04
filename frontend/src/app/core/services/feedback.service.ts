import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Feedback } from '../../shared/models/feedback.model';
import { ApiService } from './api.service';

@Injectable()
export class FeedbackService {
  private readonly ctrlUrl = 'feedbacks';

  constructor(private apiService: ApiService) {
  }

  getAll(): Observable<Feedback[]> {
    return this.apiService.get(`/${this.ctrlUrl}`);
  }

  getRange(page: number, pageSize: number): Observable<Feedback[]> {
    return this.apiService.get(`/${this.ctrlUrl}/table?page=${page}&pageSize=${pageSize}`);
  }

  getNumber(): Observable<number> {
    return this.apiService.get(`/${this.ctrlUrl}/number`);
  }

  get(id: number): Observable<Feedback> {
    return this.apiService.get(`/${this.ctrlUrl}/${id}`);
  }

  create(feedback: Feedback) {
    return this.apiService.post(`/${this.ctrlUrl}`, feedback);
  }
}
