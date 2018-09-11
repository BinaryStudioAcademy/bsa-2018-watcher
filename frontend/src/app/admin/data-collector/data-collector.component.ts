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

  displayAddWindow: boolean;

  constructor(private fb: FormBuilder, private toastrService: ToastrService, private collectorAppsService: CollectorAppsService ) {
    this.displayAddWindow = false;
    this.collectorApp = {
      id: 0,
      createdAt: new Date(),
      exeLink: '',
      tgzLink: '',
      debLink: '',
      isActual: false,
      version: ''
    };
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

  uploadDebFile(files) {
    const fileToUpload = files.files[0];
    this.collectorAppsService.uploadInstaller(fileToUpload).subscribe(
      event => {
        if (event.type === HttpEventType.UploadProgress) {
          this.collectorApp.debLink = Math.round(100 * event.loaded / event.total).toString();
        } else if (event.type === HttpEventType.Response) {
          this.collectorApp.debLink = event.body.toString();
        }
      });
  }

  onSubmit() {

  }

}
