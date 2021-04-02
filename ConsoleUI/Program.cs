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
            
            
            Car car = new Car(2017, "Marcedenz", "Bnz", true);
            Motorcycle motorcycle = new Motorcycle(2021, "Bike", "Bk", false);
            
            Vehicle car1 = new Car(2001, "Toyota", "Camry", true);
            Vehicle motorcycle1 = new Motorcycle(2018, "Mtbs", "Mt", true);

            var vehicles = new List<Vehicle>();

            vehicles.Add(car);
            vehicles.Add(car1);
            vehicles.Add(motorcycle);
            vehicles.Add(motorcycle1);
            
            foreach (Vehicle item in vehicles)
            {
                item.DriveAbstract();
                item.DriveVirtual();
            }

            Console.WriteLine($"The number of cars are: {vehicles.Count()}");

                        //Console.WriteLine(car.Year = 2018);
            //Console.WriteLine(car.Make = "Toyota");
            //Console.WriteLine(car.Model = "Camry");

            //Console.WriteLine(motorcycle.Year = 2010);
            //Console.WriteLine(motorcycle.Make = "BMW");
            //Console.WriteLine(motorcycle.Model = "BMW CSV");

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
             * - new it up as one of each derived class
             * Set the properties with object initializer syntax
             */

            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate over each of the properties
             */

            // Call each of the drive methods for one car and one motorcycle

            #endregion
            // Console.ReadLine();
        }
    }
}
