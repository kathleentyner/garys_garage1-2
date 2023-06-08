

namespace Garage
{
    public class Cessna : iGas// Propellor light aircraft. This creates a new instance of each vehicle that includes all propertys
    {public double FuelCapacity { get; set; }
    public double TankPercent { get; set; }
     
        public void RefuelTank()
        {
          Console.WriteLine($"The Cessna is runnig on fumes, don't crash. You only have {TankPercent}% in your gas tank");
        }
    // public override void Drive()
    //     {
    //         Console.WriteLine($"The {MainColor} cessna blazes past.");
    //     }




    }




}    
