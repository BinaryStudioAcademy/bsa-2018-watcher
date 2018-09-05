using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccumulator.Shared.Models
{
    public class ProcessData
    {
        public string Name { get; set; }
        public float RamMBytes { get; set; }
        public float PRam { get; set; }
        public float PCpu { get; set; }
    }
}
