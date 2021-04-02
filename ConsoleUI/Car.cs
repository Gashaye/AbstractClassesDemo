using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    class Car : Vehicle
    {
        public override int Year { get; set; }
        public override string Make { get; set; }

        public override string Model { get; set; }

        public bool HasTrunk { get; set; } = true;

        public Car(int year, string make, string model, bool hasTrunk)
        {
            Year = year;
            Make = make;
            Model = model; 
            HasTrunk = hasTrunk;
        }
        public override void DriveAbstract()
        {
            Console.WriteLine($"The car is : {Year} {Make} {Model} and {GetTrunk()}");            
        }

        private string GetTrunk()
        {
            return HasTrunk ? "has Trunk" : "doesn't have Trunk.";            
        }
    }
}
