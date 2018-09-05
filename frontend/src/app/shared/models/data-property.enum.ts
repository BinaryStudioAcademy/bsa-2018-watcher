import {ProperiesMap} from './map';

export enum DataProperty {
  id = 0,
  clientId,
  collectedDataType,
  processesCount,
  processes,
  cpuUsagePercentage,
  usageRamMBytes,
  totalRamMBytes,
  ramUsagePercentage,
  interruptsPerSeconds,
  localDiskUsageMBytes,
  localDiskTotalMBytes,
  localDiskUsagePercentage,
  time,
}

export enum ProcessDataProperty {
  name,
  ramMBytes,
  pRam,
  pCpu
}

export const processDataPropertyLables: ProperiesMap<string> = {};
processDataPropertyLables[ProcessDataProperty.name] = 'Name';
processDataPropertyLables[ProcessDataProperty.ramMBytes] = 'Ram usage MegaBytes';
processDataPropertyLables[ProcessDataProperty.pRam] = 'Ram usage %';
processDataPropertyLables[ProcessDataProperty.pCpu] = 'Сpu usage %';

export const dataPropertyLables: ProperiesMap<string> = {};
dataPropertyLables[DataProperty.id] = 'Id';
dataPropertyLables[DataProperty.clientId] = 'Instance Id';
dataPropertyLables[DataProperty.collectedDataType] = 'Collected data type';
dataPropertyLables[DataProperty.processesCount] = '# of Processes';
dataPropertyLables[DataProperty.processes] = 'Processes';
dataPropertyLables[DataProperty.cpuUsagePercentage] = 'Сpu usage %';
dataPropertyLables[DataProperty.usageRamMBytes] = 'Ram usage MegaBytes';
dataPropertyLables[DataProperty.totalRamMBytes] = 'Total Ram MegaBytes';
dataPropertyLables[DataProperty.ramUsagePercentage] = 'Ram usage %';
dataPropertyLables[DataProperty.interruptsPerSeconds] = '# of interrupts per second';
dataPropertyLables[DataProperty.localDiskUsageMBytes] = 'Disc usage MegaBytes';
dataPropertyLables[DataProperty.localDiskTotalMBytes] = 'Total Disc MegaBytes';
dataPropertyLables[DataProperty.localDiskUsagePercentage] = 'Disc usage %';
dataPropertyLables[DataProperty.time] = 'Time';
