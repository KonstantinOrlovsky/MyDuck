using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDuck.Fly
{
    class NoFly:IFlyable
    {
        void IFlyable.Fly()
        {
            Console.WriteLine("...");
        }
    }
}
