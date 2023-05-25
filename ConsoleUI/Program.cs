﻿using System;
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
             * 
             * Set the properties with object initializer syntax
             */

            var sedan = new Car();
            sedan.Make = "Ford";
            sedan.Model = "Fusion";
            sedan.Year = "2021";
            sedan.HasTrunk = true;

            var harley = new Motorcycle();
            harley.Make = "Harley";
            harley.Model = "Big";
            harley.Year = "2019";
            harley.HasSideCart = false;

            Vehicle toyota = new Car();
            toyota.Make = "Toyota";
            toyota.Model = "Camry";
            toyota.Year = "2011";

            Vehicle porcshe = new Car();
            porcshe.Make = "PorcShe";
            porcshe.Make = "911";
            porcshe.Year = "2015";

            var vehicles = new List<Vehicle>() { porcshe, toyota, harley, sedan };

            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate over each of the properties
             */

            foreach(var ride in vehicles)
            {
                Console.WriteLine($"Make: {ride.Make}\nModel: {ride.Year}\n");
            }


            // Call each of the drive methods for one car and one motorcycle

            #endregion
        }
    }
}
