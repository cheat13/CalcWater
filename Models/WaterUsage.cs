namespace CalcWater
{
    public class WaterUsage
    {
        public Plumbing Plumbing { get; set; }
        public GroundWater GroundWater { get; set; }
        public River River { get; set; }
        public Pool Pool { get; set; }
        public Irrigation Irrigation { get; set; }
        public Rain Rain { get; set; }
        public Buying Buying { get; set; }
    }
}