import {ProperiesMap} from './map';
import {CollectedDataType} from './collected-data-type.enum';
import {ProcessData} from './process-data.model';

export enum DataProperty {
  // time = 0,
  // processesCount,
  // processesCPU,
  // processesRAM,
  // cpuUsagePercent,
  // ramUsagePercent,
  // interruptsTimePercent,
  // localDiskFreeSpacePercent,
  // avaliableRamBytes,
  // interruptsPerSeconds,
  // localDiskFreeMBytes,
  //

  id = 0,
  clientId,
  collectedDataType,
  processesCount,
  processes,
  cpuUsagePercentage,
  freeRamMBytes,
  totalRamMBytes,
  ramUsagePercentage,
  interruptsPerSeconds,
  localDiskFreeMBytes,
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

// export const dataProperties: ProperiesMap<string> = {};
// dataProperties[DataProperty.time] = 'time';
// dataProperties[DataProperty.processesCount] = 'processesCount';
// dataProperties[DataProperty.processesCPU] = 'processesCPU';
// dataProperties[DataProperty.processesRAM] = 'processesRAM';
// dataProperties[DataProperty.cpuUsagePercent] = 'cpuUsagePercent';
// dataProperties[DataProperty.ramUsagePercent] = 'ramUsagePercent';
// dataProperties[DataProperty.interruptsTimePercent] = 'interruptsTimePercent';
// dataProperties[DataProperty.localDiskFreeSpacePercent] = 'localDiskFreeSpacePercent';
// dataProperties[DataProperty.avaliableRamBytes] = 'avaliableRamBytes';
// dataProperties[DataProperty.interruptsPerSeconds] = 'interruptsPerSeconds';
// dataProperties[DataProperty.localDiskFreeMBytes] = 'localDiskFreeMByte';

export const dataPropertyLables: ProperiesMap<string> = {};
dataPropertyLables[DataProperty.id] = 'Id';
dataPropertyLables[DataProperty.clientId] = 'Instance Id';
dataPropertyLables[DataProperty.collectedDataType] = 'Collected data type';
dataPropertyLables[DataProperty.processesCount] = '# of Processes';
dataPropertyLables[DataProperty.processes] = 'Processes';
dataPropertyLables[DataProperty.cpuUsagePercentage] = 'Сpu usage %';
dataPropertyLables[DataProperty.freeRamMBytes] = 'Free Ram MegaBytes';
dataPropertyLables[DataProperty.totalRamMBytes] = 'Total Ram MegaBytes';
dataPropertyLables[DataProperty.ramUsagePercentage] = 'Ram usage %';
dataPropertyLables[DataProperty.interruptsPerSeconds] = '# of interrupts per second';
dataPropertyLables[DataProperty.localDiskFreeMBytes] = 'Free Disc MegaBytes';
dataPropertyLables[DataProperty.localDiskTotalMBytes] = 'Total Disc MegaBytes';
dataPropertyLables[DataProperty.localDiskUsagePercentage] = 'Disc usage %';
dataPropertyLables[DataProperty.time] = 'Time';

// dataPropertyLables[DataProperty.interruptsPerSeconds] = '# of interrupts per second';
// dataPropertyLables[DataProperty.localDiskFreeMBytes] = '# of free MB disc';
// dataPropertyLables[DataProperty.time] = 'Time';
// dataPropertyLables[DataProperty.processesCPU] = 'Process CPU usage';
// dataPropertyLables[DataProperty.processesRAM] = 'Process RAM usage';
// dataPropertyLables[DataProperty.cpuUsagePercent] = 'CPU usage %';
// dataPropertyLables[DataProperty.ramUsagePercent] = 'RAM usage %';
// dataPropertyLables[DataProperty.interruptsTimePercent] = 'Interrupts usage %';
// dataPropertyLables[DataProperty.localDiskFreeSpacePercent] = 'Disc usage %';
// dataPropertyLables[DataProperty.avaliableRamBytes] = '# of avaliable bytes RAM';
// dataPropertyLables[DataProperty.localDiskFreeMBytes] = '# of free MB disc';
