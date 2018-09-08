import {ProperiesMap} from './map';

export enum ChartType {
    BarVertical = 0,
    LineChart,
    Pie,
    Guage,
    ResourcesTable
}

export const chartTypes: ProperiesMap<string> = {};
chartTypes[ChartType.BarVertical] = 'bar-vertical';
chartTypes[ChartType.LineChart] = 'line-chart';
chartTypes[ChartType.Pie] = 'pie';
chartTypes[ChartType.Guage] = 'guage';
chartTypes[ChartType.ResourcesTable] = 'resources-table';
