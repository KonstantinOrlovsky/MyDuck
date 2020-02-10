using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDuck.Duck
{
    class ToyDuck:BaseDuck
    {
        public ToyDuck()
        {
            flyable = new Fly.NoFly();
        }
        
        public override void Display()
        {
            Console.WriteLine("Toy duck was created!!!");
            
        }
    }
}
