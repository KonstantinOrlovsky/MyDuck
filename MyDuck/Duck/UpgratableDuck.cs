using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDuck.Duck
{
    class UpgratableDuck:BaseDuck
    {
        public UpgratableDuck()
        {
            sayable = new Say.NoSay();
            flyable = new Fly.NoFly();
        }
        public override void Display()
        {
            Console.WriteLine("Upgreatable duck was created");

        }
    }
}
