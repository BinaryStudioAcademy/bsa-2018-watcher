import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { ApiService } from './api.service';
import { Chat } from '../../shared/models/chat.model';

@Injectable({
  providedIn: 'root'
})
export class ChatService {
  private readonly ctrlUrl = 'chats';

  constructor(private apiService: ApiService) {
  }

  getAll(): Observable<Chat[]> {
    return this.apiService.get(`/${this.ctrlUrl}`);
  }

  get(id: number): Observable<Chat> {
    return this.apiService.getById(`/${this.ctrlUrl}`, id);
  }

  getByUserId(id: string): Observable<Chat[]> {
    return this.apiService.getById(`/${this.ctrlUrl}/user`, id);
  }

  create(chat: Chat) {
    return this.apiService.post(`/${this.ctrlUrl}`, chat);
  }

  update(id: number, chat: Chat) {
    return this.apiService.put(`/${this.ctrlUrl}/${id}`, chat);
  }

  delete(id: number): Observable<Chat> {
    return this.apiService.delete(`/${this.ctrlUrl}/${id}`);
  }
}
