import {Injectable} from '@angular/core';
import {CustomData} from '../../dashboards/charts/models';

import {CollectedData, defaultCollectedData} from '../../shared/models/collected-data.model';
import {NumberSeriesItem, SeriesItem} from '../../dashboards/models/series-item';
import {MultiChartItem} from '../../dashboards/models/multi-chart-item';
import {DataProperty, dataPropertyLables} from '../../shared/models/data-property.enum';
import {ChartType} from '../../shared/models/chart-type.enum';
import {Chart} from '../../shared/models/chart.model';
import {DashboardChart} from '../../dashboards/models/dashboard-chart';
import {defaultOptions} from '../../dashboards/charts/models/chart-options';
import {ChartRequest} from '../../shared/requests/chart-request.model';
import {colorSets} from '@swimlane/ngx-charts/release/utils';

@Injectable()
export class DataService {
  // Collected data with interval of 10-15 seconds for last hour
  private _hourlyCollectedData: CollectedData[] = [];
  private _fakeCollectedData: CollectedData[] = [];

  set fakeCollectedData(data: CollectedData[]) {
    this._fakeCollectedData = data || [];
  }

  get fakeCollectedData(): CollectedData[] {
    return this._fakeCollectedData;
  }

  set hourlyCollectedData(data: CollectedData[]) {
    this._hourlyCollectedData = data || [];
  }

  get hourlyCollectedData(): CollectedData[] {
    return this._hourlyCollectedData;
  }

  getLastCollectedData(dataArr: CollectedData[]): CollectedData {
    if (dataArr && dataArr.length) {
      return dataArr[dataArr.length - 1];
    } else {
      return defaultCollectedData; // TODO: return default value with 0 or
    }
  }

  constructor() {
  }

  fulfillChart(dataArr: CollectedData[], chart: DashboardChart, isFake: boolean = false): boolean {
    let chartData: CustomData[] = [];

    if (!chart.dataSources || chart.dataSources.length < 1) {
      chart.data = chartData;
      return false;
    }

    if (chart.showCommon) {
      switch (chart.type) {
        case ChartType.LineChart:
        case ChartType.BarHorizontal2D:
        case ChartType.BarHorizontalNormalized:
        case ChartType.BarHorizontalStacked:
        case ChartType.BarVertical2D:
        case ChartType.BarVerticalNormalized:
        case ChartType.BarVerticalStacked:
        case ChartType.PolarChart:
        case ChartType.AreaChart:
        case ChartType.AreaChartNormalized:
        case ChartType.AreaChartStacked:
        case ChartType.HeatMap:
          let filteredData: CollectedData[] = [];
          if (isFake) {
            filteredData = dataArr;
          } else {
            filteredData = this.getDataByMinutes(dataArr, chart.historyTime);
          }
          chartData = this.mapToMultiData(filteredData, chart.dataSources);
          break;
        case ChartType.Pie:
          chartData = this.mapToPieSeriesItem(this.getLastCollectedData(dataArr), this.getFirstSource(chart.dataSources));
          break;
        default:
          chartData = this.mapToSeriesItem(this.getLastCollectedData(dataArr), chart.dataSources);
          break;
      }
    } else {
      switch (chart.type) {
        case ChartType.LineChart:
        case ChartType.BarHorizontal2D:
        case ChartType.BarHorizontalNormalized:
        case ChartType.BarHorizontalStacked:
        case ChartType.BarVertical2D:
        case ChartType.BarVerticalNormalized:
        case ChartType.BarVerticalStacked:
        case ChartType.PolarChart:
        case ChartType.AreaChart:
        case ChartType.AreaChartNormalized:
        case ChartType.AreaChartStacked:
        case ChartType.HeatMap:
          let filteredData: CollectedData[] = [];
          if (isFake) {
            filteredData = dataArr;
          } else {
            filteredData = this.getDataByMinutes(dataArr, chart.historyTime);
          }
          chartData = this.mapToProcessMultiData(filteredData, this.getFirstSource(chart.dataSources), chart.mostLoaded);
          break;
        case ChartType.Pie:
          chartData = this.mapToProcessesSeriesItem(this.getLastCollectedData(dataArr),
            this.getFirstSource(chart.dataSources), chart.mostLoaded);
          break;
        default:
          chartData = this.mapToProcessesSeriesItem(this.getLastCollectedData(dataArr),
            this.getFirstSource(chart.dataSources), chart.mostLoaded);
          break;
      }
    }


    if (chartData && chartData.length > 0) {
      chart.data = chartData;
      return true;
    } else {
      chart.data = [];
      return true;
    }
  }

  mapToMultiData(dataArr: CollectedData[], properties: DataProperty[]): MultiChartItem[] {
    const items: MultiChartItem[] = [];
    for (let i = 0; i < properties.length; i++) {
      const item: MultiChartItem = {name: dataPropertyLables[properties[i]], series: []};
      item.series = dataArr.map(p => this.mapToLineChartSeriesItem(p, properties[i]));
      items.push(item);
    }

    return items;
  }


  mapToProcessMultiData(dataArr: CollectedData[], property: DataProperty, processesAmount: number = 1) {
    const items: MultiChartItem[] = [];
    const stringProperty = DataProperty[property];
    const latestData = this.getLastCollectedData(dataArr);
    latestData.processes.sort((a, b) => b[stringProperty] - a[stringProperty]); // sort by descending
    for (let i = 0; i < Math.min(processesAmount, latestData.processes.length); i++) {
      const pName = latestData.processes[i].name;
      const item: MultiChartItem = {name: pName, series: []};
      item.series = dataArr.map(d => this.mapToProcessesLineChartSeriesItem(d, pName, stringProperty));
      items.push(item);
    }

    return items;
  }

  getDataByMinutes(dataArr: CollectedData[], minutes: number = 5) {
    const minutesAgo = new Date(Date.now() - minutes * 60000);
    return dataArr.filter(value => value.time > minutesAgo);
  }

  mapToProcessesSeriesItem(data: CollectedData, property: DataProperty, processesAmount: number = 1): NumberSeriesItem[] {
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

  // PIE
  mapToPieSeriesItem(data: CollectedData, prop: DataProperty): NumberSeriesItem[] {
    const items: NumberSeriesItem[] = [];
    const propStr = DataProperty[prop];
    items.push(
      {
        name: dataPropertyLables[prop],
        value: data[propStr]
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
        itemValue = data[DataProperty[DataProperty.totalRamMBytes]];
        break;
      case DataProperty.localDiskUsageMBytes:
        itemName = 'Free Local Disc MegaBytes';
        itemValue = data[DataProperty[DataProperty.localDiskTotalMBytes]];
        break;
      default:
    }

    items.push(
      {
        name: itemName,
        value: itemValue - data[propStr]
      });

    return items;
  }


  // HELPERS
  getMostLoadedProcesses(data: CollectedData, stringProperty: string, procAmount: number = 1): string[] {
    data.processes.sort((a, b) => b[stringProperty] - a[stringProperty]); // sort by descending
    const topProcessesNames: string[] = [];
    for (let i = 0; i < procAmount; i++) {
      topProcessesNames.push(data.processes[i].name);
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
      historyTime: value.historyTime,
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
      colectedData: {} as CollectedData,
      type: value.type,
      theme: value.isLightTheme ? 'light' : 'dark',
      isIncluded: false,
      dateTickFormatting: null
    };

    this.fulfillChart(this._hourlyCollectedData, dashChart);
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
    // Filter all data that younger than 1 hour and push there this data
    const hourAgo = new Date(Date.now() - 60 * 60000);
    this._hourlyCollectedData = [...this._hourlyCollectedData.filter(value => value.time > hourAgo), latestData];
  }

  convertStringToArrEnum(sources: string): DataProperty[] {
    const array: DataProperty[] = [];
    const arrNumbers = sources.split(',');

    for (let i = 0; i < arrNumbers.length; i++) {
      array.push(+arrNumbers[i]);
    }

    return array;
  }



  // UPDATE
  // updateChartWithLatestData(chartToUpdate: DashboardChart): boolean {
  //   const latestData = this.getLastCollectedData(this._hourlyCollectedData);
  //   if (!latestData) {
  //     return false; // Update was unsuccessful
  //     // return chartToUpdate.data ? chartToUpdate.data : [];
  //   }
  //
  //   let chartData: CustomData[] = [];
  //   if (chartToUpdate.showCommon) {
  //     switch (chartToUpdate.type) {
  //       case ChartType.LineChart:
  //       case ChartType.BarHorizontal2D:
  //       case ChartType.BarHorizontalNormalized:
  //       case ChartType.BarHorizontalStacked:
  //       case ChartType.BarVertical2D:
  //       case ChartType.BarVerticalNormalized:
  //       case ChartType.BarVerticalStacked:
  //       case ChartType.PolarChart:
  //       case ChartType.AreaChart:
  //       case ChartType.AreaChartNormalized:
  //       case ChartType.AreaChartStacked:
  //       case ChartType.HeatMap:
  //         chartData = this.mapToMultiData(this._hourlyCollectedData, chartToUpdate.dataSources);
  //         break;
  //       case ChartType.Pie:
  //         chartData = this.mapToPieSeriesItem(latestData, this.getFirstSource(chartToUpdate.dataSources));
  //         break;
  //       default:
  //         chartData = this.mapToSeriesItem(latestData, chartToUpdate.dataSources);
  //         break;
  //     }
  //   } else {
  //     const source = this.getFirstSource(chartToUpdate.dataSources);
  //     switch (chartToUpdate.type) {
  //       case ChartType.LineChart:
  //       case ChartType.BarHorizontal2D:
  //       case ChartType.BarHorizontalNormalized:
  //       case ChartType.BarHorizontalStacked:
  //       case ChartType.BarVertical2D:
  //       case ChartType.BarVerticalNormalized:
  //       case ChartType.BarVerticalStacked:
  //       case ChartType.PolarChart:
  //       case ChartType.AreaChart:
  //       case ChartType.AreaChartNormalized:
  //       case ChartType.AreaChartStacked:
  //       case ChartType.HeatMap:
  //
  //         chartData = this.mapToProcessMultiData(chartToUpdate.data, source, chartToUpdate.mostLoaded);
  //         // chartData = this.mapToProcessMultiDataOnUpdate(chartToUpdate.data, source, chartToUpdate.mostLoaded);
  //         break;
  //       case ChartType.Pie:
  //         chartData = this.mapToProcessesSeriesItem(latestData, source, chartToUpdate.mostLoaded);
  //         break;
  //       default:
  //         chartData = this.mapToProcessesSeriesItem(latestData, source, chartToUpdate.mostLoaded);
  //         break;
  //     }
  //   }
  //
  //   chartToUpdate.data = chartData; // [...tempData];
  // }

  // mapToMultiDataOnUpdate(oldData: CustomData[], newData: CollectedData, properties: DataProperty[], minutes: number): CustomData[] {
  //   const minutesAgo = new Date(Date.now() - minutes * 60000);
  //   // const dataForLast10Minutes = dataArr.filter(value => value.time > fiveMinAgo);
  //
  //   if (oldData[0].series.length > 20) { // TODO: refactor
  //     for (let i = 0; i < oldData.length; i++) {
  //       // oldData.push(oldData.slice(1)); // Start from first element(removes oldest data el)
  //       oldData[i].series.shift();
  //     }
  //     // TODO: remove oldest element from array - use order by or sort or smt coz data can be not ordered by date
  //     // TODO: maybe depend on chart's setting get from old array specific amount of data or etc.
  //   }
  //   const newDataToPush = this.mapToMultiData([newData], properties);
  //   for (let i = 0; i < properties.length; i++) {
  //     oldData[i].series.push(...newDataToPush[i].series);
  //   }
  //
  //   return oldData;
  // }
  //
  // mapToProcessMultiDataOnUpdate(oldData: CustomData[],
  //                               property: DataProperty,
  //                               procAmount: number = 1): CustomData[] {
  //   const prop = DataProperty[property];
  //   if (oldData[0].series.length > 20) { // TODO: refactor
  //     for (let i = 0; i < oldData.length; i++) {
  //       // oldData.push(oldData.slice(1)); // Start from first element(removes oldest data el)
  //       oldData[i].series.shift();
  //     }
  //     // TODO: remove oldest element from array - use order by or sort or smt coz data can be not ordered by date
  //     // TODO: maybe depend on chart's setting get from old array specific amount of data or etc.
  //   }
  //
  //   const processes = this.getMostLoadedProcesses(this.getLastCollectedData(this._hourlyCollectedData), prop, procAmount);
  //
  //   const newDataToPush = this.mapToProcessMultiData(this._hourlyCollectedData, property, procAmount);
  //   for (let i = 0; i < procAmount; i++) {
  //     oldData[i].series.push(...newDataToPush[i].series);
  //   }
  //
  //   return oldData;
  // }
}
