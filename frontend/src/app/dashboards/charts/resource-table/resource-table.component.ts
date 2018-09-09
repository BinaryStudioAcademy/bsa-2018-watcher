import { Component, Input } from '@angular/core';

import { DataProperty, dataPropertyLables } from '../../../shared/models/data-property.enum';
import { CollectedData } from '../../../shared/models/collected-data.model';
import { ProcessData } from '../../../shared/models/process-data.model';

@Component({
  selector: 'app-resource-table',
  templateUrl: './resource-table.component.html',
  styleUrls: ['./resource-table.component.sass']
})
export class ResourceTableComponent {

  @Input() sources: DataProperty[];
  @Input() data: CollectedData;

  labels = dataPropertyLables;
  property = DataProperty;
  constructor() { }

  getHeader(value: DataProperty) {
    if (!this.data) {
      return  this.labels[value];
    }
    switch (value) {
      case DataProperty.name:
        return `Name (${this.data.processesCount || '...'})`;
      case DataProperty.pCpu:
        return `CPU (${Math.round(this.data.cpuUsagePercentage) || '...'}%)`;
      case DataProperty.pRam:
        return `RAM (${Math.round(this.data.ramUsagePercentage) || '...'}%)`;
      case DataProperty.ramMBytes:
        return `RAM (${Math.round(this.data.usageRamMBytes) || '...'}MB)`;
      default:
        return this.labels[value];
    }
  }

  getColor(process: ProcessData, col: DataProperty) {
    switch (col) {
      case DataProperty.ramMBytes:
        const percent = (process[DataProperty[col]] / this.data.totalRamMBytes) * 100;
        return this.calculateColor(percent);
      case DataProperty.pCpu:
      case DataProperty.pRam:
      const value = process[DataProperty[col]];
        return this.calculateColor(value);
    }
  }

  calculateColor(percent: number) {
    return 'rgba(' + [255, 255 - percent * 3, 255 - percent * 18, 0.6].join(',') + ')';
  }

  getValue(value) {
    const result = isNaN(value);
    if (result) {
      return value;
    }
    return Math.round(value * 100) / 100;
  }

  getValueFor(process: ProcessData, col: DataProperty) {
    const value = process[DataProperty[col]];
    const result = isNaN(value);
    if (result) {
      return value;
    }

    switch (col) {
      case DataProperty.pCpu:
      case DataProperty.pRam:
        return `${Math.round(value * 100) / 100}%`;
      case DataProperty.ramMBytes:
        return `${Math.round(value * 100) / 100} MB`;
      default:
        return Math.round(value * 100) / 100;
    }
  }
}
