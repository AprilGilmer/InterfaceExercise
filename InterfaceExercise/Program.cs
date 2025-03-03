using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var carOne = new Car();
            carOne.Make = "Subaru";
            carOne.Model = "WRX";
            carOne.Year = 2002;
            carOne.WheelCount = 4;
            carOne.Headquarters = "Subaru Headquarters";
            carOne.Logo = "Subaru Logo";
            carOne.HasTrunk = true;
            carOne.TrunkSpace = 10;

            var truckOne = new Truck();
            truckOne.Make = "GMC";
            truckOne.Model = "Sierra";
            truckOne.Year = 2010;
            truckOne.WheelCount = 4;
            truckOne.Headquarters = "GMC Headquarters";
            truckOne.Logo = "GMC Logo";
            truckOne.TruckBedSpace = 20;
            truckOne.HasTruckBed = true;

            var suvOne = new Suv();
            suvOne.Make = "Honda";
            suvOne.Model = "Pilot";
            suvOne.Year = 1993;
            suvOne.WheelCount = 4;
            suvOne.Headquarters = "Honda Headquarters";
            suvOne.Logo = "Honda Logo";
            suvOne.NumberOfRows = 3;
            suvOne.CargoSpace = 30;

            var parkingLot = new List<IVehicle>() { carOne, truckOne, suvOne };

            foreach (var ride in parkingLot)
            {
                Console.WriteLine($"This is a {ride.Make} {ride.Model}, made in the year {ride.Year}.\n");
            }


           

          

            


            //Now, create objects of your 3 classes and give their members values.
            //Creatively display and organize their values
            
            //Option for displaying values: 
            //Create a stubbed out method called DisplayDetails in your IVehicle interface.
            //Implement the stubbed out method in the derived classes.
            //In the scope of them method, use string interpolation to display property values.
            //In order to also interpolate values from ICompany, research how to extend interfaces.
            
        }
    }
}
