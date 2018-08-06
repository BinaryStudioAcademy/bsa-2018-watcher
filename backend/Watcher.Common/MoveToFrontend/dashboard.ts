
 
    export interface Dashboard { 
        id: number;
        title: string;
        createdAt: Date;
        instanceId: number;
        instance: Instance;
        charts: Chart[];
    }



