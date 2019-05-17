using System.Collections.Generic;

namespace CalcWater
{
    public class Pool : WaterResourceBase<WaterConsumptionUsingPump>
    {
        public int? PoolCount { get; set; }
        public bool? HasSameSize { get; set; }
        public List<FieldSize> PoolSizes { get; set; }
    }
}