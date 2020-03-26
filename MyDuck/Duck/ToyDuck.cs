using System;

namespace MyDuck.Duck
{
    class ToyDuck:BaseDuck
    {
        public ToyDuck() => flyable = new Fly.NoFly();
        public override void Display() => Console.WriteLine("Toy duck was created!!!");
    }
}
