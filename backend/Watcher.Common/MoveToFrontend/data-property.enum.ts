import {ProperiesMap} from './map';

export enum DataProperty {
  time = 0,
  processesCount,
  processesCPU,
  processesRAM,
  cpuUsagePercent,
  ramUsagePercent,
  interruptsTimePercent,
  localDiskFreeSpacePercent,
  avaliableRamBytes,
  interruptsPerSeconds,
  localDiskFreeMBytes
}

export const dataProperties: ProperiesMap<string> = {};
dataProperties[DataProperty.time] = 'time';
dataProperties[DataProperty.processesCount] = 'processesCount';
dataProperties[DataProperty.processesCPU] = 'processesCPU';
dataProperties[DataProperty.processesRAM] = 'processesRAM';
dataProperties[DataProperty.cpuUsagePercent] = 'cpuUsagePercent';
dataProperties[DataProperty.ramUsagePercent] = 'ramUsagePercent';
dataProperties[DataProperty.interruptsTimePercent] = 'interruptsTimePercent';
dataProperties[DataProperty.localDiskFreeSpacePercent] = 'localDiskFreeSpacePercent';
dataProperties[DataProperty.avaliableRamBytes] = 'avaliableRamBytes';
dataProperties[DataProperty.interruptsPerSeconds] = 'interruptsPerSeconds';
dataProperties[DataProperty.localDiskFreeMBytes] = 'localDiskFreeMByte';


export const dataPropertyLables: ProperiesMap<string> = {};
dataPropertyLables[DataProperty.time] = 'Time';
dataPropertyLables[DataProperty.processesCount] = '# of Processes';
dataPropertyLables[DataProperty.processesCPU] = 'Process CPU usage';
dataPropertyLables[DataProperty.processesRAM] = 'Process RAM usage';
dataPropertyLables[DataProperty.cpuUsagePercent] = 'CPU usage %';
dataPropertyLables[DataProperty.ramUsagePercent] = 'RAM usage %';
dataPropertyLables[DataProperty.interruptsTimePercent] = 'Interrupts usage %';
dataPropertyLables[DataProperty.localDiskFreeSpacePercent] = 'Disc usage %';
dataPropertyLables[DataProperty.avaliableRamBytes] = '# of avaliable bytes RAM';
dataPropertyLables[DataProperty.interruptsPerSeconds] = '# of interrupts per second';
dataPropertyLables[DataProperty.localDiskFreeMBytes] = '# of free MB disc';
