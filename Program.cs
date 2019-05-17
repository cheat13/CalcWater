using System;
using Newtonsoft.Json;

namespace CalcWater
{
    class Program
    {
        static void Main(string[] args)
        {
            var jsonString = @"{ 'plumbing':{ 'mwa':{ 'doing':false,'qualityProblem':{ 'hasProblem':null,'problem':{ 'turbidWater':false,'saltWater':false,'smell':false,'filmOfOil':false,'fogWater':false,'hardWater':false} },'plumbingUsage':{ 'waterQuantity':null,'cubicMeterPerMonth':null,'waterBill':null} },'pwa':{ 'doing':true,'qualityProblem':{ 'hasProblem':false,'problem':{ 'turbidWater':false,'saltWater':false,'smell':false,'filmOfOil':false,'fogWater':false,'hardWater':false} },'plumbingUsage':{ 'waterQuantity':'2','cubicMeterPerMonth':null,'waterBill':'200'} },'other':{ 'doing':false,'qualityProblem':{ 'hasProblem':null,'problem':{ 'turbidWater':false,'saltWater':false,'smell':false,'filmOfOil':false,'fogWater':false,'hardWater':false} },'plumbingUsage':{ 'waterQuantity':null,'cubicMeterPerMonth':null,'waterBill':null} },'waterActivityMWA':{ 'drink':null,'plant':null,'farm':null,'agriculture':null,'product':null,'service':null},'waterActivityPWA':{ 'drink':'50','plant':'50','farm':null,'agriculture':null,'product':null,'service':null},'waterActivityOther':{ 'drink':null,'plant':null,'farm':null,'agriculture':null,'product':null,'service':null},'hasWaterNotRunning':false,'waterNotRunningCount':null},'groundWater':{ 'privateGroundWater':{ 'doing':false,'allCount':null,'waterResourceCount':null,'waterResources':[]},'publicGroundWater':{'doing':false,'waterResourceCount':null,'waterResources':[]}},'pool':{'doing':false,'poolCount':null,'hasSameSize':true,'waterResourceCount':null,'poolSizes':[],'waterResources':[]}}";
            var waterUsage = JsonConvert.DeserializeObject<WaterUsage>(jsonString);

            var residential = new Residential();

            var waterUsageRate = new WaterUsageRate
            {
                // some field from Unit (HouseHoldSample)
                WaterUsage = waterUsage,
                Residence = residential,
                // some field from Building (BuildingSample)
                BuildingType = (BuildingType)1,
            };

            var calc = new CalculateWaterUsage();
            var hasWarning = calc.CalcWaterUsage(waterUsageRate);

            System.Console.WriteLine($"hasWarning is {hasWarning}");
        }
    }
}
