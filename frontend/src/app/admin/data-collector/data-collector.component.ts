import { Component, OnInit } from '@angular/core';
import { CollectorApp } from '../../shared/models/collector-app.model';

@Component({
  selector: 'app-data-collector',
  templateUrl: './data-collector.component.html',
  styleUrls: ['./data-collector.component.sass']
})
export class DataCollectorComponent implements OnInit {

  collectorApps: CollectorApp[] = [{
    id: 1,
    createdAt: new Date(),
    version: '1.0.3',
    exeLink: '',
    debLink: '',
    tgzLink: '',
    isActual: true
  }, {
    id: 2,
    createdAt: new Date(),
    version: '1.0.4',
    exeLink: '',
    debLink: '',
    tgzLink: '',
    isActual: false
  }];
  collectorApp: CollectorApp;
  currentCollectorApp: CollectorApp;
  displayPopup: boolean;
  totalRecords: number;

  constructor() { }

  ngOnInit() {
    this.totalRecords = 2;
  }

}
