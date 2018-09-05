import { LogLevel } from './log-level.enum';

export interface CollectorLog {
  id: string;
  timestamp: Date;
  message: string;
  logLevel: LogLevel;
}
