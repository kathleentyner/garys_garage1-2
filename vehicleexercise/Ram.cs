namespace Garage
{
    public class Ram : iGas // Gas powered truck
    {
        public double FuelCapacity { get; set; }
         public double TankPercent { get; set; }

        public void RefuelTank()
        {
          Console.WriteLine($"Why did I get this gas hog ram? Where did all my monies go? You only have {TankPercent}% in your gas tank");
        }

        //   public override void Drive()
        // {
        //     Console.WriteLine($"The {MainColor} Ram rumbles past.");
        // }
    }
}