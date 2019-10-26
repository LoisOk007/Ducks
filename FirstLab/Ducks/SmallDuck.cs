using DuckLibrary.Flying;
using DuckLibrary.Quacking;
using DuckLibrary.Swimming;
using System;

namespace DuckLibrary.Ducks
{
    public class SmallDuck : BaseDuck
    {
        public SmallDuck() : base(new FlyLow(), new Quack(), new Swim())
        {
        }

        public override void Display()
        {
            Console.WriteLine("Маленькая Уточка.");
        }
    }
}
