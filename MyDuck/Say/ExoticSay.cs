using System;

namespace MyDuck.Say
{
    class ExoticSay:ISayable
    {
        void ISayable.Say() => Console.WriteLine("Miay -  Miay");
    }
}
