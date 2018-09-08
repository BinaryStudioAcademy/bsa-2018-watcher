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
import {colorSets} from '@swimlane/ngx-charts/release/utils';

@Injectable()
export class DataService {
  // Collected data with interval of 10-15 seconds for last hour
  private _hourlyCollectedData: CollectedData[] = [];

  set hourlyCollectedData(data: CollectedData[]) {
    this._hourlyCollectedData = data || [];
  }

  get hourlyCollectedData(): CollectedData[] {
    return this._hourlyCollectedData;
  }

  get latestCollectedData(): CollectedData {
    if (this._hourlyCollectedData && this._hourlyCollectedData.length) {
      return this._hourlyCollectedData[this._hourlyCollectedData.length - 1];
    } else {
      return null; // TODO: return default value with 0 or
    }
  }

  constructor() {
  }

  fulfillChart(chart: DashboardChart): boolean {
    let chartData: CustomData[] = [];

    if (!chart.dataSources || chart.dataSources.length < 1) {
      chart.data = chartData;
      return false;
    }

    if (chart.showCommon) {
      switch (chart.chartType.type) {
        case ChartType.LineChart:
          const data = this.mapToMultiData(this._hourlyCollectedData, chart.dataSources);
          for (let i = 0; i < data.length; i++) {
            data[i].series.sort((a, b) => date_sort_asc(a.name, b.name));
          }
          chartData = data;
          break;
        case ChartType.Pie:
          chartData = this.mapToPieSeriesItem(this.getFirstSource(chart.dataSources));
          break;
        default:
          chartData = this.mapToSeriesItem(chart.dataSources);
          break;
      }
    } else {
      switch (chart.chartType.type) {
        case ChartType.LineChart:
          const data = this.mapToProcessMultiData(this.getFirstSource(chart.dataSources), chart.mostLoaded);
          for (let i = 0; i < data.length; i++) {
            data[i].series.sort((a, b) => date_sort_asc(a.name, b.name));
          }
          chartData = data;
          break;
        case ChartType.Pie:
          chartData = this.mapToProcessesSeriesItem(this.getFirstSource(chart.dataSources), chart.mostLoaded);
          break;
        default:
          chartData = this.mapToProcessesSeriesItem(this.getFirstSource(chart.dataSources), chart.mostLoaded);
          break;
      }
    }

    return true;
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

  mapToProcessMultiData(property: DataProperty, processesAmount: number = 1) {
    const items: MultiChartItem[] = [];
    const stringProperty = DataProperty[property];
    this.latestCollectedData.processes.sort((a, b) => b[stringProperty] - a[stringProperty]); // sort by descending
    const topProcessesNames: string[] = [];
    for (let i = 0; i < processesAmount; i++) {
      topProcessesNames.push(this.latestCollectedData.processes[i].name);
    }
    for (let i = 0; i < processesAmount; i++) {
      const pName = topProcessesNames[i];
      const item: MultiChartItem = {name: pName, series: []}; // {name: data[data.length - 1].processes[i].name, series: []};
      item.series = this._hourlyCollectedData.map(d => this.mapToProcessesLineChartSeriesItem(d, pName, stringProperty));
      items.push(item);
    }

    return items;
  }

  mapToProcessesSeriesItem(property: DataProperty, processesAmount: number = 1): NumberSeriesItem[] {
    const items: NumberSeriesItem[] = [];
    const stringProperty = DataProperty[property];
    this.latestCollectedData.processes.sort((a, b) => b[stringProperty] - a[stringProperty]); // sort by descending
    for (let i = 0; i < Math.min(this.latestCollectedData.processes.length, processesAmount); i++) {
      items.push(
        {
          name: this.latestCollectedData.processes[i].name,
          value: this.latestCollectedData.processes[i][stringProperty]
        });
    }

    let free = 100;
    for (let i = 0; i < this.latestCollectedData.processes.length; i++) {
      free -= this.latestCollectedData.processes[i][stringProperty];
    }
    let othersSum = 0;
    for (let i = processesAmount; i < this.latestCollectedData.processes.length; i++) {
      othersSum += this.latestCollectedData.processes[i][stringProperty];
    }
    if (free < 0) {
      free = 0;
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

  mapToSeriesItem(properties: DataProperty[]): NumberSeriesItem[] {
    const items: NumberSeriesItem[] = [];
    for (let i = 0; i < properties.length; i++) {
      items.push(
        {
          name: dataPropertyLables[properties[i]],
          value: this.latestCollectedData[DataProperty[properties[i]]]
        });
    }
    return items;
  }

  mapToProcessesLineChartSeriesItem(data: CollectedData, processName: string, property: string): SeriesItem {
    const process = data.processes.find((value, index, obj) => {
      return value.name === processName;
    });
    const seriesItem: SeriesItem = {
      value: 0, // data.processes[processIndex][DataProperty[property]],
      name: new Date(data.time)
    };

    if (process) {
      seriesItem.value = process[property];
    }

    return seriesItem;
  }

  // UPDATE
  updateChartWithLatestData(chartToUpdate: DashboardChart): boolean {
    if (!this.latestCollectedData) {
      return false; // Update was unsuccessful
      // return chartToUpdate.data ? chartToUpdate.data : [];
    }

    let chartData: CustomData[] = [];
    if (chartToUpdate.showCommon) {
      switch (chartToUpdate.chartType.type) {
        case ChartType.LineChart:
          chartData = this.mapToMultiDataOnUpdate(chartToUpdate.data, this.latestCollectedData, chartToUpdate.dataSources);
          break;
        case ChartType.Pie:
          chartData = this.mapToPieSeriesItem(chartToUpdate.dataSources[0]);
          break;
        default:
          chartData = this.mapToSeriesItem(chartToUpdate.dataSources);
          break;
      }
    } else {
      const source = this.getFirstSource(chartToUpdate.dataSources);
      switch (chartToUpdate.chartType.type) {
        case ChartType.LineChart:
          chartData = this.mapToProcessMultiDataOnUpdate(chartToUpdate.data, source, chartToUpdate.mostLoaded);
          break;
        case ChartType.Pie:
          chartData = this.mapToProcessesSeriesItem(source, chartToUpdate.mostLoaded);
          break;
        default:
          chartData = this.mapToProcessesSeriesItem(source, chartToUpdate.mostLoaded);
          break;
      }
    }

    chartToUpdate.data = chartData; // [...tempData];
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
  mapToProcessMultiDataOnUpdate(oldData: CustomData[],
                                property: DataProperty,
                                procAmount: number = 1): CustomData[] {
    const prop = DataProperty[property];
    if (oldData[0].series.length > 20) { // TODO: refactor
      for (let i = 0; i < oldData.length; i++) {
        // oldData.push(oldData.slice(1)); // Start from first element(removes oldest data el)
        oldData[i].series.shift();
      }
      // TODO: remove oldest element from array - use order by or sort or smt coz data can be not ordered by date
      // TODO: maybe depend on chart's setting get from old array specific amount of data or etc.
    }

    const processes = this.getMostLoadedProcesses(prop, procAmount);

    const newDataToPush = this.mapToProcessMultiData(property, procAmount);
    for (let i = 0; i < procAmount; i++) {
      oldData[i].series.push(...newDataToPush[i].series);
    }

    return oldData;
  }


  // PIE
  mapToPieSeriesItem(prop: DataProperty): NumberSeriesItem[] {
    const items: NumberSeriesItem[] = [];
    const propStr = DataProperty[prop];
    items.push(
      {
        name: dataPropertyLables[prop],
        value: this.latestCollectedData[propStr]
      });

    let itemName = '';
    let itemValue = 0;
    switch (prop) {
      case DataProperty.cpuUsagePercentage:
      case DataProperty.ramUsagePercentage:
      case DataProperty.localDiskUsagePercentage:
        itemName = 'Available';
        itemValue = 100;
        break;
      case DataProperty.usageRamMBytes:
        itemName = 'Free Ram MegaBytes';
        itemValue = this.latestCollectedData[DataProperty[DataProperty.totalRamMBytes]];
        break;
      case DataProperty.localDiskUsageMBytes:
        itemName = 'Free Local Disc MegaBytes';
        itemValue = this.latestCollectedData[DataProperty[DataProperty.localDiskTotalMBytes]];
        break;
      default:
    }

    items.push(
      {
        name: itemName,
        value: itemValue - this.latestCollectedData[propStr]
      });

    return items;
  }


  // HELPERS
  getMostLoadedProcesses(stringProperty: string, procAmount: number = 1): string[] {
    this.latestCollectedData.processes.sort((a, b) => b[stringProperty] - a[stringProperty]); // sort by descending
    const topProcessesNames: string[] = [];
    for (let i = 0; i < procAmount; i++) {
      topProcessesNames.push(this.latestCollectedData.processes[i].name);
    }

    return topProcessesNames;
  }

  instantiateDashboardChart(value: Chart): DashboardChart {
    const dataProps = this.convertStringToArrEnum(value.sources);
    const dashChart: DashboardChart = {
      view: [600, 300],
      id: value.id,
      showCommon: value.showCommon,
      threshold: value.threshold,
      mostLoaded: value.mostLoaded,
      colorScheme: {...colorSets.find(s => s.name === value.schemeType)},
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
      data: [],
      activeEntries: [],
      chartType: {...dashboardChartTypes.find(ct => ct.type === value.type)}, // disassemble and get first
      theme: value.isLightTheme ? 'light' : 'dark'
    };

    this.fulfillChart(dashChart);
    // let chartData = [];
    // if (value.showCommon) {
    //   chartData = this.prepareData(value.type, dataProps, collData);
    // } else {
    //   chartData = this.prepareProcessData(value.type, dataProps[0], collData, value.mostLoaded);
    // }

    return dashChart;
  }

  instantiateDashboardChartFromRequest(value: ChartRequest, chartId: number): DashboardChart {
    const chart: Chart = {
      id: chartId,
      ...value,
      scheme: {...colorSets.find(s => s.name === value.schemeType)}
    };

    return this.instantiateDashboardChart(chart);
  }

  mapToLineChartSeriesItem(data: CollectedData, property: DataProperty): SeriesItem {
    const seriesItem: SeriesItem = {
      value: data[DataProperty[property]],
      name: new Date(data.time)
    };

    return seriesItem;
  }

  getFirstSource(sources: DataProperty[]): DataProperty {
    if (sources && sources.length > 0) {
      return sources[0];
    } else {
      return DataProperty.id;
    }
  }

  pushLatestCollectedData(latestData: CollectedData) {
    // this.collectedDataForChart = this.collectedDataForChart || [];
    // TODO: check current array on size to remove super old useless data elements
    // TODO: use this operation only for current dashboard and then on switching dashboard make data preparing on existing
    // collectedDataForChart to reduce amount of operations and time
    // TODO: filter all data that younger than 1 hour and push there this data
    this._hourlyCollectedData.push(latestData);
  }

  convertStringToArrEnum(sources: string): DataProperty[] {
    const array: DataProperty[] = [];
    const arrNumbers = sources.split(',');

    for (let i = 0; i < arrNumbers.length; i++) {
      array.push(+arrNumbers[i]);
    }

    return array;
  }
}
