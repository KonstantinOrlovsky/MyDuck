using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDuck
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Duck.BaseDuck> duck = new List<Duck.BaseDuck>();
            duck.Add(new Duck.SimpleDuck());
            duck.Add(new Duck.ExoticDuck());
            duck.Add(new Duck.ToyDuck());
            duck.Add(new Duck.WoodDuck());
            foreach(var ducks in duck)
            {
                ducks.Display();
                ducks.Swim();
                ducks.Say();
                ducks.Fly();

                Console.WriteLine();
            }
            Duck.BaseDuck upgreatDuck = new Duck.UpgratableDuck();
            upgreatDuck.Display();
            upgreatDuck.Swim();
            upgreatDuck.Say();
            upgreatDuck.Fly();
            upgreatDuck.SetSaying(new Say.ExoticSay());

            upgreatDuck.Fly();
            upgreatDuck.Say();



            Console.Read();

        }
    }
}
