using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
           /* 
            * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
            * Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
            * Provide the implementations for the abstract methods
            * Only in the Motorcycle class will you override the virtual drive method
            */
    public class Motorcycle : Vehicle
    {
        public bool HasSideCart { get; set; }

        public override void DriveAbstract()
        {
            Console.WriteLine("This is my abstract method in my Motorcycle class");

        }

        public override void DriveVirtual()
        {
            Console.WriteLine("This is my virtual method in my Motorcycle class");
        }
    }
}
