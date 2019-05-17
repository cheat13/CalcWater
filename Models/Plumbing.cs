namespace CalcWater
{
    public class Plumbing
    {
        public PlumbingInfo MWA { get; set; }
        public PlumbingInfo PWA { get; set; }
        public PlumbingInfo Other { get; set; }
        public WaterActivity WaterActivityMWA { get; set; }
        public WaterActivity WaterActivityPWA { get; set; }
        public WaterActivity WaterActivityOther { get; set; }
        public bool? HasWaterNotRunning { get; set; }
        public int? WaterNotRunningCount { get; set; }
    }
}