namespace CalcWater
{
    public class FieldSize
    {
        public FieldShape Shape { get; set; }
        public Area Area { get; set; }
        public int? Depth { get; set; }
        public RectanglePool Rectangle { get; set; }
        public int? Diameter { get; set; }
        public Location Location { get; set; }
    }
}