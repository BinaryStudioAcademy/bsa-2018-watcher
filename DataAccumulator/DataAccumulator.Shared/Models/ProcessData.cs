namespace DataAccumulator.Shared.Models
{
    public class ProcessData
    {
        public string Name { get; set; }

        public float RamMBytes { get; set; }
        public float? RamMBytesMax { get; set; }
        public float? RamMBytesMin { get; set; }

        public float PRam { get; set; }
        public float? PRamMax { get; set; }
        public float? PRamMin { get; set; }

        public float PCpu { get; set; }
        public float? PCpuMax { get; set; }
        public float? PCpuMin { get; set; }
    }
}
