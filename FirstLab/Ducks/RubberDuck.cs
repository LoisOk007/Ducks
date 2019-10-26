using System;
using DuckLibrary.Flying;
using DuckLibrary.Quacking;
using DuckLibrary.Swimming;

namespace DuckLibrary.Ducks
{
    public class RubberDuck : BaseDuck
    {
        public RubberDuck() : base(new NotFly(), new FakeQuack(), new Swim())
        {
        }

        public override void Display()
        {
            Console.WriteLine("Резиновая Уточка.");
        }
    }
}
