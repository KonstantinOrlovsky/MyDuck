using System;

namespace MyDuck.Duck
{
    class ExoticDuck:BaseDuck
    {
        public ExoticDuck() => sayable = new Say.ExoticSay();
        public override void Display() => Console.WriteLine("Exotic duck was created!!!");
    }
}
