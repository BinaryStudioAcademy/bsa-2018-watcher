import { Injectable } from '@angular/core';
import {ApiService} from './api.service';
import {Observable} from 'rxjs';
import {CollectedData} from '../../shared/models/collected-data.model';

@Injectable({
  providedIn: 'root'
})
export class CollectedDataService {
  private readonly ctrlUrl = '/CollectedData';

  constructor(private apiService: ApiService) { }

  getBuilderData(): Observable<CollectedData[]> {
    return this.apiService.get(`${this.ctrlUrl}/Builder`) as Observable<CollectedData[]>;
  }
}
