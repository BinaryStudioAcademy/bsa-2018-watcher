import { Component, OnInit, ViewChild, ElementRef } from '@angular/core';
import { AggregatedDataService } from '../../core/services/aggregated-data.service';
import { ActivatedRoute } from '@angular/router';
import { DataType } from '../../shared/models/data-type.enum';
import { CollectedData } from '../../shared/models/collected-data.model';
import { AggregateDataRequest } from '../../shared/models/aggregate-data-request.model';
import { SelectItem } from 'primeng/api';
import { Calendar } from 'primeng/primeng';
import { formatDate } from '@angular/common';
import * as jsPDF from 'jspdf';
import 'jspdf-autotable';
import { Observable } from 'rxjs';

@Component({
  selector: 'app-report',
  templateUrl: './report.component.html',
  styleUrls: ['./report.component.sass']
})
export class ReportComponent implements OnInit {

  @ViewChild('cf1') calendarFilter1: Calendar;
  @ViewChild('cf2') calendarFilter2: Calendar;
  @ViewChild('ct') timeInput: Calendar;

  private id: string;

  collectedData: CollectedData[];

  types: SelectItem[];
  selectedType: DataType;

  dateFrom: Date;
  dateTo: Date;

  cols: any[];

  recordsPerPage = 1;
  totalRecords: number;

  constructor(private aggregatedDateService: AggregatedDataService,
              private activateRoute: ActivatedRoute) { }

  ngOnInit() {
    this.cols = [
      { field: 'name', header: 'Name' },
      { field: 'pCpu', header: 'CPU,%' },
      { field: 'pRam', header: 'RAM, %' },
      { field: 'ramMBytes', header: 'RAM, Mb' }
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
        this.dateFrom.setHours(0);
        this.dateFrom.setMinutes(0);
        this.dateTo.setHours(0);
        this.dateTo.setMinutes(0);
        this.calendarFilter1.showTime = false;
        this.calendarFilter2.showTime = false;
        break;
      case 'AggregationForWeek':
        this.dateFrom.setHours(0);
        this.dateFrom.setMinutes(0);
        this.dateTo.setHours(0);
        this.dateTo.setMinutes(0);
        this.calendarFilter1.showTime = false;
        this.calendarFilter2.showTime = false;
        break;
      case 'AggregationForMonth':
        this.dateFrom.setHours(0);
        this.dateFrom.setMinutes(0);
        this.dateTo.setHours(0);
        this.dateTo.setMinutes(0);
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

    this.getCollectedData(request, 1, this.recordsPerPage).subscribe((data: CollectedData[]) => {
      data.forEach(item => {
        item.time = new Date(item.time);
        item.processes.forEach(p => {
          p.pCpu = +p.pCpu.toFixed(2);
          p.pRam = +p.pRam.toFixed(2);
          p.ramMBytes = +p.ramMBytes.toFixed(2);
        });

        item.processes.sort((item1, item2) => {
          return item2.pCpu - item1.pCpu;
        });
      });
      this.collectedData = data;
    });

    this.aggregatedDateService.getCountOfEntities(request).subscribe(totalRecords => {
      this.totalRecords = totalRecords;
      console.log(totalRecords);
    });
  }

  private getCollectedData(request: AggregateDataRequest, page: number = -1, records: number = -1): Observable<CollectedData[]> {
    if (page >= 0 && records >= 0) {
      return this.aggregatedDateService.getDataByInstanceIdAndTypeInTimePaging(request,
        page, records);
    } else {
      return this.aggregatedDateService.getDataByInstanceIdAndTypeInTime(request);
    }
  }

  paginate(event) {
    this.getCollectedData(this.createRequest(), event.page, this.recordsPerPage).subscribe((data: CollectedData[]) => {
      data.forEach(item => {
        item.time = new Date(item.time);
        item.processes.forEach(p => {
          p.pCpu = +p.pCpu.toFixed(2);
          p.pRam = +p.pRam.toFixed(2);
          p.ramMBytes = +p.ramMBytes.toFixed(2);
        });

        item.processes.sort((item1, item2) => {
          return item2.pCpu - item1.pCpu;
        });
      });
      this.collectedData = data;
    });
  }

  convertPDF(): void {
    const doc = new jsPDF('p', 'mm', 'a4');
    doc.setFontSize(10);

    this.getCollectedData(this.createRequest()).subscribe((data: CollectedData[]) => {
      data.forEach(item => {
        item.time = new Date(item.time);
        item.processes.forEach(p => {
          p.pCpu = +p.pCpu.toFixed(2);
          p.pRam = +p.pRam.toFixed(2);
          p.ramMBytes = +p.ramMBytes.toFixed(2);
        });

        item.processes.sort((item1, item2) => {
          return item2.pCpu - item1.pCpu;
        });
      });

      const tables = this.createTables(data);

      doc.deletePage(1);
      tables.forEach(item => {
        doc.addPage();
        doc.autoTable(item.cols, item.rows);
        doc.text(`Time: ${item.time}`, 20, doc.autoTable.previous.finalY + 10);
      });

      // tslint:disable-next-line:max-line-length
      doc.save(`Report ${DataType[this.selectedType]} Period ${formatDate(this.dateFrom, 'dd/MM/yy HH:mm', 'en-US')} - ${formatDate(this.dateTo, 'dd/MM/yy HH:mm', 'en-US')}`);

    });
  }

  private createTables(data: CollectedData[]): any[] {
    const tables = [];

    const cols: string[] = [];
    this.cols.forEach(item => {
      cols.push(item.header);
    });

    data.forEach(item => {
      const rows = [];

      item.processes.forEach(p => rows.push([p.name, p.pCpu.toString(), p.pRam.toString(), p.ramMBytes.toString()]));

      tables.push({
        cols: cols,
        rows: rows,
        time: formatDate(item.time, 'dd/MM/yy HH:mm', 'en-US')
      });
    });

    return tables;
  }

}
