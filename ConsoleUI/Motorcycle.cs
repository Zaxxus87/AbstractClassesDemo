using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    class Motorcycle : Vehicle
    {
        public bool HasSideCart { get; set; }
        public Motorcycle()
        {

        }
        public Motorcycle(string y, string mk, string mdl)
        {
            Year = y;
            Make = mk;
            Model = mdl;
        }

        public override void DriveAbstract()
        {
            Console.WriteLine("Driving Motorcycle");
        }
        public virtual void DriveVirtual()
        {
            Console.WriteLine("Motorcycle Driving Virtual");
        }
    }
}
