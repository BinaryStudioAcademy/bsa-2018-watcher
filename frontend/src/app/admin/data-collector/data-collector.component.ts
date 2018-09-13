import { Component, OnInit } from '@angular/core';
import { CollectorApp } from '../../shared/models/collector-app.model';
import { ToastrService } from '../../core/services/toastr.service';
import { CollectorAppsService } from '../../core/services/collector-apps.service';
import { HttpEventType, } from '@angular/common/http';

@Component({
  selector: 'app-data-collector',
  templateUrl: './data-collector.component.html',
  styleUrls: ['./data-collector.component.sass']
})
export class DataCollectorComponent implements OnInit {

  collectorApps: CollectorApp[];

  collectorApp: CollectorApp;

  displayAddWindow: boolean;

  constructor(private toastrService: ToastrService,
                 private collectorAppsService: CollectorAppsService ) {
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
    if (collectorAppToDel.isActive) {
      this.toastrService.notice('This version of the application is selected as the current version '
      + 'and can not be deleted. Change the current version of the application and try again.');
    } else {
      this.toastrService.confirm().then(
        confirm => {
          if (confirm) {
            this.collectorAppsService.delete(collectorAppToDel.id).subscribe(
              result => {
                if (result) {
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
        this.updateData();
    }
  }

  ActiveAppChenge(collectorApp) {
    this.toastrService.confirm().then(
      confirm => {
        if (confirm) {
          this.collectorAppsService.setActualApp(collectorApp.id).subscribe(
            result => {
              if (result) {
                this.updateData();
                this.toastrService.success('Actual CollectorApp was changed.');
              } else {
                this.toastrService.error(`Actual CollectorApp was not changed`);
              }
            },
            error => {
              this.toastrService.error(`Error ocured status: ${error.message}`);
          });
        }
      });
  }
}
