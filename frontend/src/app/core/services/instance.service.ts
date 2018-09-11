import {Injectable} from '@angular/core';
import {HttpClient} from '@angular/common/http';
import {Observable} from 'rxjs';
import {ToastrService} from './toastr.service';
import {InstanceRequest} from '../../dashboards/models/instance-request.model';
import {EventEmitter} from '@angular/core';
import {Instance} from '../../shared/models/instance.model';
import {ApiService} from './api.service';
import {map} from 'rxjs/operators';

@Injectable()
export class InstanceService {
  private ctrlUrl = 'instances';
  public instanceAdded: EventEmitter<Instance>;
  public instanceEdited: EventEmitter<Instance>;
  public instanceRemoved: EventEmitter<number>;
  public instanceChecked: EventEmitter<Instance>;

  constructor(private http: HttpClient,
              private toastrService: ToastrService,
              private apiService: ApiService) {
    this.instanceAdded = new EventEmitter<Instance>();
    this.instanceEdited = new EventEmitter<Instance>();
    this.instanceRemoved = new EventEmitter<number>();
    this.instanceChecked = new EventEmitter<Instance>();
  }

  getOne(id: number): Observable<Instance> {
    return this.apiService.get(`/${this.ctrlUrl}/single/${id}`)
      .pipe(map(value => this.extractSingleData(value)));
  }

  getAllByOrganization(id: number): Observable<Instance[]> {
    return this.apiService.get(`/${this.ctrlUrl}/${id}`)
      .pipe(map(value => this.extractData(value)));
  }

  create(instance: InstanceRequest): Observable<Instance> {
    return this.apiService.post(`/${this.ctrlUrl}`, instance)
      .pipe(map(value => this.extractSingleData(value)));
  }

  update(instance: InstanceRequest, id: number): Observable<Object> {
    return this.apiService.put(`/${this.ctrlUrl}/${id}`, instance);
  }

  delete(id: number): Observable<Object> {
    return this.apiService.delete(`/${this.ctrlUrl}/${id}`);
  }

  private extractData(res: Instance[]): Instance[] {
    const data = res || [];
    data.forEach((d) => {
      d.statusCheckedAt = new Date(d.statusCheckedAt);
    });
    return data;
  }

  private extractSingleData(res: Instance): Instance {
    if (!res) {
      return null;
    }
    res.statusCheckedAt = new Date(res.statusCheckedAt);
    return res;
  }
}

