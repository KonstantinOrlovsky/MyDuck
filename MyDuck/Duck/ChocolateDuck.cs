using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDuck.Duck
{
    class ChocolateDuck : BaseDuck
    {
        public override void Display() => Console.WriteLine("Chocolate duck was created!!!");
        public ChocolateDuck() => flyable = new Fly.NoFly();
    }
}
