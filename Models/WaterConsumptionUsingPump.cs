namespace CalcWater
{
    public class WaterConsumptionUsingPump: WaterConsumptionUsingPumpBase
    {
        public bool? HasCubicMeterPerMonth { get; set; }
        public int? CubicMeterPerMonth { get; set; }
    }
}