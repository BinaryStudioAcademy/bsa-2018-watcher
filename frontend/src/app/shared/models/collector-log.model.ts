import { CollectorLogLevel } from './log-level.enum';

export interface CollectorLog {
  id: string;
  timestamp: Date;
  message: string;
  logLevel: CollectorLogLevel;
}
