export interface InstanceRequest  {
    title: string;
    address: string;
    platform: string;
    isActive: boolean;

    aggregationForHour: boolean;
    aggregationForDay: boolean;
    aggregationForMonth: boolean;
    aggregationForWeek: boolean;

    cpuMaxPercent: number;
    ramMaxPercent: number;
    diskMaxPercent: number;

    organizationId: number;
    guidId?: string;

}
