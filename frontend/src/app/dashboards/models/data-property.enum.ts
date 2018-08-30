import {ProperiesMap} from '../../shared/models/map';

export enum DataProperty {
  time = 'time',
  processesCount = 'processesCount',
  processesCPU = 'processesCPU',
  processesRAM = 'processesRAM',
  cpuUsagePercent = 'cpuUsagePercent',
  ramUsagePercent = 'ramUsagePercent',
  interruptsTimePercent = 'interruptsTimePercent',
  localDiskFreeSpacePercent = 'localDiskFreeSpacePercent',
  avaliableRamBytes = 'avaliableRamBytes',
  interruptsPerSeconds = 'interruptsPerSeconds',
  localDiskFreeMBytes = 'localDiskFreeMByte'
}

export const dataProperties: ProperiesMap<string> = {};
dataProperties[DataProperty.time] = 'Time';
dataProperties[DataProperty.processesCount] = '# of Processes';
dataProperties[DataProperty.processesCPU] = 'Process CPU usage';
dataProperties[DataProperty.processesRAM] = 'Process RAM usage';
dataProperties[DataProperty.cpuUsagePercent] = 'CPU usage %';
dataProperties[DataProperty.ramUsagePercent] = 'RAM usage %';
dataProperties[DataProperty.interruptsTimePercent] = 'Interrupts usage %';
dataProperties[DataProperty.localDiskFreeSpacePercent] = 'Disc usage %';
dataProperties[DataProperty.avaliableRamBytes] = '# of avaliable bytes RAM';
dataProperties[DataProperty.interruptsPerSeconds] = '# of interrupts per second';
dataProperties[DataProperty.localDiskFreeMBytes] = '# of free MB disc';
