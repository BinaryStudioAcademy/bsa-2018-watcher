import { Injectable } from '@angular/core';
import { ApiService } from './api.service';
import { Theme } from '../../shared/models/theme.model';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class ThemeService {

  private readonly ctrlUrl = 'Themes';

  constructor(private apiService: ApiService) { }

  public getAll(): Observable<Theme[]> {
    return this.apiService.get(`/${this.ctrlUrl}/`) as Observable<Theme[]>;
  }
}
