using System.Collections.Generic;

namespace CalcWater
{
    public class WaterConsumptionUsingPumpBase
    {
        public bool? HasPump { get; set; }
        public int PumpCount { get; set; }
        public List<Pump> Pumps { get; set; }
        public WaterActivity WaterActivities { get; set; }
        public WaterProblem QualityProblem { get; set; }
        public Location Location { get; set; }
    }
}