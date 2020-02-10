using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDuck.Say
{
    class Say:ISayable
    {
        void ISayable.Say()
        {
            Console.WriteLine("Krya!!! Krya!!!");
        }
    }
}
