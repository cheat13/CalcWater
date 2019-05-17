namespace CalcWater
{
    public class Pump
    {
        public bool? PumpAuto { get; set; }
        public int? HoursPerPump { get; set; }
        public int? NumberOfPumpsPerYear { get; set; }
        public bool? HasPumpRate { get; set; }
        public int? PumpRate { get; set; }
        public EnergySource EnergySource { get; set; }
        public string PumpType { get; set; }
        public string HorsePower { get; set; }
        public string SuctionPipeSize { get; set; }
        public string PipelineSize { get; set; }
    }
}