using FirstLab.Flying;
using FirstLab.Quacking;
using FirstLab.Swimming;
using System;

namespace FirstLab.Ducks
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
