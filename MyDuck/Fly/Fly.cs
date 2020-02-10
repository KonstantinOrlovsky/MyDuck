using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDuck.Fly
{
    class Fly:IFlyable
    {
        void IFlyable.Fly()
        {
            Console.WriteLine("I'm may flying");
        }
    }
}
