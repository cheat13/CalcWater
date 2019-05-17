using System.Collections.Generic;

namespace CalcWater
{
    public class WaterResourceBase<T>
        where T : WaterConsumptionUsingPumpBase
    {
        public bool? Doing { get; set; }

        /// <summary>
        ///  ในรอบ 12 เดือนที่ผ่านมา มีบ่อน้้าบาดาลที่ใช้อยู่กี่บ่อ / สระ
        /// </summary>
        public int? WaterResourceCount { get; set; }

        // TODO: enum (ใช้ class ร่วมกับคนอื่นด้วยเลยทำ class ของตัวเอง)
        /// <summary>
        /// ข้อมูลทีละ บ่อ / สระ
        /// </summary>
        public List<T> WaterResources { get; set; }
    }
}