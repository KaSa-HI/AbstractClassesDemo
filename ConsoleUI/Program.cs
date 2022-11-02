using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Todo follow all comments!! 
             */

            #region Vehicles

            /*
             * Create an abstract class called Vehicle
             * The vehicle class shall have three string properties Year, Make, and Model
             * Set the defaults to something generic in the Vehicle class
             * Vehicle shall have an abstract method called DriveAbstract with no implementation
             * Vehicle shall have a virtual method called DriveVirtual with a base implementation.
             */

            /* 
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             * Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             * Provide the implementations for the abstract methods
             * Only in the Motorcycle class will you override the virtual drive method
            */

            // Create a list of Vehicle called vehicles
            


            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * - set them up as one of each derived class
             * Set the properties with object initializer syntax
             */
            
            Car car = new Car();
            car.Make = "Honda";
            car.Year = "1963";
            car.Model = "S500";
            car.HasTrunk = true;
            Console.WriteLine(car.Make);
            Console.WriteLine(car.Year);
            car.DriveAbstract();
            Console.WriteLine();

            Vehicle Honda = new Car();
            Honda.Make = "Honda";
            Honda.Year = "1964";
            Honda.Model = "Gran Turismo";
            Honda.NumWheels = 4;
            Console.WriteLine(Honda.Make);
            Console.WriteLine(Honda.Year);
            Honda.DriveAbstract();
            Console.WriteLine();

            Motorcyle Ducati = new Motorcyle();
            Ducati.Make = "Ducati";
            Ducati.Year = "2020";
            Ducati.Model = "SuperSport";
            Ducati.HasSideCart = false;
            Console.WriteLine(Ducati.Make);
            Console.WriteLine(Ducati.Year);
            Ducati.DriveAbstract();
            Console.WriteLine();

            Motorcyle Yamaha = new Motorcyle();
            Yamaha.Make = "Yamaha";
            Yamaha.Year = "2006";
            Yamaha.Model = "YZF R6";
            Yamaha.HasSideCart = false;
            Console.WriteLine(Yamaha.Make);
            Console.WriteLine(Yamaha.Year);
            Yamaha.DriveAbstract();
            Console.WriteLine();

            

            var vehicle = new List<Vehicle>();

            vehicle.Add(car);
            vehicle.Add(Honda);
            vehicle.Add(Yamaha);
            vehicle.Add(Ducati);

            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate over each of the properties
             */


            foreach (var veh in vehicle)
            {
                Console.WriteLine($"{veh.Year} {veh.Make} {veh.Model}");
                veh.DriveAbstract();
                veh.DriveVirtual();
                Console.WriteLine("----------------------------------");
                Console.WriteLine();
            }
            {

            }
            // Call each of the drive methods for one car and one motorcycle

            #endregion            
            Console.ReadLine();
        }
    }
}
