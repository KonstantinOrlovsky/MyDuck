using System;

namespace MyDuck.Say
{
    class Say:ISayable
    {
        void ISayable.Say() => Console.WriteLine("Krya!!! Krya!!!");
    }
}
