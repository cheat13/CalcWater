namespace CalcWater
{
    public class WaterSources
    {
        public bool Plumbing { get; set; }
        public bool UnderGround { get; set; }
        public bool Pool { get; set; }
        public bool River { get; set; }
        public bool Irrigation { get; set; }
        public bool Rain { get; set; }
        public bool Buying { get; set; }
        public bool RainingAsIs { get; set; }
        public bool HasOther { get; set; }
        public string Other { get; set; }
    }
}