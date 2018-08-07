
 import { Instance } from './instance';
import { Chart } from './chart';

    export interface Dashboard  { 
        id: number;
        title: string;
        createdAt: Date;
        instanceId: number;
        instance: Instance;
        charts: Chart[];
    }



