using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDuck.Say
{
    class ExoticSay:ISayable
    {
        void ISayable.Say()
        {
            Console.WriteLine("Miay -  Miay");
        }
    }
}
