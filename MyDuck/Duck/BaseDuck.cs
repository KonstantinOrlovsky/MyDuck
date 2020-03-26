using System;

namespace MyDuck.Duck
{
    public abstract class BaseDuck
    {
        protected Say.ISayable sayable;
        protected Fly.IFlyable flyable;
        public abstract void Display();
        public BaseDuck()
        {
            sayable = new Say.Say();
            flyable = new Fly.Fly();
        }
        public void SetFlying() => flyable = new Fly.Fly();
        public void SetSaying(Say.ISayable say) => sayable = say;
        public void Say() => sayable.Say();
        public void Fly() => flyable.Fly();
        public void Swim() => Console.WriteLine("I'm swiming!!!");
    }
}
