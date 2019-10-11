using System;
using FirstLab.Flying;
using FirstLab.Quacking;
using FirstLab.Swimming;

namespace FirstLab.Ducks
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
