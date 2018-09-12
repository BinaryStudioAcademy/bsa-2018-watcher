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

  collectorApps: CollectorApp[];

  collectorApp: CollectorApp;

  displayAddWindow: boolean;

  constructor(private fb: FormBuilder, private toastrService: ToastrService, private collectorAppsService: CollectorAppsService ) {
    this.displayAddWindow = false;
    this.initData();
  }

  initData() {
    this.collectorApp = {
      id: 0,
      createdAt: new Date(),
      exeLink: '',
      tgzLink: '',
      debLink: '',
      isActive: false,
      version: ''
    };
  }

  ngOnInit() {
    this.updateData();
  }

  updateData() {
    this.collectorAppsService.getAll().subscribe(
      value => {
        this.collectorApps = value;
        },
        error => {
          this.toastrService.error(`Error ocured status: ${error.message}`);
        });
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

  uploadDebFile(file) {
    this.collectorAppsService.uploadInstaller(file).subscribe(
      event => {
        if (event.type === HttpEventType.UploadProgress) {
          this.collectorApp.debLink = Math.round(100 * event.loaded / event.total).toString();
        } else if (event.type === HttpEventType.Response) {
          this.collectorApp.debLink = event.body.toString();
        }
      });
  }

  uploadTgxFile(file) {
    this.collectorAppsService.uploadInstaller(file).subscribe(
      event => {
        if (event.type === HttpEventType.UploadProgress) {
          this.collectorApp.tgzLink = Math.round(100 * event.loaded / event.total).toString();
        } else if (event.type === HttpEventType.Response) {
          this.collectorApp.tgzLink = event.body.toString();
        }
      });
  }

  uploadExeFile(file) {
    this.collectorAppsService.uploadInstaller(file).subscribe(
      event => {
        if (event.type === HttpEventType.UploadProgress) {
          this.collectorApp.exeLink = Math.round(100 * event.loaded / event.total).toString();
        } else if (event.type === HttpEventType.Response) {
          this.collectorApp.exeLink = event.body.toString();
        }
      });
  }

  onSubmit() {
    this.collectorAppsService.create(this.collectorApp).subscribe(
      value => {
      this.updateData();
      this.toastrService.success('CollectorApp was created.');
      },
      error => {
        this.toastrService.error(`Error ocured status: ${error.message}`);
      });
      this.displayAddWindow = false;
      this.initData();
  }

  onDelete(collectorAppToDel) {
    this.toastrService.confirm().then(
      confirm => {
        if (confirm) {
          this.collectorAppsService.delete(collectorAppToDel.id).subscribe(
            result => {
              if (result) {
                this.updateData();
                this.toastrService.success('CollectorApp was removed.');
              } else {
                this.toastrService.error(`CollectorApp was not removed`);
              }
            },
            error => {
              this.toastrService.error(`Error ocured status: ${error.message}`);
          });
        }
      });
  }


}
