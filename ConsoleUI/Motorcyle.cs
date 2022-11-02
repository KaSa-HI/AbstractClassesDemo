using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public class Motorcyle : Vehicle
    {
        public override void DriveAbstract()
        {
            Console.WriteLine("This motorcyle is driving abstractly");
        }
        public bool HasSideCart = false;

        public virtual void DriveVirtual()
        {
            Console.WriteLine($"This {GetType().Name} is a {GetType().BaseType.Name} and drives virtually");
        }
    }
}
