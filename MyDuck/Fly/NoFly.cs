using System;

namespace MyDuck.Fly
{
    class NoFly:IFlyable
    {
        void IFlyable.Fly() => Console.WriteLine("...");
    }
}
