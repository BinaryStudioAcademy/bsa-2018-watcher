import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { environment } from '../../../environments/environment';
import { Feedback } from '../../shared/models/feedback.model';

@Injectable(/*{
  providedIn: 'root'
}*/)
export class FeedbackService {

  URL = environment.server_url + '/Feedbacks';

  constructor(private http: HttpClient) {
  }

  getAll(): Observable<Feedback[]> {
    return this.http.get<Feedback[]>(this.URL);
  }

  get(id: number): Observable<Feedback> {
    return this.http.get<Feedback>(`${this.URL}/${id}`);
  }

  create(feedback: Feedback) {
    return this.http.post<Feedback>(this.URL, feedback);
  }

}
