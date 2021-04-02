using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    class Motorcycle : Vehicle
    {
        public override int Year { get; set; }
        public override string Make { get; set; }
        public override string Model { get; set; }
        public bool HasSideCart { get; set; } = false;

        public Motorcycle(int year, string make, string model, bool hasSideCart)
        {
            Year = year;
            Make = make;
            Model = model;
            HasSideCart = hasSideCart;
        }
        public override void DriveAbstract()
        {
            Console.WriteLine($"The Motorcycle is: {Year} {Make} {Model} and {GetSideCart()}");            
        }

        public override void DriveVirtual()
        {
                     
        }

        private string GetSideCart()
        {
            return HasSideCart ? "It has a sidecar." : "It doesn't have a sidecar.";
        }

    }
}
