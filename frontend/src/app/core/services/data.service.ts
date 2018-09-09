import {Injectable} from '@angular/core';
import {CustomData, date_sort_asc} from '../../dashboards/charts/models';
import {CollectedData} from '../../shared/models/collected-data.model';
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
  constructor() {
  }

  convertStringToArrEnum(sources: string): DataProperty[] {
    const array: DataProperty[] = [];
    const arrNumbers = sources.split(',');

    for (let i = 0; i < arrNumbers.length; i++) {
      array.push(+arrNumbers[i]);
    }

    return array;
  }

  instantiateDashboardChart(value: Chart, collData: CollectedData[]): DashboardChart {
    const dataProps = this.convertStringToArrEnum(value.sources);
    let chartData = [];
    if (value.showCommon) {
      chartData = this.prepareData(value.type, dataProps, collData);
    } else {
      chartData = this.prepareProcessData(value.type, dataProps[0], collData, value.mostLoaded);
    }
    const dashChart: DashboardChart = {
      view: [600, 300],
      id: value.id,
      showCommon: value.showCommon,
      threshold: value.threshold,
      mostLoaded: value.mostLoaded,
      colorScheme: {...colorSets.find(s => s.name === value.schemeType)}, // {...defaultOptions.colorScheme},
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
      data: chartData,
      activeEntries: [],
      colectedData: {} as CollectedData,
      type: value.type,
      theme: value.isLightTheme ? 'light' : 'dark',
    };

    return dashChart;
  }

  instantiateDashboardChartFromRequest(value: ChartRequest, chartId: number, collData: CollectedData[]): DashboardChart {
    const chart: Chart = {
      id: chartId,
      ...value,
      scheme: {...colorSets.find(s => s.name === value.schemeType)}
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

    switch (chartType) {
      case ChartType.LineChart:
        const data = this.mapToMultiData(dataToTransform, dataSources);
        for (let i = 0; i < data.length; i++) {
          data[i].series.sort((a, b) => date_sort_asc(a.name, b.name));
        }
        return data;
      case ChartType.Pie:
        return this.mapToPieSeriesItem(dataToTransform[dataToTransform.length - 1], dataSources[0]);
      default:
        return this.mapToSeriesItem(dataToTransform[dataToTransform.length - 1], dataSources);
    }
  }

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
    const stringProperty = DataProperty[property];
    const lastData = data[data.length - 1];
    lastData.processes.sort((a, b) => b[stringProperty] - a[stringProperty]); // sort by descending
    const topProcessesNames: string[] = [];
    for (let i = 0; i < processesAmount; i++) {
      topProcessesNames.push(lastData.processes[i].name);
    }
    for (let i = 0; i < processesAmount; i++) {
      const pName = topProcessesNames[i];
      const item: MultiChartItem = {name: pName, series: []}; // {name: data[data.length - 1].processes[i].name, series: []};
      item.series = data.map(d => this.mapToProcessesLineChartSeriesItem(d, pName, stringProperty));
      items.push(item);
    }

    return items;
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

  mapToLineChartSeriesItem(data: CollectedData, property: DataProperty): SeriesItem {
    const seriesItem: SeriesItem = {
      value: data[DataProperty[property]],
      name: new Date(data.time)
    };

    return seriesItem;
  }

  // TODO: change to swithch
  prepareDataTick(chartToUpdate: DashboardChart, newData: CollectedData): CustomData[] {
    if (!newData) {
      return chartToUpdate.data ? chartToUpdate.data : [];
    }

    if (chartToUpdate.showCommon) {
      switch (chartToUpdate.type) {
        case ChartType.LineChart:
          return this.mapToMultiDataOnUpdate(chartToUpdate.data, newData, chartToUpdate.dataSources);
        case ChartType.Pie:
          return this.mapToPieSeriesItem(newData, chartToUpdate.dataSources[0]);
        default:
          return this.mapToSeriesItem(newData, chartToUpdate.dataSources);
      }
    } else {
      if (chartToUpdate.type === ChartType.LineChart) {
        return this.mapToProcessMultiDataOnUpdate(chartToUpdate.data, newData, chartToUpdate.dataSources[0], chartToUpdate.mostLoaded);
      } else {
        return this.mapToProcessesSeriesItem(newData, chartToUpdate.dataSources[0], chartToUpdate.mostLoaded);
      }
    }
  }

  mapToProcessMultiDataOnUpdate(oldData: CustomData[],
                                newData: CollectedData,
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

    const processes = this.getMostLoadedProcesses(newData, prop, procAmount);

    const newDataToPush = this.mapToProcessMultiData([newData], property, procAmount);
    for (let i = 0; i < procAmount; i++) {
      oldData[i].series.push(...newDataToPush[i].series);
    }

    return oldData;
  }

  getMostLoadedProcesses(data: CollectedData, stringProperty: string, procAmount: number = 1): string[] {
    data.processes.sort((a, b) => b[stringProperty] - a[stringProperty]); // sort by descending
    const topProcessesNames: string[] = [];
    for (let i = 0; i < procAmount; i++) {
      topProcessesNames.push(data.processes[i].name);
    }

    return topProcessesNames;
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
