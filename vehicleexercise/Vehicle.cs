
//1. Move all common properties in your vehicles to a new Vehicle class.


namespace Garage
{
    public class Vehicle //new vehicle class
    {
        public string MainColor { get; set; } //all have a Main Color property
        public int MaximumOccupancy { get; set; } //all have a max occupancy class

        public virtual void Drive() // Create a Drive() method in the Vehicle class.

        {
            Console.WriteLine("Vrooom!");

        }
    }
public interface iElectric
{

        double BatteryKWh { get; set; }
        double BatteryPercent { get; set;}
       public void ChargeBattery()
         {
            BatteryPercent = 100.00;
       
        }

}

public interface iGas

{

        public double FuelCapacity { get; set; }
        double TankPercent {get; set;}
        
        public void RefuelTank() {

            TankPercent = 100.00;
       
        }

}

}