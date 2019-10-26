using DuckLibrary.Flying;
using DuckLibrary.Quacking;
using DuckLibrary.Swimming;
using System;

namespace DuckLibrary.Ducks
{
    public class WoodenDuck : BaseDuck
    {
        public WoodenDuck() : base(new NotFly(), new NotQuack(), new Swim())
        {
        }

        public override void Display()
        {
            Console.WriteLine("Деревянная уточка.");
        }
    }
}
