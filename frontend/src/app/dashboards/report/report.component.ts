import { Component, OnInit, ViewChild, ElementRef, EventEmitter, QueryList, ViewChildren } from '@angular/core';
import { AggregatedDataService } from '../../core/services/aggregated-data.service';
import { ActivatedRoute } from '@angular/router';
import { DataType } from '../../shared/models/data-type.enum';
import { CollectedData } from '../../shared/models/collected-data.model';
import { AggregateDataRequest } from '../../shared/models/aggregate-data-request.model';
import { SelectItem, MenuItem } from 'primeng/api';
import { Calendar } from 'primeng/primeng';
import { formatDate } from '@angular/common';
import * as jsPDF from 'jspdf';
import 'jspdf-autotable';
import { Observable } from 'rxjs';
import { ProcessData } from '../../shared/models/process-data.model';
import { DashboardChart } from '../models/dashboard-chart';
import { defaultOptions } from '../charts/models/chart-options';
import { DataService } from '../../core/services/data.service';
import html2canvas from 'html2canvas';

@Component({
  selector: 'app-report',
  templateUrl: './report.component.html',
  styleUrls: ['./report.component.sass']
})
export class ReportComponent implements OnInit {

  @ViewChild('cf1') calendarFilter1: Calendar;
  @ViewChild('cf2') calendarFilter2: Calendar;
  @ViewChild('ct') timeInput: Calendar;
  @ViewChildren('chartPDF') chartPDF: QueryList<ElementRef>;

  private id: string;

  collectedDataTable: CollectedData[];
  collectedData: CollectedData[];

  types: SelectItem[];
  selectedType: DataType;

  dateFrom: Date;
  dateTo: Date;

  cols: any[];

  recordsPerPage = 1;
  totalRecords: number;

  chartToEdit = {...defaultOptions};
  charts: DashboardChart[];

  editChartIndex: number;
  edit: boolean;
  close: boolean;

  cogItems: MenuItem[];

  tabs: MenuItem[];
  activeTab: MenuItem;

  onDisplayChartEditing = new EventEmitter<boolean>();

  constructor(private aggregatedDateService: AggregatedDataService,
              private activateRoute: ActivatedRoute,
              private dataService: DataService) { }

  ngOnInit() {
    this.charts = [];

    this.tabs = [
      { label: 'Table', command: () => this.activeTab = this.tabs[0] },
      { label: 'Chart', command: () => this.activeTab = this.tabs[1] }
    ];

    this.activeTab = this.tabs[0];

    this.cogItems = [{
      label: 'Add item',
      icon: 'fa fa-fw fa-plus',

      command: (event?: any) => {
        this.close = false;

        this.decomposeChart(defaultOptions);
        this.showChartCreating();
      },
    }];

    this.cols = [
      { field: 'name', header: 'Name' },
      { field: 'pCpu', header: 'CPU,%' },
      { field: 'pCpuMax', header: 'Max' },
      { field: 'pCpuMin', header: 'Min' },
      { field: 'pRam', header: 'RAM, %' },
      { field: 'pRamMax', header: 'Max' },
      { field: 'pRamMin', header: 'Min' },
      { field: 'ramMBytes', header: 'RAM, Mb' },
      { field: 'ramMBytesMax', header: 'Max' },
      { field: 'ramMBytesMin', header: 'Min' }
    ];

    this.types = [
      { label: 'Hourly', value: DataType.AggregationForHour },
      { label: 'Daily', value: DataType.AggregationForDay },
      { label: 'Weekly', value: DataType.AggregationForWeek },
      { label: 'Monthly', value: DataType.AggregationForMonth }
    ];

    this.selectedType = this.types[0].value;

    this.calendarFilter1.showTime = true;
    this.calendarFilter2.showTime = true;

    this.calendarFilter1.dateFormat = 'dd/mm/yy';
    this.calendarFilter2.dateFormat = 'dd/mm/yy';

    const x = this.activateRoute.params.subscribe(params => {
      this.id = params['guidId'];
    });
  }

  changeType(ev): void {
    switch (DataType[ev.value]) {
      case 'AggregationForHour':
        this.calendarFilter1.showTime = true;
        this.calendarFilter2.showTime = true;
        break;
      case 'AggregationForDay':
        if (this.dateFrom && this.dateTo) {
          this.dateFrom.setHours(0);
          this.dateFrom.setMinutes(0);
          this.dateTo.setHours(0);
          this.dateTo.setMinutes(0);
        }
        this.calendarFilter1.showTime = false;
        this.calendarFilter2.showTime = false;
        break;
      case 'AggregationForWeek':
        if (this.dateFrom && this.dateTo) {
          this.dateFrom.setHours(0);
          this.dateFrom.setMinutes(0);
          this.dateTo.setHours(0);
          this.dateTo.setMinutes(0);
        }
        this.calendarFilter1.showTime = false;
        this.calendarFilter2.showTime = false;
        break;
      case 'AggregationForMonth':
        if (this.dateFrom && this.dateTo) {
          this.dateFrom.setHours(0);
          this.dateFrom.setMinutes(0);
          this.dateTo.setHours(0);
          this.dateTo.setMinutes(0);
        }
        this.calendarFilter1.showTime = false;
        this.calendarFilter2.showTime = false;
        break;
    }
  }

  private createRequest(): AggregateDataRequest {
    return {
      id: this.id,
      type: this.selectedType,
      from: this.dateFrom,
      to: this.dateTo
    };
  }

  getInfo(): void {
    const request: AggregateDataRequest = this.createRequest();

    this.getCollectedData(request).subscribe((data: CollectedData[]) => {
      data.forEach(item => {
        item.time = new Date(item.time);
        item.processes = item.processes.map(p => this.roundProcess(p));

        item.processes.sort((item1, item2) => {
          return item2.pCpu - item1.pCpu;
        });
      });
      this.collectedData = data;
      this.charts.forEach(item => this.dataService.fulfillChart(this.collectedData, item, true));
      this.collectedDataTable = data.slice(0, this.recordsPerPage);
    });

    this.aggregatedDateService.getCountOfEntities(request).subscribe(totalRecords => {
      this.totalRecords = totalRecords;
      console.log(totalRecords);
    });
  }

  private getCollectedData(request: AggregateDataRequest): Observable<CollectedData[]> {
      return this.aggregatedDateService.getDataByInstanceIdAndTypeInTime(request);
  }

  paginate(event) {
    const start = event.page * this.recordsPerPage;
    const end = event.page * this.recordsPerPage + this.recordsPerPage;
    this.collectedDataTable = this.collectedData.slice(start, end);
  }

  roundProcess(processData: ProcessData) {
    const item: ProcessData = {
      name: processData.name,
      pCpu: +processData.pCpu.toFixed(2),
      pCpuMax: +processData.pCpuMax.toFixed(2),
      pCpuMin: +processData.pCpuMin.toFixed(2),

      pRam: +processData.pRam.toFixed(2),
      pRamMax: +processData.pRamMax.toFixed(2),
      pRamMin: +processData.pRamMin.toFixed(2),

      ramMBytes: +processData.ramMBytes.toFixed(2),
      ramMBytesMax: +processData.ramMBytesMax.toFixed(2),
      ramMBytesMin: +processData.ramMBytesMin.toFixed(2)
    };
    console.log(item);
    return item;
  }

  convertPDF(): void {
    const doc = new jsPDF('p', 'mm', 'a4');

    if (this.activeTab === this.tabs[0]) {
      doc.setFontSize(10);

      const tables = this.createTables(this.collectedData);

      doc.deletePage(1);
      tables.forEach(item => {
        doc.addPage();
        doc.autoTable(item.cols, item.rows);
        doc.text(`Time: ${item.time}`, 20, doc.autoTable.previous.finalY + 10);
      });

      // tslint:disable-next-line:max-line-length
      doc.save(`Report ${DataType[this.selectedType]} Period ${formatDate(this.dateFrom, 'dd/MM/yy HH:mm', 'en-US')} - ${formatDate(this.dateTo, 'dd/MM/yy HH:mm', 'en-US')}`);
    } else {
      const eventRender = new EventEmitter();
      doc.deletePage(1);
      this.chartPDF.forEach(item => {
        html2canvas(item.nativeElement).then(canvas => {
          const contentDataURL = canvas.toDataURL('image/png');
          doc.addPage();
          doc.addImage(contentDataURL, 'PNG', 35, 100);
          eventRender.emit();
        });
      });

      let renderedImg = 0;
      eventRender.subscribe(() => {
        renderedImg++;
        if (renderedImg === this.chartPDF.length) {
          // tslint:disable-next-line:max-line-length
          doc.save(`Report ${DataType[this.selectedType]} Period ${formatDate(this.dateFrom, 'dd/MM/yy HH:mm', 'en-US')} - ${formatDate(this.dateTo, 'dd/MM/yy HH:mm', 'en-US')}`);
        }
      });
    }
  }

  private createTables(data: CollectedData[]): any[] {
    const tables = [];

    const cols: string[] = [];
    this.cols.forEach(item => {
      cols.push(item.header);
    });

    data.forEach(item => {
      const rows = [];

      item.processes.forEach(p => rows.push(
        [p.name,
         p.pCpu.toString(),
         p.pCpuMax.toString(),
         p.pCpuMin.toString(),
         p.pRam.toString(),
         p.pRamMax.toString(),
         p.pRamMin.toString(),
         p.ramMBytes.toString(),
         p.ramMBytesMax.toString(),
         p.ramMBytesMin.toString(),
        ]));

      tables.push({
        cols: cols,
        rows: rows,
        time: formatDate(item.time, 'dd/MM/yy HH:mm', 'en-US')
      });
    });

    return tables;
  }

  decomposeChart(chart: DashboardChart): void {
    this.chartToEdit = {...chart};
    this.chartToEdit.colorScheme = {...chart.colorScheme};
    this.chartToEdit.type = chart.type;
  }

  showChartCreating() {
    this.onDisplayChartEditing.emit(true);
  }

  editChart(chart: DashboardChart): void {
    this.edit = true;
    this.editChartIndex = this.charts.indexOf(chart);
    this.decomposeChart(chart);
    this.showChartCreating();
  }

  deleteChart(chart: DashboardChart): void {
    const indexDeleteChart = this.charts.indexOf(chart);
    this.charts.splice(indexDeleteChart, 1);
  }

  onAddChart(event: DashboardChart): void {
    this.charts.push({...event});
    this.decomposeChart(defaultOptions);
  }

  onEditChart(event: DashboardChart): void {
    this.charts[this.editChartIndex] = {...event};
    this.edit = false;
    this.decomposeChart(defaultOptions);
  }

  onClosed(): void {
    this.close = true;
    this.edit = false;
    this.decomposeChart(defaultOptions);
  }

}
