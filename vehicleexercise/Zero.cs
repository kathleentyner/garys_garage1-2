namespace Garage
{
    public class Zero : iElectric
    {
        public double BatteryKWh { get; set; }
        public double BatteryPercent { get; set; }
        public void ChargeBattery()
        {
            Console.WriteLine($"it's so easy being green, your Zero is at {BatteryPercent}");
        }

        //   public override void Drive()
        // {
        //     Console.WriteLine($"The {MainColor} Zero zooms past.");
        // }
    }
}