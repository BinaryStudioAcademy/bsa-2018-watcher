import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { ApiService } from './api.service';
import { Message } from '../../shared/models/message.model';

@Injectable()
export class MessageService {
  private readonly ctrlUrl = 'messages';

  constructor(private apiService: ApiService) {
  }

  getAll(): Observable<Message[]> {
    return this.apiService.get(`/${this.ctrlUrl}`);
  }

  get(id: number): Observable<Message> {
    return this.apiService.getById(`/${this.ctrlUrl}`, id);
  }

  create(message: Message) {
    return this.apiService.post(`/${this.ctrlUrl}`, message);
  }

  update(id: number, message: Message) {
    return this.apiService.put(`/${this.ctrlUrl}/${id}`, message);
  }

  delete(id: number): Observable<Message> {
    return this.apiService.delete(`/${this.ctrlUrl}/${id}`);
  }
}
