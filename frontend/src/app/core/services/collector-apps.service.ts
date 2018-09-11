import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import {ApiService} from './api.service';
import { HttpHeaders, HttpEvent } from '@angular/common/http';

@Injectable()
export class CollectorAppsService {
  private readonly ctrlUrl = 'CollectorApps';

  constructor(private apiService: ApiService) { }

  public uploadInstaller(file): Observable<HttpEvent<{}>> {

    return this.apiService.uploadFile(`/${this.ctrlUrl}/uploadApp`, file);
  }



}
