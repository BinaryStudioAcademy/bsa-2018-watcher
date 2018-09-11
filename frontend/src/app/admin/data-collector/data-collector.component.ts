import { Component, OnInit, ViewChild } from '@angular/core';
import { CollectorApp } from '../../shared/models/collector-app.model';
import { FormBuilder, FormControl, Validators } from '@angular/forms';
import { ToastrService } from '../../core/services/toastr.service';
import {FileUpload} from 'primeng/primeng';
import { CollectorAppsService } from '../../core/services/collector-apps.service';
import { HttpEventType, HttpEvent, HttpRequest } from '@angular/common/http';
import { Observable } from 'rxjs';
import { environment } from '../../../environments/environment';

@Component({
  selector: 'app-data-collector',
  templateUrl: './data-collector.component.html',
  styleUrls: ['./data-collector.component.sass']
})
export class DataCollectorComponent implements OnInit {
  @ViewChild('fileInput') fileInput: FileUpload;

  collectorApps: CollectorApp[] = [{
    id: 1,
    createdAt: new Date(),
    version: '1.0.3',
    exeLink: 'exe',
    debLink: 'deb',
    tgzLink: 'tgz',
    isActual: true
  }, {
    id: 2,
    createdAt: new Date(),
    version: '1.0.4',
    exeLink: 'exe',
    debLink: 'deb',
    tgzLink: 'tgz',
    isActual: false
  }];

  collectorApp: CollectorApp;
  currentCollectorApp: CollectorApp;
  displayAddWindow: boolean;

  public progress: number;
  public message: string;

  fileToUpload: File = null;

  dataCollectorAppForm = this.fb.group({
    ceatedAt: new FormControl({ value: '', disabled: false }, Validators.required),
    version: new FormControl({ value: '', disabled: false }, Validators.required),
    exeFile: new FormControl({ value: '', disabled: false }, Validators.required),
    debFile: new FormControl({ value: '', disabled: false }, Validators.required),
    tgzFile: new FormControl({ value: '', disabled: false }, Validators.required),
    description: new FormControl({ value: '', disabled: false }),
    isActual: new FormControl({ value: false, disabled: false }, Validators.required)
  });
  http: any;

  constructor(private fb: FormBuilder, private toastrService: ToastrService, private collectorAppsService: CollectorAppsService ) {
    this.displayAddWindow = false;

  }

  ngOnInit() {

  }

  showAddWindow() {
    this.displayAddWindow = true;
  }

  onCancel() {
    this.displayAddWindow = false;
  }

  startUpload() {
    this.fileInput.upload();
  }

  uploadFile(fileToUpload) {
    this.collectorAppsService.uploadInstaller(fileToUpload).subscribe(
      event => {
        if (event.type === HttpEventType.UploadProgress) {
          this.progress = Math.round(100 * event.loaded / event.total);
        } else if (event.type === HttpEventType.Response) {
          this.message = event.body.toString();
             }
      });
  }

  onSubmit() {

  }

}
