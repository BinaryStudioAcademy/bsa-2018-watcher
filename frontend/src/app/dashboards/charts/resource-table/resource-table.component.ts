import { Component, Input } from '@angular/core';

import { DataProperty, dataPropertyLables } from '../../../shared/models/data-property.enum';
import { CollectedData } from '../../../shared/models/collected-data.model';

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
        return `Name (${this.data.processesCount})`;
      case DataProperty.pCpu:
        return `CPU (${Math.round(this.data.cpuUsagePercentage)}%)`;
      case DataProperty.pRam:
        return `RAM (${Math.round(100 - this.data.freeRamPercentage)}%)`;
      case DataProperty.ramMBytes:
        return `RAM (${this.data.usageRamMBytes}MB)`;
      default:
        return this.labels[value];
    }
  }

  getColor(percent: number) {
    return 'rgba(' + [255, 255 - percent * 4, 255 - percent * 18, 0.6].join(',') + ')';
  }

  getValue(value) {
    const result = isNaN(value);
    if (result) {
      return value;
    }
    return Math.round(value * 100) / 100;
  }
}
