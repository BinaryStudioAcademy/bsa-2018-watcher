export interface ProcessData {
    name: string;

    ramMBytes: number;
    ramMBytesMax?: number;
    ramMBytesMin?: number;

    pRam: number;
    pRamMax?: number;
    pRamMin?: number;

    pCpu: number;
    pCpuMax?: number;
    pCpuMin?: number;
}
