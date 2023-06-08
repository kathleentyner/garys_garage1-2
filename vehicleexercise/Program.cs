namespace Garage
{
    class Program
    {
        static void Main(string[] args) 
        {

// Create an instance of each vehicle. 
// Define a different value for each vehicle's properties.

Cessna cessna150 = new Cessna();
cessna150.FuelCapacity = 22.2; 
// cessna150.MainColor = "red"; 
// cessna150.MaximumOccupancy = 4;
cessna150.TankPercent = 10.5;

Ram ram = new Ram (); 
ram.FuelCapacity = 25.5; 
// ram.MainColor = "blue"; 
// ram.MaximumOccupancy = 5;
ram.TankPercent = 15.5;

Tesla modelS = new Tesla (); 
modelS.BatteryKWh = 4.4; 
// modelS.MainColor = "black"; 
// modelS.MaximumOccupancy = 8;
modelS.BatteryPercent = 62.6; 

Zero fxs= new Zero (); 
fxs.BatteryKWh = 5.7; 
// fxs.MainColor = "silver"; 
// fxs.MaximumOccupancy = 2; 
fxs.BatteryPercent = 43.5;
    

 List<iElectric> electricVehicles = new List<iElectric>() 
 {
    modelS, fxs 

};

            Console.WriteLine("Electric Vehicles");
            foreach(iElectric ev in electricVehicles)
            {
                Console.WriteLine($"{ev.BatteryPercent}");
            }

            foreach(iElectric ev in electricVehicles)
            {
                // This should charge the vehicle to 100%
                ev.ChargeBattery();
            }

            foreach(iElectric ev in electricVehicles)
            {
                Console.WriteLine($"{ev.BatteryPercent}");
            }

            /***********************************************/



            List<iGas> gasVehicles = new List<iGas>() {
                ram, cessna150
            };

            Console.WriteLine("Gas Vehicles");
            foreach(iGas gv in gasVehicles)
            {
                Console.WriteLine($"{gv.TankPercent}");
            }

            foreach(iGas gv in gasVehicles)
            {
                // This should completely refuel the gas tank
                gv.RefuelTank();
            }

            foreach(iGas gv in gasVehicles)
            {
                Console.WriteLine($"{gv.TankPercent}");
            }
        }
    }
}


