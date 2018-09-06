import {Injectable} from '@angular/core';
import {CustomData, date_sort_asc} from '../../dashboards/charts/models';
import {CollectedData} from '../../shared/models/collected-data.model';
import {NumberSeriesItem, SeriesItem} from '../../dashboards/models/series-item';
import {MultiChartItem} from '../../dashboards/models/multi-chart-item';
import {DataProperty, dataPropertyLables} from '../../shared/models/data-property.enum';
import {ChartType} from '../../shared/models/chart-type.enum';
import {Chart} from '../../shared/models/chart.model';
import {DashboardChart} from '../../dashboards/models/dashboard-chart';
import {dashboardChartTypes} from '../../dashboards/charts/models/dashboardChartTypes';
import {defaultOptions} from '../../dashboards/charts/models/chart-options';
import {ChartRequest} from '../../shared/requests/chart-request.model';
import {ProcessData} from '../../shared/models/process-data.model';

@Injectable()
export class DataService {
  constructor() {
  }

  convertStringToArrEnum(sources: string) {
    const array: DataProperty[] = [];
    const arrNumbers = sources.split(',');

    for (let i = 0; i < arrNumbers.length; i++) {
      array.push(+arrNumbers[i]);
    }

    return array;
  }

  instantiateDashboardChart(value: Chart, collData: CollectedData[]): DashboardChart {
    const dataProps = this.convertStringToArrEnum(value.sources);
    const dashChart: DashboardChart = {
      view: [600, 300],
      id: value.id,
      showCommon: value.showCommon,
      threshold: value.threshold,
      mostLoaded: value.mostLoaded,
      colorScheme: {...defaultOptions.colorScheme},
      schemeType: defaultOptions.schemeType,
      showLegend: value.showLegend,
      legendTitle: value.legendTitle,
      gradient: value.gradient,
      showXAxis: value.showXAxis,
      showYAxis: value.showYAxis,
      showXAxisLabel: value.showXAxisLabel,
      showYAxisLabel: value.showYAxisLabel,
      yAxisLabel: value.yAxisLabel,
      xAxisLabel: value.xAxisLabel,
      yScaleMin: defaultOptions.yScaleMin,
      yScaleMax: defaultOptions.yScaleMax,
      autoScale: value.autoScale,
      showGridLines: value.showGridLines,
      rangeFillOpacity: value.rangeFillOpacity,
      roundDomains: value.roundDomains,
      tooltipDisabled: value.isTooltipDisabled,
      showSeriesOnHover: value.isShowSeriesOnHover,
      curve: defaultOptions.curve,
      curveClosed: defaultOptions.curveClosed,
      title: value.title,
      dataSources: dataProps,
      data: this.prepareData(value.type, dataProps, collData),
      activeEntries: [],
      chartType: {...dashboardChartTypes.find(ct => ct.type === value.type)}, // disassemble and get first
      theme: value.isLightTheme ? 'light' : 'dark'
    };

    return dashChart;
  }

  instantiateDashboardChartFromRequest(value: ChartRequest, chartId: number, collData: CollectedData[]): DashboardChart {
    const chart: Chart = {
      id: chartId,
      ...value
    };

    return this.instantiateDashboardChart(chart, collData);
  }

  // dataSource - property to show on the chart
  prepareData(chartType: ChartType, dataSources: DataProperty[], dataToTransform: CollectedData[]): CustomData[] {
    if (!dataSources
      || (!chartType && chartType !== ChartType.BarVertical)
      || (!dataToTransform || dataToTransform.length < 1)) {
      return [];
    }
    if (chartType === ChartType.LineChart) {
      const data = this.mapToMultiData(dataToTransform, dataSources);
      for (let i = 0; i < data.length; i++) {
        data[i].series.sort((a, b) => date_sort_asc(a.name, b.name));
      }
      return data;
    } else {
      return this.mapToSeriesItem(dataToTransform[dataToTransform.length - 1], dataSources);
    }
  }

  // dataSource - property to show on the chart
  prepareProcessData(chartType: ChartType, dataSource: DataProperty, dataToTransform: CollectedData[], processesAmount = 0): CustomData[] {
    if (!dataSource
      || (!chartType && chartType !== ChartType.BarVertical)
      || (!dataToTransform || dataToTransform.length < 1)
      || processesAmount < 1) {
      return [];
    }
    if (chartType === ChartType.LineChart) {
      const data = this.mapToProcessMultiData(dataToTransform, dataSource, processesAmount);
      for (let i = 0; i < data.length; i++) {
        data[i].series.sort((a, b) => date_sort_asc(a.name, b.name));
      }
      return data;
    } else {
      return this.mapToProcessesSeriesItem(dataToTransform[dataToTransform.length - 1], dataSource, processesAmount);
    }
  }

  mapToMultiData(data: CollectedData[], properties: DataProperty[]): MultiChartItem[] {
    const items: MultiChartItem[] = [];
    for (let i = 0; i < properties.length; i++) {
      const item: MultiChartItem = {name: dataPropertyLables[properties[i]], series: []};
      item.series = data.map(p => this.mapToLineChartSeriesItem(p, properties[i]));
      items.push(item);
    }

    return items;
  }

  mapToProcessMultiData(data: CollectedData[], property: DataProperty, processesAmount: number = 1) {
    const items: MultiChartItem[] = [];
    for (let i = 0; i < processesAmount; i++) {
      const item: MultiChartItem = {name: data[data.length - 1].processes[i].name, series: []};
      item.series = data.map(d => this.mapToProcessesLineChartSeriesItem(d, i, property));
      items.push(item);
    }

    return items;
  }

  mapToProcessesSeriesItem(data: CollectedData, property: DataProperty, processesAmount: number = 1): NumberSeriesItem[] {
    debugger;
    const items: NumberSeriesItem[] = [];
    const stringProperty = DataProperty[property];
    data.processes.sort((a, b) => b[stringProperty] - a[stringProperty]); // sort by descending
    for (let i = 0; i < Math.min(data.processes.length, processesAmount); i++) {
      items.push(
        {
          name: data.processes[i].name,
          value: data.processes[i][stringProperty]
        });
    }

    let free = 100;
    for (let i = 0; i < data.processes.length; i++) {
      free -= data.processes[i][stringProperty];
    }
    let othersSum = 0;
    for (let i = processesAmount; i < data.processes.length; i++) {
      othersSum += data.processes[i][stringProperty];
    }
    items.push(
      {
        name: 'Others',
        value: othersSum
      });
    items.push(
      {
        name: 'Free',
        value: free
      });

    return items;
  }

  mapToSeriesItem(data: CollectedData, properties: DataProperty[]): NumberSeriesItem[] {
    const items: NumberSeriesItem[] = [];
    for (let i = 0; i < properties.length; i++) {
      items.push(
        {
          name: dataPropertyLables[properties[i]],
          value: data[DataProperty[properties[i]]]
        });
    }
    return items;
  }

  mapToProcessesLineChartSeriesItem(data: CollectedData, processIndex, property: DataProperty): SeriesItem {
    debugger;
    const seriesItem: SeriesItem = {
      value: data.processes[processIndex][DataProperty[property]],
      name: new Date(data.time)
    };

    return seriesItem;
  }

  mapToLineChartSeriesItem(data: CollectedData, property: DataProperty): SeriesItem {
    const seriesItem: SeriesItem = {
      value: data[DataProperty[property]],
      name: new Date(data.time)
    };

    return seriesItem;
  }

  prepareDataTick(chartToUpdate: DashboardChart, newData: CollectedData): CustomData[] {
    if (!newData) {
      return chartToUpdate.data ? chartToUpdate.data : [];
    }

    if (chartToUpdate.chartType.type === ChartType.LineChart) {
      return this.mapToMultiDataOnUpdate(chartToUpdate.data, newData, chartToUpdate.dataSources);
    } else {
      return this.mapToSeriesItem(newData, chartToUpdate.dataSources);
    }
  }

  mapToMultiDataOnUpdate(oldData: CustomData[], newData: CollectedData, properties: DataProperty[]): CustomData[] {
    if (oldData[0].series.length > 20) { // TODO: refactor
      for (let i = 0; i < oldData.length; i++) {
        // oldData.push(oldData.slice(1)); // Start from first element(removes oldest data el)
        oldData[i].series.shift();
      }
      // TODO: remove oldest element from array - use order by or sort or smt coz data can be not ordered by date
      // TODO: maybe depend on chart's setting get from old array specific amount of data or etc.
    }
    const newDataToPush = this.mapToMultiData([newData], properties);
    for (let i = 0; i < properties.length; i++) {
      oldData[i].series.push(...newDataToPush[i].series);
    }

    return oldData;
  }
}
