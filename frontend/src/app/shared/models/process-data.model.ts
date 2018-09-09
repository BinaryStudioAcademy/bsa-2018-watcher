export interface ProcessData {
    name: string;

    pCpu: number;
    pCpuMax?: number;
    pCpuMin?: number;

    pRam: number;
    pRamMax?: number;
    pRamMin?: number;

    ramMBytes: number;
    ramMBytesMax?: number;
    ramMBytesMin?: number;
}
