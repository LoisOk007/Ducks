using FirstLab.Flying;
using FirstLab.Quacking;
using FirstLab.Swimming;
using System;

namespace FirstLab.Ducks
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
