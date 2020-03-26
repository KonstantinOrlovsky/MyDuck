using System;

namespace MyDuck.Say
{
    class NoSay:ISayable
    {
        void ISayable.Say() => Console.WriteLine("...");
    }
}
