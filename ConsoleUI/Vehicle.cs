using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public abstract class Vehicle
    {
        public string Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }

        public bool IsDriveable = true;
        public bool HasHorn = true;
        public bool HasAirbag = true;
        public int NumWheels = 4;

        public abstract void DriveAbstract();
        public virtual void DriveVirtual()
        {
            Console.WriteLine("I'm driving this vehicle!");

        }


    }
}

