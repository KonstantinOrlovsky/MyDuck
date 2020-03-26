using System;

namespace MyDuck.Fly
{
    class Fly:IFlyable
    {
        void IFlyable.Fly() => Console.WriteLine("I'm may flying");
    }
}
