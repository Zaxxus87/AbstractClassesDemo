using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public abstract class Vehicle
    {
        public string Year { get; set; } = "2000";
        public string Make { get; set; } = "Ford";
        public string Model { get; set; } = "Focus";

        public abstract void DriveAbstract();
        public virtual void DriveVirtual()
        {
            Console.WriteLine("Generic Driving Virtual");
        }
        
        
    }
}
