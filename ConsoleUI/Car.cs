using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public class Car : Vehicle
    {
        public override void DriveAbstract()
        {
            Console.WriteLine($"This {GetType().Name} is driving abstractly.");
        }
        
            public bool HasTrunk = true;

    }
}
