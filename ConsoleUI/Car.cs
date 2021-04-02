using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public class Car : Vehicle
    {
        public Car()
        {


        }

        public Car(string y, string mk, string mdl)
        {
            Year = y;
            Make = mk;
            Model = mdl;
        }
        public bool HasTrunk { get; set; }
        public override void DriveAbstract()
        {
            Console.WriteLine("Driving Car");
        }
    }
}
