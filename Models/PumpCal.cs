using System.Collections.Generic;

namespace CalcWater
{
    public class PumpCal
    {
        public List<PumpRateModel> listPumpGroundWater = new List<PumpRateModel> {
            new PumpRateModel {
            EnergyFromPump = EnergySource.ElecticPump,
            PumpType = "ปั๊มซับเมิร์ส/ปั๊มแบบจุ่ม",
            Power = "200-500 / 0.2 - 0.7",
            SuctionPipeSize = "-",
            PipelineSize = "1/2-1",
            PumpRate = 30
            },
            new PumpRateModel {
            EnergyFromPump = EnergySource.ElecticPump,
            PumpType = "ปั๊มซับเมิร์ส/ปั๊มแบบจุ่ม",
            Power = "200-500 / 0.2 - 0.7",
            SuctionPipeSize = "-",
            PipelineSize = "1 (1/2)",
            PumpRate = 40
            },
            new PumpRateModel {
            EnergyFromPump = EnergySource.ElecticPump,
            PumpType = "ปั๊มซับเมิร์ส/ปั๊มแบบจุ่ม",
            Power = "200-500 / 0.2 - 0.7",
            SuctionPipeSize = "-",
            PipelineSize = "1 (1/2)-2",
            PumpRate = 50
            },
            new PumpRateModel {
            EnergyFromPump = EnergySource.ElecticPump,
            PumpType = "ปั๊มซับเมิร์ส/ปั๊มแบบจุ่ม",
            Power = "501-1000 / 0.7 - 1.5",
            SuctionPipeSize = "-",
            PipelineSize = "1/2-1 (1/2)",
            PumpRate = 50
            },
            new PumpRateModel {
            EnergyFromPump = EnergySource.ElecticPump,
            PumpType = "ปั๊มซับเมิร์ส/ปั๊มแบบจุ่ม",
            Power = "501-1000 / 0.7 - 1.5",
            SuctionPipeSize = "-",
            PipelineSize = "1 (1/2)-2",
            PumpRate = 60
            },
            new PumpRateModel {
            EnergyFromPump = EnergySource.ElecticPump,
            PumpType = "ปั๊มซับเมิร์ส/ปั๊มแบบจุ่ม",
            Power = "1001-1400 / 1.5 - 2",
            SuctionPipeSize = "-",
            PipelineSize = "1/2-1 (1/2)",
            PumpRate = 70
            },
            new PumpRateModel {
            EnergyFromPump = EnergySource.ElecticPump,
            PumpType = "ปั๊มซับเมิร์ส/ปั๊มแบบจุ่ม",
            Power = "1001-1400 / 1.5 - 2",
            SuctionPipeSize = "-",
            PipelineSize = "1 (1/2)-2",
            PumpRate = 80
            },
            new PumpRateModel {
            EnergyFromPump = EnergySource.ElecticPump,
            PumpType = "ปั๊มซับเมิร์ส/ปั๊มแบบจุ่ม",
            Power = "1401-2000 / 2 - 2.5",
            SuctionPipeSize = "-",
            PipelineSize = "1/2- 1 (1/2)",
            PumpRate = 80
            },
            new PumpRateModel {
            EnergyFromPump = EnergySource.ElecticPump,
            PumpType = "ปั๊มซับเมิร์ส/ปั๊มแบบจุ่ม",
            Power = "1401-2000 / 2 - 2.5",
            SuctionPipeSize = "-",
            PipelineSize = "1 (1/2)-3",
            PumpRate = 120
            },
            new PumpRateModel {
            EnergyFromPump = EnergySource.ElecticPump,
            PumpType = "ปั๊มซับเมิร์ส/ปั๊มแบบจุ่ม",
            Power = "2001-3000 / 2.5 - 4",
            SuctionPipeSize = "-",
            PipelineSize = "1-3",
            PumpRate = 150
            },
            new PumpRateModel {
            EnergyFromPump = EnergySource.ElecticPump,
            PumpType = "ปั๊มซับเมิร์ส/ปั๊มแบบจุ่ม",
            Power = "3001-5000 / 4 - 7",
            SuctionPipeSize = "-",
            PipelineSize = "1-3",
            PumpRate = 250
            },
            new PumpRateModel {
            EnergyFromPump = EnergySource.ElecticPump,
            PumpType = "ปั๊มซับเมิร์ส/ปั๊มแบบจุ่ม",
            Power = "5001-7000 / 7 - 9",
            SuctionPipeSize = "-",
            PipelineSize = "1-4",
            PumpRate = 320
            },
            new PumpRateModel {
            EnergyFromPump = EnergySource.ElecticPump,
            PumpType = "ปั๊มซับเมิร์ส/ปั๊มแบบจุ่ม",
            Power = "7001-10000 / 9 - 15",
            SuctionPipeSize = "-",
            PipelineSize = "1-4",
            PumpRate = 400
            },
            new PumpRateModel {
            EnergyFromPump = EnergySource.ElecticPump,
            PumpType = "ปั๊มซับเมิร์ส/ปั๊มแบบจุ่ม",
            Power = "10001-14000 / 15 - 20",
            SuctionPipeSize = "-",
            PipelineSize = "1-4",
            PumpRate = 500
            },
            new PumpRateModel {
            EnergyFromPump = EnergySource.ElecticPump,
            PumpType = "ปั๊มซับเมิร์ส/ปั๊มแบบจุ่ม",
            Power = "15001-20000 / 20 - 25",
            SuctionPipeSize = "-",
            PipelineSize = "1-4",
            PumpRate = 600
            },
            new PumpRateModel {
            EnergyFromPump = EnergySource.ElecticPump,
            PumpType = "ปั๊มซับเมิร์ส/ปั๊มแบบจุ่ม",
            Power = "50000-100000 / 65 - 135",
            SuctionPipeSize = "-",
            PipelineSize = "1-5",
            PumpRate = 1300
            },
            new PumpRateModel {
            EnergyFromPump = EnergySource.ElecticPump,
            PumpType = "ปั๊มซับเมิร์ส/ปั๊มแบบจุ่ม",
            Power = ">100000 / >135",
            SuctionPipeSize = "-",
            PipelineSize = "1-5",
            PumpRate = 1600
            },
            new PumpRateModel {
            EnergyFromPump = EnergySource.ElecticPump,
            PumpType = "ปั๊มเจ็ท/ ปั๊มน้ำอัตโนมัติสำหรับดูดน้ำลึก",
            Power = "200-300 / 0.2 - 0.4",
            SuctionPipeSize = "1/2-2",
            PipelineSize = "1/2-2",
            PumpRate = 15
            },
            new PumpRateModel {
            EnergyFromPump = EnergySource.ElecticPump,
            PumpType = "ปั๊มเจ็ท/ ปั๊มน้ำอัตโนมัติสำหรับดูดน้ำลึก",
            Power = "301-500 / 0.4 - 0.7",
            SuctionPipeSize = "1/2-2",
            PipelineSize = "1/2-2",
            PumpRate = 20
            },
            new PumpRateModel {
            EnergyFromPump = EnergySource.ElecticPump,
            PumpType = "ปั๊มเจ็ท/ ปั๊มน้ำอัตโนมัติสำหรับดูดน้ำลึก",
            Power = "501-1000 / 0.7 - 1.5",
            SuctionPipeSize = "1/2-2",
            PipelineSize = "1/2-2",
            PumpRate = 30
            },
            new PumpRateModel {
            EnergyFromPump = EnergySource.ElecticPump,
            PumpType = "ปั๊มเจ็ท/ ปั๊มน้ำอัตโนมัติสำหรับดูดน้ำลึก",
            Power = "1100 / 1.5",
            SuctionPipeSize = "1/2-2",
            PipelineSize = "1/2-2",
            PumpRate = 40
            },
            new PumpRateModel {
            EnergyFromPump = EnergySource.ElecticPump,
            PumpType = "ปั๊มเจ็ท/ ปั๊มน้ำอัตโนมัติสำหรับดูดน้ำลึก",
            Power = "1500 / 2",
            SuctionPipeSize = "1/2-2",
            PipelineSize = "1/2-2",
            PumpRate = 50
            },
            new PumpRateModel {
            EnergyFromPump = EnergySource.ElecticPump,
            PumpType = "ปั๊มหอยโข่ง",
            Power = "200-500 / 0.2 - 0.7",
            SuctionPipeSize = "1/2-2",
            PipelineSize = "1/2-2",
            PumpRate = 60
            },
            new PumpRateModel {
            EnergyFromPump = EnergySource.ElecticPump,
            PumpType = "ปั๊มหอยโข่ง",
            Power = "501-1000 / 0.7 - 1.5",
            SuctionPipeSize = "1/2-1",
            PipelineSize = "1/2-1",
            PumpRate = 75
            },
            new PumpRateModel {
            EnergyFromPump = EnergySource.ElecticPump,
            PumpType = "ปั๊มหอยโข่ง",
            Power = "501-1000 / 0.7 - 1.5",
            SuctionPipeSize = "1(1/4)-2",
            PipelineSize = "1(1/2)-2",
            PumpRate = 90
            },
            new PumpRateModel {
            EnergyFromPump = EnergySource.ElecticPump,
            PumpType = "ปั๊มหอยโข่ง",
            Power = "1001-1400 / 1.5 - 2",
            SuctionPipeSize = "1/2-2",
            PipelineSize = "1/2-2",
            PumpRate = 110
            },
            new PumpRateModel {
            EnergyFromPump = EnergySource.ElecticPump,
            PumpType = "ปั๊มหอยโข่ง",
            Power = "1401-2000 / 2 - 2.5",
            SuctionPipeSize = "1/2-2",
            PipelineSize = "1/2-2",
            PumpRate = 130
            },
            new PumpRateModel {
            EnergyFromPump = EnergySource.ElecticPump,
            PumpType = "ปั๊มหอยโข่ง",
            Power = "2001-2500 / 2.5 - 3.5",
            SuctionPipeSize = "1/2-2",
            PipelineSize = "1/2-2",
            PumpRate = 160
            },
            new PumpRateModel {
            EnergyFromPump = EnergySource.ElecticPump,
            PumpType = "ปั๊มหอยโข่ง",
            Power = "2501-3500 / 3.5 - 4.5",
            SuctionPipeSize = "1/2-2",
            PipelineSize = "1/2-2",
            PumpRate = 200
            },
            new PumpRateModel {
            EnergyFromPump = EnergySource.ElecticPump,
            PumpType = "ปั๊มหอยโข่ง",
            Power = "3501-4500 / 4.5 - 6",
            SuctionPipeSize = "1/2-2",
            PipelineSize = "1/2-2",
            PumpRate = 300
            },
            new PumpRateModel {
            EnergyFromPump = EnergySource.ElecticPump,
            PumpType = "ปั๊มหอยโข่ง",
            Power = "4501-5500 / 6 - 7.5",
            SuctionPipeSize = "1/2-3",
            PipelineSize = "1/2-3",
            PumpRate = 450
            },
            new PumpRateModel {
            EnergyFromPump = EnergySource.ElecticPump,
            PumpType = "ปั๊มหอยโข่ง",
            Power = "5501-7500 / 7.5 - 10",
            SuctionPipeSize = "1/2-3",
            PipelineSize = "1/2-3",
            PumpRate = 750
            },
            new PumpRateModel {
            EnergyFromPump = EnergySource.ElecticPump,
            PumpType = "ปั๊มหอยโข่ง",
            Power = "7501-10000 / 10 - 15",
            SuctionPipeSize = "2-3",
            PipelineSize = "2-3",
            PumpRate = 1000
            },
            new PumpRateModel {
            EnergyFromPump = EnergySource.ElecticPump,
            PumpType = "ปั๊มหอยโข่ง",
            Power = "10001-15000 / 15 - 20",
            SuctionPipeSize = "2-4",
            PipelineSize = "2-4",
            PumpRate = 1250
            },
            new PumpRateModel {
            EnergyFromPump = EnergySource.ElecticPump,
            PumpType = "ปั๊มหอยโข่ง",
            Power = "15001-20000 / 20 - 25",
            SuctionPipeSize = "2-3",
            PipelineSize = "2-3",
            PumpRate = 1500
            },
            new PumpRateModel {
            EnergyFromPump = EnergySource.ElecticPump,
            PumpType = "ปั๊มหอยโข่ง",
            Power = "15001-20000 / 20 - 25",
            SuctionPipeSize = "4",
            PipelineSize = "4",
            PumpRate = 1750
            },
            new PumpRateModel {
            EnergyFromPump = EnergySource.ElecticPump,
            PumpType = "ปั๊มหอยโข่ง",
            Power = "20001-25000 / 25 - 35",
            SuctionPipeSize = "2-4",
            PipelineSize = "2-4",
            PumpRate = 2250
            },
            new PumpRateModel {
            EnergyFromPump = EnergySource.ElecticPump,
            PumpType = "ปั๊มหอยโข่ง",
            Power = "25001-30000 / 35 - 40",
            SuctionPipeSize = "2-4",
            PipelineSize = "2-4",
            PumpRate = 3000
            },
            new PumpRateModel {
            EnergyFromPump = EnergySource.ElecticPump,
            PumpType = "ปั๊มหอยโข่ง",
            Power = "30001-40000 / 40 - 55",
            SuctionPipeSize = "2-4",
            PipelineSize = "2-4",
            PumpRate = 3500
            },
            new PumpRateModel {
            EnergyFromPump = EnergySource.ElecticPump,
            PumpType = "ปั๊มชัก",
            Power = "100-200 / 0.1 - 0.2",
            SuctionPipeSize = "1/2-2",
            PipelineSize = "1/2-2",
            PumpRate = 25
            },
            new PumpRateModel {
            EnergyFromPump = EnergySource.ElecticPump,
            PumpType = "ปั๊มชัก",
            Power = "200-300 / 0.2 - 0.4",
            SuctionPipeSize = "1/2-2",
            PipelineSize = "1/2-2",
            PumpRate = 30
            },
            new PumpRateModel {
            EnergyFromPump = EnergySource.ElecticPump,
            PumpType = "ปั๊มชัก",
            Power = "301-400 / 0.4 - 0.5",
            SuctionPipeSize = "1/2-2",
            PipelineSize = "1/2-2",
            PumpRate = 40
            },
            new PumpRateModel {
            EnergyFromPump = EnergySource.ElecticPump,
            PumpType = "ปั๊มชัก",
            Power = "401-500 / 0.5 - 0.7",
            SuctionPipeSize = "1/2-2",
            PipelineSize = "1/2-2",
            PumpRate = 45
            },
            new PumpRateModel {
            EnergyFromPump = EnergySource.ElecticPump,
            PumpType = "ปั๊มชัก",
            Power = "501-700 / 0.7 - 1",
            SuctionPipeSize = "1/2-2",
            PipelineSize = "1/2-2",
            PumpRate = 55
            },
            new PumpRateModel {
            EnergyFromPump = EnergySource.ElecticPump,
            PumpType = "ปั๊มชัก",
            Power = "701-1000 / 1 - 1.5",
            SuctionPipeSize = "1/2-3",
            PipelineSize = "1/2-3",
            PumpRate = 60
            },
            new PumpRateModel {
            EnergyFromPump = EnergySource.ElecticPump,
            PumpType = "ปั๊มชัก",
            Power = "1001-1400 / 1.5 - 2",
            SuctionPipeSize = "1/2-3",
            PipelineSize = "1/2-3",
            PumpRate = 75
            },
            new PumpRateModel {
            EnergyFromPump = EnergySource.ElecticPump,
            PumpType = "ปั๊มชัก",
            Power = "1401-2000 / 2 - 2.5",
            SuctionPipeSize = "1/2-3",
            PipelineSize = "1/2-3",
            PumpRate = 90
            },
            new PumpRateModel {
            EnergyFromPump = EnergySource.ElecticPump,
            PumpType = "ปั๊มชัก",
            Power = "2001-2500 / 2.5 - 3",
            SuctionPipeSize = "1/2-4",
            PipelineSize = "1/2-4",
            PumpRate = 120
            },
            new PumpRateModel {
            EnergyFromPump = EnergySource.ElecticPump,
            PumpType = "ปั๊มชัก",
            Power = "2501-3500 / 3 - 4.5",
            SuctionPipeSize = "1/2-4",
            PipelineSize = "1/2-4",
            PumpRate = 160
            },

        };

        public List<PumpRateModel> listSurfaceWater = new List<PumpRateModel> {
            new PumpRateModel {
                EnergyFromPump = EnergySource.ElecticPump,
                    PumpType = "ปั๊มไดโว่/ปั๊มจุ่ม/ปั๊มแช่",
                    Power = "50-100 / 0.05 - 0.1",
                    SuctionPipeSize = "-",
                    PipelineSize = "(1/2)-1",
                    PumpRate = 3.3
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.ElecticPump,
                    PumpType = "ปั๊มไดโว่/ปั๊มจุ่ม/ปั๊มแช่",
                    Power = "101-200 / 0.1 - 0.2",
                    SuctionPipeSize = "-",
                    PipelineSize = "(1/2)-1",
                    PumpRate = 5.4
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.ElecticPump,
                    PumpType = "ปั๊มไดโว่/ปั๊มจุ่ม/ปั๊มแช่",
                    Power = "201-300 / 0.2 - 0.4",
                    SuctionPipeSize = "-",
                    PipelineSize = "(1/2)-1",
                    PumpRate = 6.0
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.ElecticPump,
                    PumpType = "ปั๊มไดโว่/ปั๊มจุ่ม/ปั๊มแช่",
                    Power = "201-300 / 0.2 - 0.4",
                    SuctionPipeSize = "-",
                    PipelineSize = "1 (1/2)-2",
                    PumpRate = 11.4
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.ElecticPump,
                    PumpType = "ปั๊มไดโว่/ปั๊มจุ่ม/ปั๊มแช่",
                    Power = "301-400 / 0.4 - 0.6",
                    SuctionPipeSize = "-",
                    PipelineSize = "(1/2)-1",
                    PumpRate = 7.2
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.ElecticPump,
                    PumpType = "ปั๊มไดโว่/ปั๊มจุ่ม/ปั๊มแช่",
                    Power = "301-400 / 0.4 - 0.6",
                    SuctionPipeSize = "-",
                    PipelineSize = "1 (1/2)-2",
                    PumpRate = 12.0
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.ElecticPump,
                    PumpType = "ปั๊มไดโว่/ปั๊มจุ่ม/ปั๊มแช่",
                    Power = "401-500 / 0.6 - 0.7",
                    SuctionPipeSize = "-",
                    PipelineSize = "(1/2)-2",
                    PumpRate = 13.8
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.ElecticPump,
                    PumpType = "ปั๊มไดโว่/ปั๊มจุ่ม/ปั๊มแช่",
                    Power = "501-700 / 0.7 - 1",
                    SuctionPipeSize = "-",
                    PipelineSize = "(1/2)-2",
                    PumpRate = 12.0
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.ElecticPump,
                    PumpType = "ปั๊มไดโว่/ปั๊มจุ่ม/ปั๊มแช่",
                    Power = "701-1000 / 1 - 1.5",
                    SuctionPipeSize = "-",
                    PipelineSize = "(1/2)-2",
                    PumpRate = 15.0
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.ElecticPump,
                    PumpType = "ปั๊มไดโว่/ปั๊มจุ่ม/ปั๊มแช่",
                    Power = "701-1000 / 1 - 1.5",
                    SuctionPipeSize = "-",
                    PipelineSize = "3",
                    PumpRate = 18.6
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.ElecticPump,
                    PumpType = "ปั๊มไดโว่/ปั๊มจุ่ม/ปั๊มแช่",
                    Power = "1001-1200 / 1.5 - 1.7",
                    SuctionPipeSize = "-",
                    PipelineSize = "(1/2)-2",
                    PumpRate = 18.0
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.ElecticPump,
                    PumpType = "ปั๊มไดโว่/ปั๊มจุ่ม/ปั๊มแช่",
                    Power = "1001-1200 / 1.5 - 1.7",
                    SuctionPipeSize = "-",
                    PipelineSize = "3",
                    PumpRate = 21.0
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.ElecticPump,
                    PumpType = "ปั๊มไดโว่/ปั๊มจุ่ม/ปั๊มแช่",
                    Power = "1201-1400 / 1.7 - 2",
                    SuctionPipeSize = "-",
                    PipelineSize = "(1/2)-3",
                    PumpRate = 21.6
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.ElecticPump,
                    PumpType = "ปั๊มไดโว่/ปั๊มจุ่ม/ปั๊มแช่",
                    Power = "1401-2000 / 2 - 2.5",
                    SuctionPipeSize = "-",
                    PipelineSize = "(1/2)-3",
                    PumpRate = 24.0
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.ElecticPump,
                    PumpType = "ปั๊มไดโว่/ปั๊มจุ่ม/ปั๊มแช่",
                    Power = "2001-3000 / 2.5 - 4",
                    SuctionPipeSize = "-",
                    PipelineSize = "(1/2)-3",
                    PumpRate = 36.0
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.ElecticPump,
                    PumpType = "ปั๊มไดโว่/ปั๊มจุ่ม/ปั๊มแช่",
                    Power = "3001-5000 / 4 -7",
                    SuctionPipeSize = "-",
                    PipelineSize = "(1/2)-3",
                    PumpRate = 60.0
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.ElecticPump,
                    PumpType = "ปั๊มไดโว่/ปั๊มจุ่ม/ปั๊มแช่",
                    Power = "3001-5000 / 4 -7",
                    SuctionPipeSize = "-",
                    PipelineSize = "4",
                    PumpRate = 72.0
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.ElecticPump,
                    PumpType = "ปั๊มไดโว่/ปั๊มจุ่ม/ปั๊มแช่",
                    Power = "5001-7000 / 7 - 9.5",
                    SuctionPipeSize = "-",
                    PipelineSize = "(1/2)-3",
                    PumpRate = 90.0
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.ElecticPump,
                    PumpType = "ปั๊มไดโว่/ปั๊มจุ่ม/ปั๊มแช่",
                    Power = "5001-7000 / 7 - 9.5",
                    SuctionPipeSize = "-",
                    PipelineSize = "4",
                    PumpRate = 120.0
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.ElecticPump,
                    PumpType = "ปั๊มไดโว่/ปั๊มจุ่ม/ปั๊มแช่",
                    Power = ">7000 / >9.5",
                    SuctionPipeSize = "-",
                    PipelineSize = "2-6",
                    PumpRate = 132.0
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.ElecticPump,
                    PumpType = "ปั๊มน้ำอัตโนมัติ ถังกลม/ ถังเหลี่ยม",
                    Power = "50-100 / 0.05 - 0.1",
                    SuctionPipeSize = "(1/2)-1",
                    PipelineSize = "(1/2)-1",
                    PumpRate = 1.5
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.ElecticPump,
                    PumpType = "ปั๊มน้ำอัตโนมัติ ถังกลม/ ถังเหลี่ยม",
                    Power = "101-200 / 0.1 - 0.3",
                    SuctionPipeSize = "(1/2)-1",
                    PipelineSize = "(1/2)-1",
                    PumpRate = 2.2
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.ElecticPump,
                    PumpType = "ปั๊มน้ำอัตโนมัติ ถังกลม/ ถังเหลี่ยม",
                    Power = "101-200 / 0.1 - 0.3",
                    SuctionPipeSize = "1(1/2)-2",
                    PipelineSize = "1(1/2)-2",
                    PumpRate = 2.4
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.ElecticPump,
                    PumpType = "ปั๊มน้ำอัตโนมัติ ถังกลม/ ถังเหลี่ยม",
                    Power = "201-300 / 0.3 - 0.4",
                    SuctionPipeSize = "(1/2)-1",
                    PipelineSize = "(1/2)-1",
                    PumpRate = 2.7
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.ElecticPump,
                    PumpType = "ปั๊มน้ำอัตโนมัติ ถังกลม/ ถังเหลี่ยม",
                    Power = "201-300 / 0.3 - 0.4",
                    SuctionPipeSize = "1(1/2)-2",
                    PipelineSize = "1(1/2)-2",
                    PumpRate = 3.0
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.ElecticPump,
                    PumpType = "ปั๊มน้ำอัตโนมัติ ถังกลม/ ถังเหลี่ยม",
                    Power = "301-400 / 0.4 - 0.5",
                    SuctionPipeSize = "(1/2)-1",
                    PipelineSize = "(1/2)-1",
                    PumpRate = 3.2
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.ElecticPump,
                    PumpType = "ปั๊มน้ำอัตโนมัติ ถังกลม/ ถังเหลี่ยม",
                    Power = "301-400 / 0.4 - 0.5",
                    SuctionPipeSize = "1(1/2)-2",
                    PipelineSize = "1(1/2)-2",
                    PumpRate = 3.6
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.ElecticPump,
                    PumpType = "ปั๊มน้ำอัตโนมัติ ถังกลม/ ถังเหลี่ยม",
                    Power = "401-500 / 0.5 - 0.7",
                    SuctionPipeSize = "(1/2)-1",
                    PipelineSize = "(1/2)-1",
                    PumpRate = 3.9
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.ElecticPump,
                    PumpType = "ปั๊มน้ำอัตโนมัติ ถังกลม/ ถังเหลี่ยม",
                    Power = "401-500 / 0.5 - 0.7",
                    SuctionPipeSize = "1(1/2)-2",
                    PipelineSize = "1(1/2)-2",
                    PumpRate = 4.2
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.ElecticPump,
                    PumpType = "ปั๊มน้ำอัตโนมัติ ถังกลม/ ถังเหลี่ยม",
                    Power = "501-700 / 0.7 - 0.9",
                    SuctionPipeSize = "(1/2)-2",
                    PipelineSize = "(1/2)-2",
                    PumpRate = 4.8
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.ElecticPump,
                    PumpType = "ปั๊มน้ำอัตโนมัติ ถังกลม/ ถังเหลี่ยม",
                    Power = "701-800 / 0.9 - 1",
                    SuctionPipeSize = "(1/2)-2",
                    PipelineSize = "(1/2)-2",
                    PumpRate = 5.2
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.ElecticPump,
                    PumpType = "ปั๊มน้ำอัตโนมัติ ถังกลม/ ถังเหลี่ยม",
                    Power = ">800 / >1",
                    SuctionPipeSize = "(1/2)-2",
                    PipelineSize = "(1/2)-2",
                    PumpRate = 5.7
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.ElecticPump,
                    PumpType = "ปั๊มหอยโข่ง",
                    Power = "200-400 / 0.2 - 0.5",
                    SuctionPipeSize = "(1/2)-2",
                    PipelineSize = "(1/2)-2",
                    PumpRate = 3.6
            },

            new PumpRateModel {
                EnergyFromPump = EnergySource.ElecticPump,
                    PumpType = "ปั๊มหอยโข่ง",
                    Power = "401-600 / 0.5 - 1",
                    SuctionPipeSize = "(1/2)-2",
                    PipelineSize = "(1/2)-2",
                    PumpRate = 4.5
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.ElecticPump,
                    PumpType = "ปั๊มหอยโข่ง",
                    Power = "601-1000 / 1 - 1.5",
                    SuctionPipeSize = "(1/2)-2",
                    PipelineSize = "(1/2)-2",
                    PumpRate = 5.4
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.ElecticPump,
                    PumpType = "ปั๊มหอยโข่ง",
                    Power = "1001-1400 / 1.5 - 2",
                    SuctionPipeSize = "(1/2)-2",
                    PipelineSize = "(1/2)-2",
                    PumpRate = 6.6
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.ElecticPump,
                    PumpType = "ปั๊มหอยโข่ง",
                    Power = "1401-2000 / 2 - 3",
                    SuctionPipeSize = "(1/2)-2",
                    PipelineSize = "(1/2)-2",
                    PumpRate = 7.8
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.ElecticPump,
                    PumpType = "ปั๊มหอยโข่ง",
                    Power = "2001-2500 / 3 - 3.5",
                    SuctionPipeSize = "(1/2)-1 (1/2)",
                    PipelineSize = "(1/2)-1 (1/2)",
                    PumpRate = 9.6
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.ElecticPump,
                    PumpType = "ปั๊มหอยโข่ง",
                    Power = "2001-2500 / 3 - 3.5",
                    SuctionPipeSize = "2",
                    PipelineSize = "2",
                    PumpRate = 12.0
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.ElecticPump,
                    PumpType = "ปั๊มหอยโข่ง",
                    Power = "2001-2500 / 3 - 3.5",
                    SuctionPipeSize = "3",
                    PipelineSize = "3",
                    PumpRate = 24.0
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.ElecticPump,
                    PumpType = "ปั๊มหอยโข่ง",
                    Power = "2501-3500 / 3.5 - 5",
                    SuctionPipeSize = "(1/2)-1 (1/2)",
                    PipelineSize = "(1/2)-1 (1/2)",
                    PumpRate = 12.0
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.ElecticPump,
                    PumpType = "ปั๊มหอยโข่ง",
                    Power = "2501-3500 / 3.5 - 5",
                    SuctionPipeSize = "2",
                    PipelineSize = "2",
                    PumpRate = 12.0
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.ElecticPump,
                    PumpType = "ปั๊มหอยโข่ง",
                    Power = "2501-3500 / 3.5 - 5",
                    SuctionPipeSize = "3",
                    PipelineSize = "3",
                    PumpRate = 24.0
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.ElecticPump,
                    PumpType = "ปั๊มหอยโข่ง",
                    Power = "3501-4500 / 5 - 6",
                    SuctionPipeSize = "(1/2)-1 (1/2)",
                    PipelineSize = "(1/2)-1 (1/2)",
                    PumpRate = 18.0
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.ElecticPump,
                    PumpType = "ปั๊มหอยโข่ง",
                    Power = "3501-4500 / 5 - 6",
                    SuctionPipeSize = "2",
                    PipelineSize = "2",
                    PumpRate = 18.0
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.ElecticPump,
                    PumpType = "ปั๊มหอยโข่ง",
                    Power = "3501-4500 / 5 - 6",
                    SuctionPipeSize = "3",
                    PipelineSize = "3",
                    PumpRate = 24.0
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.ElecticPump,
                    PumpType = "ปั๊มหอยโข่ง",
                    Power = "4501-6000 / 6 - 8",
                    SuctionPipeSize = "(1/2)-2",
                    PipelineSize = "(1/2)-2",
                    PumpRate = 27.0
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.ElecticPump,
                    PumpType = "ปั๊มหอยโข่ง",
                    Power = "4501-6000 / 6 - 8",
                    SuctionPipeSize = "3",
                    PipelineSize = "2 (1/2)",
                    PumpRate = 36.0
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.ElecticPump,
                    PumpType = "ปั๊มหอยโข่ง",
                    Power = "6001-8000 / 8 - 11",
                    SuctionPipeSize = "3",
                    PipelineSize = "3",
                    PumpRate = 45.0
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.ElecticPump,
                    PumpType = "ปั๊มหอยโข่ง",
                    Power = "6001-8000 / 8 - 11",
                    SuctionPipeSize = "3",
                    PipelineSize = "3 (1/2)",
                    PumpRate = 48.0
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.ElecticPump,
                    PumpType = "ปั๊มหอยโข่ง",
                    Power = "6001-8000 / 8 - 11",
                    SuctionPipeSize = "4",
                    PipelineSize = "3",
                    PumpRate = 54.0
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.ElecticPump,
                    PumpType = "ปั๊มหอยโข่ง",
                    Power = "8001-10000 / 11 - 15",
                    SuctionPipeSize = "(1/2)-3",
                    PipelineSize = "(1/2)-3",
                    PumpRate = 60.0
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.ElecticPump,
                    PumpType = "ปั๊มหอยโข่ง",
                    Power = "10001-14000 / 15 - 20",
                    SuctionPipeSize = "4",
                    PipelineSize = "4",
                    PumpRate = 75.0
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.ElecticPump,
                    PumpType = "ปั๊มหอยโข่ง",
                    Power = "10001-14000 / 15 - 20",
                    SuctionPipeSize = "4",
                    PipelineSize = "4 (1/2)",
                    PumpRate = 75.0
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.ElecticPump,
                    PumpType = "ปั๊มหอยโข่ง",
                    Power = "10001-14000 / 15 - 20",
                    SuctionPipeSize = "5-6",
                    PipelineSize = "5-6",
                    PumpRate = 180.0
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.ElecticPump,
                    PumpType = "ปั๊มหอยโข่ง",
                    Power = "14001-17000 / 20 - 23",
                    SuctionPipeSize = "(1/2)-3",
                    PipelineSize = "(1/2)-3",
                    PumpRate = 90.0
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.ElecticPump,
                    PumpType = "ปั๊มหอยโข่ง",
                    Power = "14001-17000 / 20 - 23",
                    SuctionPipeSize = "4",
                    PipelineSize = "4",
                    PumpRate = 90.0
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.ElecticPump,
                    PumpType = "ปั๊มหอยโข่ง",
                    Power = "14001-17000 / 20 - 23",
                    SuctionPipeSize = "5-6",
                    PipelineSize = "5-6",
                    PumpRate = 120.0
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.ElecticPump,
                    PumpType = "ปั๊มหอยโข่ง",
                    Power = "17001-20000 / 23 - 25",
                    SuctionPipeSize = "(1/2)-3",
                    PipelineSize = "(1/2)-3",
                    PumpRate = 105.0
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.ElecticPump,
                    PumpType = "ปั๊มหอยโข่ง",
                    Power = "17001-20000 / 23 - 25",
                    SuctionPipeSize = "4",
                    PipelineSize = "4",
                    PumpRate = 105.0
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.ElecticPump,
                    PumpType = "ปั๊มหอยโข่ง",
                    Power = "17001-20000 / 23 - 25",
                    SuctionPipeSize = "5-6",
                    PipelineSize = "5-6",
                    PumpRate = 150.0
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.ElecticPump,
                    PumpType = "ปั๊มหอยโข่ง",
                    Power = "20001-25000 / 25 - 35",
                    SuctionPipeSize = "(1/2)-3",
                    PipelineSize = "(1/2)-3",
                    PumpRate = 135.0
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.ElecticPump,
                    PumpType = "ปั๊มหอยโข่ง",
                    Power = "20001-25000 / 25 - 35",
                    SuctionPipeSize = "4",
                    PipelineSize = "4",
                    PumpRate = 135.0
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.ElecticPump,
                    PumpType = "ปั๊มหอยโข่ง",
                    Power = "20001-25000 / 25 - 35",
                    SuctionPipeSize = "5-6",
                    PipelineSize = "5-6",
                    PumpRate = 180.0
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.ElecticPump,
                    PumpType = "ปั๊มหอยโข่ง",
                    Power = "30001-35000 / 40 - 47",
                    SuctionPipeSize = "(1/2)-3",
                    PipelineSize = "(1/2)-3",
                    PumpRate = 180.0
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.ElecticPump,
                    PumpType = "ปั๊มหอยโข่ง",
                    Power = "30001-35000 / 40 - 47",
                    SuctionPipeSize = "4",
                    PipelineSize = "4",
                    PumpRate = 180.0
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.ElecticPump,
                    PumpType = "ปั๊มหอยโข่ง",
                    Power = "30001-35000 / 40 - 47",
                    SuctionPipeSize = "5-6",
                    PipelineSize = "5-6",
                    PumpRate = 240.0
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.ElecticPump,
                    PumpType = "ปั๊มหอยโข่ง",
                    Power = "35001-40000 / 47 - 55",
                    SuctionPipeSize = "(1/2)-3",
                    PipelineSize = "(1/2)-3",
                    PumpRate = 210.0
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.ElecticPump,
                    PumpType = "ปั๊มหอยโข่ง",
                    Power = "35001-40000 / 47 - 55",
                    SuctionPipeSize = "4",
                    PipelineSize = "4",
                    PumpRate = 210.0
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.ElecticPump,
                    PumpType = "ปั๊มหอยโข่ง",
                    Power = "35001-40000 / 47 - 55",
                    SuctionPipeSize = "5-6",
                    PipelineSize = "5-6",
                    PumpRate = 270.0
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.ElecticPump,
                    PumpType = "ปั๊มหอยโข่ง",
                    Power = ">40000 / >55",
                    SuctionPipeSize = "(1/2)-6",
                    PipelineSize = "(1/2)-6",
                    PumpRate = 348.0
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.ElecticPump,
                    PumpType = "ปั๊มหอยโข่ง",
                    Power = ">40000 / >55",
                    SuctionPipeSize = "7-8",
                    PipelineSize = "7-8",
                    PumpRate = 390.0
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.SolaPump,
                    PumpType = "ปั๊มหอยโข่ง/ปั๊มพญานาค",
                    Power = "1000-4000 / 1 - 5",
                    SuctionPipeSize = "(1/2)-2",
                    PipelineSize = "(1/2)-2",
                    PumpRate = 30.0
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.SolaPump,
                    PumpType = "ปั๊มหอยโข่ง/ปั๊มพญานาค",
                    Power = "1000-4000 / 1 - 5",
                    SuctionPipeSize = "3",
                    PipelineSize = "3",
                    PumpRate = 36.0
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.SolaPump,
                    PumpType = "ปั๊มหอยโข่ง/ปั๊มพญานาค",
                    Power = "1000-4000 / 1 - 5",
                    SuctionPipeSize = "4",
                    PipelineSize = "4",
                    PumpRate = 48.0
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.SolaPump,
                    PumpType = "ปั๊มหอยโข่ง/ปั๊มพญานาค",
                    Power = "1000-4000 / 1 - 5",
                    SuctionPipeSize = "5-6",
                    PipelineSize = "5-6",
                    PumpRate = 60.0
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.SolaPump,
                    PumpType = "ปั๊มหอยโข่ง/ปั๊มพญานาค",
                    Power = "4001-5000 / 5 - 7",
                    SuctionPipeSize = "(1/2)-3",
                    PipelineSize = "(1/2)-3",
                    PumpRate = 48.0
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.SolaPump,
                    PumpType = "ปั๊มหอยโข่ง/ปั๊มพญานาค",
                    Power = "4001-5000 / 5 - 7",
                    SuctionPipeSize = "4",
                    PipelineSize = "4",
                    PumpRate = 60.0
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.SolaPump,
                    PumpType = "ปั๊มหอยโข่ง/ปั๊มพญานาค",
                    Power = "4001-5000 / 5 - 7",
                    SuctionPipeSize = "5-6",
                    PipelineSize = "5-6",
                    PumpRate = 90.0
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.SolaPump,
                    PumpType = "ปั๊มหอยโข่ง/ปั๊มพญานาค",
                    Power = "4001-5000 / 5 - 7",
                    SuctionPipeSize = "7-8",
                    PipelineSize = "7-8",
                    PumpRate = 108.0
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.SolaPump,
                    PumpType = "ปั๊มหอยโข่ง/ปั๊มพญานาค",
                    Power = "5001-6000 / 7 - 8",
                    SuctionPipeSize = "(1/2)-3",
                    PipelineSize = "(1/2)-3",
                    PumpRate = 54.0
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.SolaPump,
                    PumpType = "ปั๊มหอยโข่ง/ปั๊มพญานาค",
                    Power = "5001-6000 / 7 - 8",
                    SuctionPipeSize = "4-6",
                    PipelineSize = "4-6",
                    PumpRate = 90.0
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.SolaPump,
                    PumpType = "ปั๊มหอยโข่ง/ปั๊มพญานาค",
                    Power = "5001-6000 / 7 - 8",
                    SuctionPipeSize = "7-8",
                    PipelineSize = "7-8",
                    PumpRate = 108.0
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.SolaPump,
                    PumpType = "ปั๊มหอยโข่ง/ปั๊มพญานาค",
                    Power = "6001-7000 / 8 - 9.5",
                    SuctionPipeSize = "(1/2)-3",
                    PipelineSize = "(1/2)-3",
                    PumpRate = 72.0
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.SolaPump,
                    PumpType = "ปั๊มหอยโข่ง/ปั๊มพญานาค",
                    Power = "6001-7000 / 8 - 9.5",
                    SuctionPipeSize = "4-6",
                    PipelineSize = "4-6",
                    PumpRate = 96.0
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.SolaPump,
                    PumpType = "ปั๊มหอยโข่ง/ปั๊มพญานาค",
                    Power = "6001-7000 / 8 - 9.5",
                    SuctionPipeSize = "7-8",
                    PipelineSize = "7-8",
                    PumpRate = 120.0
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.SolaPump,
                    PumpType = "ปั๊มหอยโข่ง/ปั๊มพญานาค",
                    Power = "7001-8000 / 8 - 9.5",
                    SuctionPipeSize = "(1/2)-4",
                    PipelineSize = "(1/2)-4",
                    PumpRate = 90.0
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.SolaPump,
                    PumpType = "ปั๊มหอยโข่ง/ปั๊มพญานาค",
                    Power = "7001-8000 / 9.5 - 11",
                    SuctionPipeSize = "5-6",
                    PipelineSize = "5-6",
                    PumpRate = 108.0
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.SolaPump,
                    PumpType = "ปั๊มหอยโข่ง/ปั๊มพญานาค",
                    Power = "7001-8000 / 9.5 - 11",
                    SuctionPipeSize = "7-8",
                    PipelineSize = "7-8",
                    PumpRate = 150.0
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.SolaPump,
                    PumpType = "ปั๊มหอยโข่ง/ปั๊มพญานาค",
                    Power = "8001-9000 / 11 - 12",
                    SuctionPipeSize = "(1/2)-4",
                    PipelineSize = "(1/2)-4",
                    PumpRate = 108.0
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.SolaPump,
                    PumpType = "ปั๊มหอยโข่ง/ปั๊มพญานาค",
                    Power = "8001-9000 / 11 - 12",
                    SuctionPipeSize = "5-6",
                    PipelineSize = "5-6",
                    PumpRate = 120.0
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.SolaPump,
                    PumpType = "ปั๊มหอยโข่ง/ปั๊มพญานาค",
                    Power = "8001-9000 / 11 - 12",
                    SuctionPipeSize = "7-8",
                    PipelineSize = "7-8",
                    PumpRate = 132.0
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.SolaPump,
                    PumpType = "ปั๊มหอยโข่ง/ปั๊มพญานาค",
                    Power = "8001-9000 / 11 - 12",
                    SuctionPipeSize = "9-10",
                    PipelineSize = "9-10",
                    PumpRate = 150.0
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.SolaPump,
                    PumpType = "ปั๊มหอยโข่ง/ปั๊มพญานาค",
                    Power = "9001-10000 / 12 - 14",
                    SuctionPipeSize = "(1/2)-4",
                    PipelineSize = "(1/2)-4",
                    PumpRate = 120.0
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.SolaPump,
                    PumpType = "ปั๊มหอยโข่ง/ปั๊มพญานาค",
                    Power = "9001-10000 / 12 - 14",
                    SuctionPipeSize = "5-6",
                    PipelineSize = "5-6",
                    PumpRate = 132.0
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.SolaPump,
                    PumpType = "ปั๊มหอยโข่ง/ปั๊มพญานาค",
                    Power = "9001-10000 / 12 - 14",
                    SuctionPipeSize = "7-8",
                    PipelineSize = "7-8",
                    PumpRate = 144.0
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.SolaPump,
                    PumpType = "ปั๊มหอยโข่ง/ปั๊มพญานาค",
                    Power = "9001-10000 / 12 - 14",
                    SuctionPipeSize = "9-10",
                    PipelineSize = "9-10",
                    PumpRate = 180.0
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.SolaPump,
                    PumpType = "ปั๊มหอยโข่ง/ปั๊มพญานาค",
                    Power = "10001-12000 / 14 - 16",
                    SuctionPipeSize = "(1/2)-6",
                    PipelineSize = "(1/2)-6",
                    PumpRate = 156.0
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.SolaPump,
                    PumpType = "ปั๊มหอยโข่ง/ปั๊มพญานาค",
                    Power = "10001-12000 / 14 - 16",
                    SuctionPipeSize = "7-8",
                    PipelineSize = "7-8",
                    PumpRate = 180.0
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.SolaPump,
                    PumpType = "ปั๊มหอยโข่ง/ปั๊มพญานาค",
                    Power = "10001-12000 / 14 - 16",
                    SuctionPipeSize = "9-10",
                    PipelineSize = "9-10",
                    PumpRate = 210.0
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.SolaPump,
                    PumpType = "ปั๊มหอยโข่ง/ปั๊มพญานาค",
                    Power = "12001-15000 / 16 - 20",
                    SuctionPipeSize = "(1/2)-6",
                    PipelineSize = "(1/2)-6",
                    PumpRate = 180.0
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.SolaPump,
                    PumpType = "ปั๊มหอยโข่ง/ปั๊มพญานาค",
                    Power = "12001-15000 / 16 - 20",
                    SuctionPipeSize = "7-8",
                    PipelineSize = "7-8",
                    PumpRate = 210.0
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.SolaPump,
                    PumpType = "ปั๊มหอยโข่ง/ปั๊มพญานาค",
                    Power = "12001-15000 / 16 - 20",
                    SuctionPipeSize = "9-10",
                    PipelineSize = "9-10",
                    PumpRate = 180.0
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.SolaPump,
                    PumpType = "ปั๊มหอยโข่ง/ปั๊มพญานาค",
                    Power = "15001-20000 / 20 - 25",
                    SuctionPipeSize = "(1/2)-6",
                    PipelineSize = "(1/2)-6",
                    PumpRate = 210.0
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.SolaPump,
                    PumpType = "ปั๊มหอยโข่ง/ปั๊มพญานาค",
                    Power = "15001-20000 / 20 - 25",
                    SuctionPipeSize = "7-8",
                    PipelineSize = "7-8",
                    PumpRate = 228.0
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.SolaPump,
                    PumpType = "ปั๊มหอยโข่ง/ปั๊มพญานาค",
                    Power = "15001-20000 / 20 - 25",
                    SuctionPipeSize = "9-10",
                    PipelineSize = "9-10",
                    PumpRate = 270.0
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.SolaPump,
                    PumpType = "ปั๊มหอยโข่ง/ปั๊มพญานาค",
                    Power = "20001-30000 / 25 - 40",
                    SuctionPipeSize = "(1/2)-6",
                    PipelineSize = "(1/2)-6",
                    PumpRate = 240.0
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.SolaPump,
                    PumpType = "ปั๊มหอยโข่ง/ปั๊มพญานาค",
                    Power = "30001-40000 / 40 - 55",
                    SuctionPipeSize = "7-8",
                    PipelineSize = "7-8",
                    PumpRate = 438.0
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.SolaPump,
                    PumpType = "ปั๊มหอยโข่ง/ปั๊มพญานาค",
                    Power = "30001-40000 / 40 - 55",
                    SuctionPipeSize = "9-10",
                    PipelineSize = "9-10",
                    PumpRate = 480.0
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.SolaPump,
                    PumpType = "ปั๊มหอยโข่ง/ปั๊มพญานาค",
                    Power = "30001-40000 / 40 - 55",
                    SuctionPipeSize = "11-12",
                    PipelineSize = "11-12",
                    PumpRate = 540.0
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.SolaPump,
                    PumpType = "ปั๊มหอยโข่ง/ปั๊มพญานาค",
                    Power = "40001-50000 / 55 - 70",
                    SuctionPipeSize = "(1/2)-8",
                    PipelineSize = "(1/2)-8",
                    PumpRate = 510.0
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.SolaPump,
                    PumpType = "ปั๊มหอยโข่ง/ปั๊มพญานาค",
                    Power = "40001-50000 / 55 - 70",
                    SuctionPipeSize = "9-10",
                    PipelineSize = "9-10",
                    PumpRate = 540.0
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.SolaPump,
                    PumpType = "ปั๊มหอยโข่ง/ปั๊มพญานาค",
                    Power = "40001-50000 / 55 - 70",
                    SuctionPipeSize = "11-12",
                    PipelineSize = "11-12",
                    PumpRate = 570.0
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.SolaPump,
                    PumpType = "ปั๊มหอยโข่ง/ปั๊มพญานาค",
                    Power = "50001-60000 / 70 - 80",
                    SuctionPipeSize = "(1/2)-10",
                    PipelineSize = "(1/2)-8",
                    PumpRate = 570.0
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.SolaPump,
                    PumpType = "ปั๊มหอยโข่ง/ปั๊มพญานาค",
                    Power = "60001-80000 / 80 - 105",
                    SuctionPipeSize = "9-10",
                    PipelineSize = "9-10",
                    PumpRate = 660.0
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.SolaPump,
                    PumpType = "ปั๊มหอยโข่ง/ปั๊มพญานาค",
                    Power = "80001-110000 / 105 -150",
                    SuctionPipeSize = "11-12",
                    PipelineSize = "11-12",
                    PumpRate = 900.0
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.SolaPump,
                    PumpType = "ปั๊มหอยโข่ง/ปั๊มพญานาค",
                    Power = ">110000 / >150",
                    SuctionPipeSize = "6-12",
                    PipelineSize = "6-12",
                    PumpRate = 1200.0
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.PetrolPump,
                    PumpType = "ปั๊มหอยโข่ง/ปั๊มพญานาค",
                    Power = "2000-4000 / 2.5 - 5.5",
                    SuctionPipeSize = "(1/2)-2",
                    PipelineSize = "(1/2)-2",
                    PumpRate = 37.5
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.PetrolPump,
                    PumpType = "ปั๊มหอยโข่ง/ปั๊มพญานาค",
                    Power = "4001-4500 / 5.5 - 6",
                    SuctionPipeSize = "(1/2)-2",
                    PipelineSize = "(1/2)-2",
                    PumpRate = 36.0
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.PetrolPump,
                    PumpType = "ปั๊มหอยโข่ง/ปั๊มพญานาค",
                    Power = "4001-4500 / 5.5 - 6",
                    SuctionPipeSize = "3",
                    PipelineSize = "3",
                    PumpRate = 57.0
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.PetrolPump,
                    PumpType = "ปั๊มหอยโข่ง/ปั๊มพญานาค",
                    Power = "4001-4500 / 5.5 - 6",
                    SuctionPipeSize = "4",
                    PipelineSize = "4",
                    PumpRate = 60.0
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.PetrolPump,
                    PumpType = "ปั๊มหอยโข่ง/ปั๊มพญานาค",
                    Power = "4001-4500 / 5.5 - 6",
                    SuctionPipeSize = "5-6",
                    PipelineSize = "5-6",
                    PumpRate = 90.0
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.PetrolPump,
                    PumpType = "ปั๊มหอยโข่ง/ปั๊มพญานาค",
                    Power = "4501-5000 / 6 - 6.5",
                    SuctionPipeSize = "(1/2)-2",
                    PipelineSize = "(1/2)-2",
                    PumpRate = 42.0
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.PetrolPump,
                    PumpType = "ปั๊มหอยโข่ง/ปั๊มพญานาค",
                    Power = "4501-5000 / 6 - 6.5",
                    SuctionPipeSize = "3",
                    PipelineSize = "3",
                    PumpRate = 66.0
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.PetrolPump,
                    PumpType = "ปั๊มหอยโข่ง/ปั๊มพญานาค",
                    Power = "4501-5000 / 6 - 6.5",
                    SuctionPipeSize = "4",
                    PipelineSize = "4",
                    PumpRate = 72.0
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.PetrolPump,
                    PumpType = "ปั๊มหอยโข่ง/ปั๊มพญานาค",
                    Power = "4501-5000 / 6 - 6.5",
                    SuctionPipeSize = "5-6",
                    PipelineSize = "5-6",
                    PumpRate = 90.0
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.PetrolPump,
                    PumpType = "ปั๊มหอยโข่ง/ปั๊มพญานาค",
                    Power = "5001-6000 / 6.5 - 8",
                    SuctionPipeSize = "(1/2)-4",
                    PipelineSize = "(1/2)-4",
                    PumpRate = 72.0
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.PetrolPump,
                    PumpType = "ปั๊มหอยโข่ง/ปั๊มพญานาค",
                    Power = "5001-6000 / 6.5 - 8",
                    SuctionPipeSize = "5-6",
                    PipelineSize = "5-6",
                    PumpRate = 90.0
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.PetrolPump,
                    PumpType = "ปั๊มหอยโข่ง/ปั๊มพญานาค",
                    Power = "5001-6000 / 6.5 - 8",
                    SuctionPipeSize = "7-8",
                    PipelineSize = "7-8",
                    PumpRate = 108.0
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.PetrolPump,
                    PumpType = "ปั๊มหอยโข่ง/ปั๊มพญานาค",
                    Power = "6001-7000 / 8 - 9.5",
                    SuctionPipeSize = "(1/2)-4",
                    PipelineSize = "(1/2)-4",
                    PumpRate = 78.0
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.PetrolPump,
                    PumpType = "ปั๊มหอยโข่ง/ปั๊มพญานาค",
                    Power = "6001-7000 / 8 - 9.5",
                    SuctionPipeSize = "5-6",
                    PipelineSize = "5-6",
                    PumpRate = 90.0
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.PetrolPump,
                    PumpType = "ปั๊มหอยโข่ง/ปั๊มพญานาค",
                    Power = "6001-7000 / 8 - 9.5",
                    SuctionPipeSize = "7-8",
                    PipelineSize = "7-8",
                    PumpRate = 108.0
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.PetrolPump,
                    PumpType = "ปั๊มหอยโข่ง/ปั๊มพญานาค",
                    Power = "7001-8000 / 9.5 - 10.5",
                    SuctionPipeSize = "(1/2)-4",
                    PipelineSize = "(1/2)-4",
                    PumpRate = 84.0
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.PetrolPump,
                    PumpType = "ปั๊มหอยโข่ง/ปั๊มพญานาค",
                    Power = "7001-8000 / 9.5 - 10.5",
                    SuctionPipeSize = "5-6",
                    PipelineSize = "5-6",
                    PumpRate = 96.0
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.PetrolPump,
                    PumpType = "ปั๊มหอยโข่ง/ปั๊มพญานาค",
                    Power = "7001-8000 / 9.5 - 10.5",
                    SuctionPipeSize = "7-8",
                    PipelineSize = "7-8",
                    PumpRate = 114.0
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.PetrolPump,
                    PumpType = "ปั๊มหอยโข่ง/ปั๊มพญานาค",
                    Power = "8001-10000 / 10.5 - 13",
                    SuctionPipeSize = "(1/2)-4",
                    PipelineSize = "(1/2)-4",
                    PumpRate = 114.0
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.PetrolPump,
                    PumpType = "ปั๊มหอยโข่ง/ปั๊มพญานาค",
                    Power = "8001-10000 / 10.5 - 13",
                    SuctionPipeSize = "5-6",
                    PipelineSize = "5-6",
                    PumpRate = 132.0
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.PetrolPump,
                    PumpType = "ปั๊มหอยโข่ง/ปั๊มพญานาค",
                    Power = "8001-10000 / 10.5 - 13",
                    SuctionPipeSize = "7-8",
                    PipelineSize = "7-8",
                    PumpRate = 156.0
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.PetrolPump,
                    PumpType = "ปั๊มหอยโข่ง/ปั๊มพญานาค",
                    Power = "8001-10000 / 10.5 - 13",
                    SuctionPipeSize = "9-10",
                    PipelineSize = "9-10",
                    PumpRate = 180.0
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.PetrolPump,
                    PumpType = "ปั๊มหอยโข่ง/ปั๊มพญานาค",
                    Power = ">10000 / >13",
                    SuctionPipeSize = "(1/2)-6",
                    PipelineSize = "(1/2)-6",
                    PumpRate = 150.0
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.PetrolPump,
                    PumpType = "ปั๊มหอยโข่ง/ปั๊มพญานาค",
                    Power = ">10000 / >13",
                    SuctionPipeSize = "7-8",
                    PipelineSize = "7-8",
                    PumpRate = 168.0
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.PetrolPump,
                    PumpType = "ปั๊มหอยโข่ง/ปั๊มพญานาค",
                    Power = ">10000 / >13",
                    SuctionPipeSize = "9-10",
                    PipelineSize = "9-10",
                    PumpRate = 180.0
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.PetrolPump,
                    PumpType = "ปั๊มหอยโข่ง/ปั๊มพญานาค",
                    Power = ">10000 / >13",
                    SuctionPipeSize = "11-12",
                    PipelineSize = "11-12",
                    PumpRate = 240.0
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.TwoWheeledTractors,
                    PumpType = "ปั๊มหอยโข่ง/ปั๊มพญานาค",
                    Power = "<5500 / <7",
                    SuctionPipeSize = "(1/2)-2",
                    PipelineSize = "(1/2)-2",
                    PumpRate = 36.0
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.TwoWheeledTractors,
                    PumpType = "ปั๊มหอยโข่ง/ปั๊มพญานาค",
                    Power = "<5500 / <7",
                    SuctionPipeSize = "3",
                    PipelineSize = "3",
                    PumpRate = 40.0
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.TwoWheeledTractors,
                    PumpType = "ปั๊มหอยโข่ง/ปั๊มพญานาค",
                    Power = "<5500 / <7",
                    SuctionPipeSize = "4",
                    PipelineSize = "4",
                    PumpRate = 60.0
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.TwoWheeledTractors,
                    PumpType = "ปั๊มหอยโข่ง/ปั๊มพญานาค",
                    Power = "<5500 / <7",
                    SuctionPipeSize = "5-6",
                    PipelineSize = "5-6",
                    PumpRate = 72.0
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.TwoWheeledTractors,
                    PumpType = "ปั๊มหอยโข่ง/ปั๊มพญานาค",
                    Power = "<5500 / <7",
                    SuctionPipeSize = "7-8",
                    PipelineSize = "7-8",
                    PumpRate = 84.0
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.TwoWheeledTractors,
                    PumpType = "ปั๊มหอยโข่ง/ปั๊มพญานาค",
                    Power = "<5500 / <7",
                    SuctionPipeSize = "9-10",
                    PipelineSize = "9-10",
                    PumpRate = 108.0
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.TwoWheeledTractors,
                    PumpType = "ปั๊มหอยโข่ง/ปั๊มพญานาค",
                    Power = "5500-6000 / 7 - 8",
                    SuctionPipeSize = "(1/2)-2",
                    PipelineSize = "(1/2)-2",
                    PumpRate = 42.0
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.TwoWheeledTractors,
                    PumpType = "ปั๊มหอยโข่ง/ปั๊มพญานาค",
                    Power = "5500-6000 / 7 - 8",
                    SuctionPipeSize = "3",
                    PipelineSize = "3",
                    PumpRate = 48.0
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.TwoWheeledTractors,
                    PumpType = "ปั๊มหอยโข่ง/ปั๊มพญานาค",
                    Power = "5500-6000 / 7 - 8",
                    SuctionPipeSize = "4",
                    PipelineSize = "4",
                    PumpRate = 72.0
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.TwoWheeledTractors,
                    PumpType = "ปั๊มหอยโข่ง/ปั๊มพญานาค",
                    Power = "5500-6000 / 7 - 8",
                    SuctionPipeSize = "5-6",
                    PipelineSize = "5-6",
                    PumpRate = 84.0
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.TwoWheeledTractors,
                    PumpType = "ปั๊มหอยโข่ง/ปั๊มพญานาค",
                    Power = "5500-6000 / 7 - 8",
                    SuctionPipeSize = "7-8",
                    PipelineSize = "7-8",
                    PumpRate = 96.0
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.TwoWheeledTractors,
                    PumpType = "ปั๊มหอยโข่ง/ปั๊มพญานาค",
                    Power = "5500-6000 / 7 - 8",
                    SuctionPipeSize = "9-10",
                    PipelineSize = "9-10",
                    PumpRate = 120.0
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.TwoWheeledTractors,
                    PumpType = "ปั๊มหอยโข่ง/ปั๊มพญานาค",
                    Power = "6001-6500 / 8 - 9",
                    SuctionPipeSize = "(1/2)-2",
                    PipelineSize = "(1/2)-2",
                    PumpRate = 48.0
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.TwoWheeledTractors,
                    PumpType = "ปั๊มหอยโข่ง/ปั๊มพญานาค",
                    Power = "6001-6500 / 8 - 9",
                    SuctionPipeSize = "3",
                    PipelineSize = "3",
                    PumpRate = 54.0
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.TwoWheeledTractors,
                    PumpType = "ปั๊มหอยโข่ง/ปั๊มพญานาค",
                    Power = "6001-6500 / 8 - 9",
                    SuctionPipeSize = "4",
                    PipelineSize = "4",
                    PumpRate = 72.0
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.TwoWheeledTractors,
                    PumpType = "ปั๊มหอยโข่ง/ปั๊มพญานาค",
                    Power = "6001-6500 / 8 - 9",
                    SuctionPipeSize = "5-6",
                    PipelineSize = "5-6",
                    PumpRate = 84.0
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.TwoWheeledTractors,
                    PumpType = "ปั๊มหอยโข่ง/ปั๊มพญานาค",
                    Power = "6001-6500 / 8 - 9",
                    SuctionPipeSize = "7-8",
                    PipelineSize = "7-8",
                    PumpRate = 96.0
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.TwoWheeledTractors,
                    PumpType = "ปั๊มหอยโข่ง/ปั๊มพญานาค",
                    Power = "6001-6500 / 8 - 9",
                    SuctionPipeSize = "9-10",
                    PipelineSize = "9-10",
                    PumpRate = 120.0
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.TwoWheeledTractors,
                    PumpType = "ปั๊มหอยโข่ง/ปั๊มพญานาค",
                    Power = "6501-7000 / 9 - 9.5",
                    SuctionPipeSize = "(1/2)-2",
                    PipelineSize = "(1/2)-2",
                    PumpRate = 54.0
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.TwoWheeledTractors,
                    PumpType = "ปั๊มหอยโข่ง/ปั๊มพญานาค",
                    Power = "6501-7000 / 9 - 9.5",
                    SuctionPipeSize = "3",
                    PipelineSize = "3",
                    PumpRate = 60.0
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.TwoWheeledTractors,
                    PumpType = "ปั๊มหอยโข่ง/ปั๊มพญานาค",
                    Power = "6501-7000 / 9 - 9.5",
                    SuctionPipeSize = "4",
                    PipelineSize = "4",
                    PumpRate = 78.0
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.TwoWheeledTractors,
                    PumpType = "ปั๊มหอยโข่ง/ปั๊มพญานาค",
                    Power = "6501-7000 / 9 - 9.5",
                    SuctionPipeSize = "5-6",
                    PipelineSize = "5-6",
                    PumpRate = 90.0
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.TwoWheeledTractors,
                    PumpType = "ปั๊มหอยโข่ง/ปั๊มพญานาค",
                    Power = "6501-7000 / 9 - 9.5",
                    SuctionPipeSize = "7-8",
                    PipelineSize = "7-8",
                    PumpRate = 108.0
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.TwoWheeledTractors,
                    PumpType = "ปั๊มหอยโข่ง/ปั๊มพญานาค",
                    Power = "6501-7000 / 9 - 9.5",
                    SuctionPipeSize = "9-10",
                    PipelineSize = "9-10",
                    PumpRate = 132.0
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.TwoWheeledTractors,
                    PumpType = "ปั๊มหอยโข่ง/ปั๊มพญานาค",
                    Power = "7001-8000 / 9.5 - 11",
                    SuctionPipeSize = "(1/2)-2",
                    PipelineSize = "(1/2)-2",
                    PumpRate = 66.0
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.TwoWheeledTractors,
                    PumpType = "ปั๊มหอยโข่ง/ปั๊มพญานาค",
                    Power = "7001-8000 / 9.5 - 11",
                    SuctionPipeSize = "3",
                    PipelineSize = "3",
                    PumpRate = 72.0
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.TwoWheeledTractors,
                    PumpType = "ปั๊มหอยโข่ง/ปั๊มพญานาค",
                    Power = "7001-8000 / 9.5 - 11",
                    SuctionPipeSize = "4",
                    PipelineSize = "4",
                    PumpRate = 90.0
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.TwoWheeledTractors,
                    PumpType = "ปั๊มหอยโข่ง/ปั๊มพญานาค",
                    Power = "7001-8000 / 9.5 - 11",
                    SuctionPipeSize = "5-6",
                    PipelineSize = "5-6",
                    PumpRate = 108.0
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.TwoWheeledTractors,
                    PumpType = "ปั๊มหอยโข่ง/ปั๊มพญานาค",
                    Power = "7001-8000 / 9.5 - 11",
                    SuctionPipeSize = "7-8",
                    PipelineSize = "7-8",
                    PumpRate = 120.0
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.TwoWheeledTractors,
                    PumpType = "ปั๊มหอยโข่ง/ปั๊มพญานาค",
                    Power = "7001-8000 / 9.5 - 11",
                    SuctionPipeSize = "9-10",
                    PipelineSize = "9-10",
                    PumpRate = 132.0
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.TwoWheeledTractors,
                    PumpType = "ปั๊มหอยโข่ง/ปั๊มพญานาค",
                    Power = "8001-8500 / 11 - 11.5",
                    SuctionPipeSize = "(1/2)-2",
                    PipelineSize = "(1/2)-2",
                    PumpRate = 78.0
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.TwoWheeledTractors,
                    PumpType = "ปั๊มหอยโข่ง/ปั๊มพญานาค",
                    Power = "8001-8500 / 11 - 11.5",
                    SuctionPipeSize = "3",
                    PipelineSize = "3",
                    PumpRate = 84.0
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.TwoWheeledTractors,
                    PumpType = "ปั๊มหอยโข่ง/ปั๊มพญานาค",
                    Power = "8001-8500 / 11 - 11.5",
                    SuctionPipeSize = "4",
                    PipelineSize = "4",
                    PumpRate = 102.0
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.TwoWheeledTractors,
                    PumpType = "ปั๊มหอยโข่ง/ปั๊มพญานาค",
                    Power = "8001-8500 / 11 - 11.5",
                    SuctionPipeSize = "5-6",
                    PipelineSize = "5-6",
                    PumpRate = 120.0
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.TwoWheeledTractors,
                    PumpType = "ปั๊มหอยโข่ง/ปั๊มพญานาค",
                    Power = "8001-8500 / 11 - 11.5",
                    SuctionPipeSize = "7-8",
                    PipelineSize = "7-8",
                    PumpRate = 144.0
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.TwoWheeledTractors,
                    PumpType = "ปั๊มหอยโข่ง/ปั๊มพญานาค",
                    Power = "8001-8500 / 11 - 11.5",
                    SuctionPipeSize = "9-10",
                    PipelineSize = "9-10",
                    PumpRate = 90.0
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.TwoWheeledTractors,
                    PumpType = "ปั๊มหอยโข่ง/ปั๊มพญานาค",
                    Power = "8501-9000 / 11.5 - 12",
                    SuctionPipeSize = "(1/2)-2",
                    PipelineSize = "(1/2)-2",
                    PumpRate = 96.0
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.TwoWheeledTractors,
                    PumpType = "ปั๊มหอยโข่ง/ปั๊มพญานาค",
                    Power = "8501-9000 / 11.5 - 12",
                    SuctionPipeSize = "3",
                    PipelineSize = "3",
                    PumpRate = 1600
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.TwoWheeledTractors,
                    PumpType = "ปั๊มหอยโข่ง/ปั๊มพญานาค",
                    Power = "8501-9000 / 11.5 - 12",
                    SuctionPipeSize = "4",
                    PipelineSize = "4",
                    PumpRate = 114.0
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.TwoWheeledTractors,
                    PumpType = "ปั๊มหอยโข่ง/ปั๊มพญานาค",
                    Power = "8501-9000 / 11.5 - 12",
                    SuctionPipeSize = "5-6",
                    PipelineSize = "5-6",
                    PumpRate = 120.0
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.TwoWheeledTractors,
                    PumpType = "ปั๊มหอยโข่ง/ปั๊มพญานาค",
                    Power = "8501-9000 / 11.5 - 12",
                    SuctionPipeSize = "7-8",
                    PipelineSize = "7-8",
                    PumpRate = 132.0
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.TwoWheeledTractors,
                    PumpType = "ปั๊มหอยโข่ง/ปั๊มพญานาค",
                    Power = "8501-9000 / 11.5 - 12",
                    SuctionPipeSize = "9-10",
                    PipelineSize = "9-10",
                    PumpRate = 144.0
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.TwoWheeledTractors,
                    PumpType = "ปั๊มหอยโข่ง/ปั๊มพญานาค",
                    Power = "8501-9000 / 11.5 - 12",
                    SuctionPipeSize = "11-12",
                    PipelineSize = "11-12",
                    PumpRate = 168.0
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.TwoWheeledTractors,
                    PumpType = "ปั๊มหอยโข่ง/ปั๊มพญานาค",
                    Power = "9001-9500 / 12 - 13",
                    SuctionPipeSize = "(1/2)-2",
                    PipelineSize = "(1/2)-2",
                    PumpRate = 96.0
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.TwoWheeledTractors,
                    PumpType = "ปั๊มหอยโข่ง/ปั๊มพญานาค",
                    Power = "9001-9500 / 12 - 13",
                    SuctionPipeSize = "3",
                    PipelineSize = "3",
                    PumpRate = 102.0
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.TwoWheeledTractors,
                    PumpType = "ปั๊มหอยโข่ง/ปั๊มพญานาค",
                    Power = "9001-9500 / 12 - 13",
                    SuctionPipeSize = "4",
                    PipelineSize = "4",
                    PumpRate = 114.0
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.TwoWheeledTractors,
                    PumpType = "ปั๊มหอยโข่ง/ปั๊มพญานาค",
                    Power = "9001-9500 / 12 - 13",
                    SuctionPipeSize = "5-6",
                    PipelineSize = "5-6",
                    PumpRate = 120.0
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.TwoWheeledTractors,
                    PumpType = "ปั๊มหอยโข่ง/ปั๊มพญานาค",
                    Power = "9001-9500 / 12 - 13",
                    SuctionPipeSize = "7-8",
                    PipelineSize = "7-8",
                    PumpRate = 132.0
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.TwoWheeledTractors,
                    PumpType = "ปั๊มหอยโข่ง/ปั๊มพญานาค",
                    Power = "9001-9500 / 12 - 13",
                    SuctionPipeSize = "9-10",
                    PipelineSize = "9-10",
                    PumpRate = 144.0
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.TwoWheeledTractors,
                    PumpType = "ปั๊มหอยโข่ง/ปั๊มพญานาค",
                    Power = "9001-9500 / 12 - 13",
                    SuctionPipeSize = "11-12",
                    PipelineSize = "11-12",
                    PumpRate = 168.0
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.TwoWheeledTractors,
                    PumpType = "ปั๊มหอยโข่ง/ปั๊มพญานาค",
                    Power = "9501-11000 / 13 - 15",
                    SuctionPipeSize = "(1/2)-2",
                    PipelineSize = "(1/2)-2",
                    PumpRate = 120.0
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.TwoWheeledTractors,
                    PumpType = "ปั๊มหอยโข่ง/ปั๊มพญานาค",
                    Power = "9501-11000 / 13 - 15",
                    SuctionPipeSize = "3",
                    PipelineSize = "3",
                    PumpRate = 126.0
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.TwoWheeledTractors,
                    PumpType = "ปั๊มหอยโข่ง/ปั๊มพญานาค",
                    Power = "9501-11000 / 13 - 15",
                    SuctionPipeSize = "4",
                    PipelineSize = "4",
                    PumpRate = 144.0
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.TwoWheeledTractors,
                    PumpType = "ปั๊มหอยโข่ง/ปั๊มพญานาค",
                    Power = "9501-11000 / 13 - 15",
                    SuctionPipeSize = "5-6",
                    PipelineSize = "5-6",
                    PumpRate = 156.0
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.TwoWheeledTractors,
                    PumpType = "ปั๊มหอยโข่ง/ปั๊มพญานาค",
                    Power = "9501-11000 / 13 - 15",
                    SuctionPipeSize = "7-8",
                    PipelineSize = "7-8",
                    PumpRate = 168.0
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.TwoWheeledTractors,
                    PumpType = "ปั๊มหอยโข่ง/ปั๊มพญานาค",
                    Power = "9501-11000 / 13 - 15",
                    SuctionPipeSize = "9-10",
                    PipelineSize = "9-10",
                    PumpRate = 180.0
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.TwoWheeledTractors,
                    PumpType = "ปั๊มหอยโข่ง/ปั๊มพญานาค",
                    Power = "9501-11000 / 13 - 15",
                    SuctionPipeSize = "11-12",
                    PipelineSize = "11-12",
                    PumpRate = 210.0
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.TwoWheeledTractors,
                    PumpType = "ปั๊มหอยโข่ง/ปั๊มพญานาค",
                    Power = "11001-12000 / 15 - 16",
                    SuctionPipeSize = "(1/2)-2",
                    PipelineSize = "(1/2)-2",
                    PumpRate = 138.0
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.TwoWheeledTractors,
                    PumpType = "ปั๊มหอยโข่ง/ปั๊มพญานาค",
                    Power = "11001-12000 / 15 - 16",
                    SuctionPipeSize = "3",
                    PipelineSize = "3",
                    PumpRate = 144.0
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.TwoWheeledTractors,
                    PumpType = "ปั๊มหอยโข่ง/ปั๊มพญานาค",
                    Power = "11001-12000 / 15 - 16",
                    SuctionPipeSize = "4",
                    PipelineSize = "4",
                    PumpRate = 162.0
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.TwoWheeledTractors,
                    PumpType = "ปั๊มหอยโข่ง/ปั๊มพญานาค",
                    Power = "11001-12000 / 15 - 16",
                    SuctionPipeSize = "5-6",
                    PipelineSize = "5-6",
                    PumpRate = 174.0
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.TwoWheeledTractors,
                    PumpType = "ปั๊มหอยโข่ง/ปั๊มพญานาค",
                    Power = "11001-12000 / 15 - 16",
                    SuctionPipeSize = "7-8",
                    PipelineSize = "7-8",
                    PumpRate = 186.0
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.TwoWheeledTractors,
                    PumpType = "ปั๊มหอยโข่ง/ปั๊มพญานาค",
                    Power = "11001-12000 / 15 - 16",
                    SuctionPipeSize = "9-10",
                    PipelineSize = "9-10",
                    PumpRate = 210.0
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.TwoWheeledTractors,
                    PumpType = "ปั๊มหอยโข่ง/ปั๊มพญานาค",
                    Power = "11001-12000 / 15 - 16",
                    SuctionPipeSize = "11-12",
                    PipelineSize = "11-12",
                    PumpRate = 228.0
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.TwoWheeledTractors,
                    PumpType = "ปั๊มหอยโข่ง/ปั๊มพญานาค",
                    Power = ">12000 / >16",
                    SuctionPipeSize = "(1/2)-2",
                    PipelineSize = "(1/2)-2",
                    PumpRate = 150.0
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.TwoWheeledTractors,
                    PumpType = "ปั๊มหอยโข่ง/ปั๊มพญานาค",
                    Power = ">12000 / >16",
                    SuctionPipeSize = "3",
                    PipelineSize = "3",
                    PumpRate = 156.0
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.TwoWheeledTractors,
                    PumpType = "ปั๊มหอยโข่ง/ปั๊มพญานาค",
                    Power = ">12000 / >16",
                    SuctionPipeSize = "4",
                    PipelineSize = "4",
                    PumpRate = 174.0
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.TwoWheeledTractors,
                    PumpType = "ปั๊มหอยโข่ง/ปั๊มพญานาค",
                    Power = ">12000 / >16",
                    SuctionPipeSize = "5-6",
                    PipelineSize = "5-6",
                    PumpRate = 186.0
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.TwoWheeledTractors,
                    PumpType = "ปั๊มหอยโข่ง/ปั๊มพญานาค",
                    Power = ">12000 / >16",
                    SuctionPipeSize = "7-8",
                    PipelineSize = "7-8",
                    PumpRate = 210.0
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.TwoWheeledTractors,
                    PumpType = "ปั๊มหอยโข่ง/ปั๊มพญานาค",
                    Power = ">12000 / >16",
                    SuctionPipeSize = "9-10",
                    PipelineSize = "9-10",
                    PumpRate = 228.0
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.TwoWheeledTractors,
                    PumpType = "ปั๊มหอยโข่ง/ปั๊มพญานาค",
                    Power = ">12000 / >16",
                    SuctionPipeSize = "11-12",
                    PipelineSize = "11-12",
                    PumpRate = 240.0
            }
        };

    }
}