using System;

namespace MyDuck.Duck
{
    class UpgratableDuck:BaseDuck
    {
        public UpgratableDuck()
        {
            sayable = new Say.NoSay();
            flyable = new Fly.NoFly();
        }
        public override void Display() => Console.WriteLine("Upgreatable duck was created");
    }
}
