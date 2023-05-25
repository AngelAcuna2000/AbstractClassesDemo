using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
            /*
            * Create an abstract class called Vehicle
            * The vehicle class shall have three string properties Year, Make, and Model
            * Set the defaults to something generic in the Vehicle class
            * Vehicle shall have an abstract method called DriveAbstract with no implementation
            * Vehicle shall have a virtual method called DriveVirtual with a base implementation.
            */
    public abstract class Vehicle
    {
        public string Year { get; set; } = "2023";
        public string Make { get; set; } = "Generic Make";
        public string Model { get; set; } = "Generic Model";

        public abstract void DriveAbstract();

        public virtual void DriveVirtual()
        {
            Console.WriteLine("This is my virtual method in my Vehicle Class");
        }
    }
}
