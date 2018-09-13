import { Component, OnInit, Output, EventEmitter, Input } from '@angular/core';
import { DashboardChart } from '../../models/dashboard-chart';
import { SelectItem, SelectItemGroup } from 'primeng/api';
import { ChartType, chartTypeLabels } from '../../../shared/models/chart-type.enum';
import { colorSets } from '@swimlane/ngx-charts/release/utils';
import { DataService } from '../../../core/services/data.service';
import { dataPropertyLables, DataProperty } from '../../../shared/models/data-property.enum';
import { CollectedData } from '../../../shared/models/collected-data.model';
import { CollectedDataService } from '../../../core/services/collected-data.service';
import { timeFormat } from 'd3-time-format';
import { formatDate } from '@angular/common';
import { DataType } from '../../../shared/models/data-type.enum';

@Component({
  selector: 'app-edit-report-chart',
  templateUrl: './edit-report-chart.component.html',
  styleUrls: ['./edit-report-chart.component.sass']
})
export class EditReportChartComponent implements OnInit {
  @Output() addChart = new EventEmitter<DashboardChart>();
  @Output() editChart = new EventEmitter<DashboardChart>();
  @Output() closed = new EventEmitter();

  visible: boolean;

  @Input() onDisplay: EventEmitter<boolean>;
  @Input() dashboardChart: DashboardChart;
  @Input() collectedData: CollectedData[];
  @Input() edit: boolean;
  @Input() dateFrom: Date;
  @Input() dateTo: Date;
  @Input() dataType: DataType;

  dropdownTypes: SelectItem[] = [];
  dropdownGroupSources: SelectItemGroup[];

  type = ChartType;
  colorSchemes = colorSets;

  // historyTime: number; // in minutes
  isPreviewAvailable: boolean;
  isTimeAvailable: boolean;
  isXAxisAvailable: boolean;
  isYAxisAvailable: boolean;

  get dialogTitle() {
    return (this.edit) ? 'Edit chart' : 'Create chart';
  }

  get spinnerDisabled() {
    return this.dashboardChart && this.dashboardChart.showCommon;
  }

  get isValid(): boolean {
    return !!this.dashboardChart.dataSources.length;
  }

  constructor(private dataService: DataService,
              private collectedDataService: CollectedDataService) {
  }

  ngOnInit() {
    this.onDisplay.subscribe((isShow: boolean) => this.visible = isShow);
    this.dashboardChart.showCommon = true;

    // Fill dropdown with sources
      this.dropdownTypes.push({label: chartTypeLabels[0], value: 0 });
      this.dropdownTypes.push({label: chartTypeLabels[1], value: 1 });
      this.dropdownTypes.push({label: chartTypeLabels[2], value: 2 });
      this.dropdownTypes.push({label: chartTypeLabels[7], value: 7 });

    this.collectedDataService.getBuilderData().subscribe(data => {
      this.dataService.fakeCollectedData = data;
    });

    this.resetBuilderForm();
  }

  updtateReviewAllowing() {
    this.isPreviewAvailable = this.dashboardChart.showCommon;
  }

  dropDownSelect(event) {
    this.dashboardChart.dataSources = [event.value];
    this.processData();
  }

  resetBuilderForm() {
    this.dashboardChart.dataSources = [];
    this.createSourceItems();
    this.updtateReviewAllowing();

    switch (this.dashboardChart.type) {
      case ChartType.LineChart:
        this.isTimeAvailable = true;
        this.isXAxisAvailable = true;
        this.dashboardChart.xAxisLabel = 'Time';
        this.isYAxisAvailable = true;
        this.dashboardChart.yAxisLabel = 'Percentage %';
        break;
      case ChartType.BarVertical:
        this.isTimeAvailable = false;
        this.isXAxisAvailable = true;
        this.dashboardChart.xAxisLabel = 'Parameters';
        this.isYAxisAvailable = true;
        this.dashboardChart.yAxisLabel = 'Percentage %';
        break;
      case ChartType.Guage:
        this.isTimeAvailable = false;
        this.isYAxisAvailable = true;
        this.dashboardChart.yAxisLabel = 'Process';
        this.isXAxisAvailable = false;
        this.dashboardChart.xAxisLabel = '';
      break;
      default:
        this.isYAxisAvailable = false;
        this.isXAxisAvailable = false;
        break;
    }
  }

  createSourceItems() {
    this.dropdownGroupSources = [{
      label: 'Percentage',
      items: [
        { label: dataPropertyLables[DataProperty.cpuUsagePercentage], value: DataProperty.cpuUsagePercentage },
        { label: dataPropertyLables[DataProperty.ramUsagePercentage], value: DataProperty.ramUsagePercentage },
      ]
    }, {
      label: 'Memory',
      items: [
        { label: dataPropertyLables[DataProperty.usageRamMBytes], value: DataProperty.usageRamMBytes },
        { label: dataPropertyLables[DataProperty.localDiskUsageMBytes], value: DataProperty.localDiskUsageMBytes }
      ]
    }];
  }

  processChartType() {
    this.resetBuilderForm();
    this.processData();
  }

  showPreview() {
    this.isPreviewAvailable = true;
    this.processData();
  }

  processData(): void {
    const hourDifference = (this.dateTo.getTime() - this.dateFrom.getTime()) / (60 * 60000);

    if (hourDifference > 23) {
    this.dashboardChart.dateTickFormatting = (value) => {
      if (value instanceof Date) {
        if (this.dataType === DataType.AggregationForHour) {
          return formatDate((<Date>value), 'MMM, d h', 'en-US');
        } else {
          return formatDate((<Date>value), 'MMM, d', 'en-US');
        }
      }
     };
    }

    const data = this.collectedData && this.edit ? this.collectedData : this.dataService.fakeCollectedData;
    this.isPreviewAvailable = this.dataService.fulfillChart(data, this.dashboardChart, true);
  }

  closeDialog() {
    this.visible = false;
    this.closed.emit();
  }

  onSaveChart(): void {
    const data = this.collectedData ? this.collectedData : [];
    this.dataService.fulfillChart(data, this.dashboardChart, true);

    if (this.edit) {
      this.editChart.emit(this.dashboardChart);
    } else {
      this.addChart.emit(this.dashboardChart);
    }

    this.visible = false;
  }
}
