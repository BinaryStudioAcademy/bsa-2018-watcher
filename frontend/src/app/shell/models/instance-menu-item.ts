import {MenuItem} from 'primeng/api';

export interface InstanceMenuItem extends MenuItem  {
  guidId: string;
  statusCheckedAt: Date;
}
