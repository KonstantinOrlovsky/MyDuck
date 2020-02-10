using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDuck.Duck
{
    class ExoticDuck:BaseDuck
    {
        public ExoticDuck()
        {
            sayable = new Say.ExoticSay();
        }
        public override void Display()
        {
           
            Console.WriteLine("Exotic duck was created!!!");

        }
    }
}
