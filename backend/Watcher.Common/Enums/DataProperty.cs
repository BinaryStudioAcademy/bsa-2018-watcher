namespace Watcher.Common.Enums
{
    using Watcher.Common.MoveToFrontend;

    [ExportClassToTypescript]
    public enum DataProperty
    {
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
}