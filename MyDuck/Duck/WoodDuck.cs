using System;

namespace MyDuck.Duck
{
    class WoodDuck:BaseDuck
    {
        public override void Display() => Console.WriteLine("Wood duck was created!!!");
        public WoodDuck()
        {
            sayable = new Say.NoSay();
            flyable = new Fly.NoFly();
        }
    }
}
