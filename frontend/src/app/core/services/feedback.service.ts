import { Injectable } from '@angular/core';
import { HttpClient, HttpErrorResponse } from '@angular/common/http';
import { Observable, throwError } from 'rxjs';
import { environment } from '../../../environments/environment';
import { Feedback } from '../../shared/models/feedback.model';
import { retry, catchError } from 'rxjs/operators';

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
    return this.http.post<Feedback>(this.URL, feedback).pipe(
      retry(2),
      catchError(this.handleError));
  }

  handleError(error: HttpErrorResponse) {
    console.error(
      `Backend returned code ${error.status}, ` +
      `body was: ${error.error}`);
    return throwError(error.status);
  }
}
