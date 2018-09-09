import {ProperiesMap} from './map';

export enum ChartType {
    BarVertical = 0,
    LineChart,
    Pie,
    Guage,
    NumberCards,
    ResourcesTable
}

export const chartTypeLabels: ProperiesMap<string> = {};
chartTypeLabels[ChartType.BarVertical] = 'Bar Vertical';
chartTypeLabels[ChartType.LineChart] = 'Line Chart';
chartTypeLabels[ChartType.Pie] = 'Pie';
chartTypeLabels[ChartType.Guage] = 'Guage';
chartTypeLabels[ChartType.NumberCards] = 'Number Cards';
chartTypeLabels[ChartType.ResourcesTable] = 'Resources Table';
