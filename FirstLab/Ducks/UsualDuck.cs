using DuckLibrary.Flying;
using DuckLibrary.Quacking;
using DuckLibrary.Swimming;
using System;

namespace DuckLibrary.Ducks
{
    public class UsualDuck : BaseDuck
    {
        public UsualDuck() : base(new FlyHigh(), new Quack(), new Swim())
        {
        }

        public override void Display()
        {
            Console.WriteLine("Обычная Утка.");
        }
    }
}
