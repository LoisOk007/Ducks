using FirstLab.Flying;
using FirstLab.Quacking;
using FirstLab.Swimming;
using System;

namespace FirstLab.Ducks
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
