using System;

namespace Garage
{
    public class Tesla : iElectric
    {        
        public double BatteryKWh { get; set; }
        public double BatteryPercent {get; set; }
        public void ChargeBattery()
{
 
 Console.WriteLine($"Saving $$. Your Tesla's battery at {BatteryPercent}");

}

//           public override void Drive()
//         {
//             Console.WriteLine($"The {MainColor} Tesla sneaks past.");
//         }
    }
} 