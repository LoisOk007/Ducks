using System;
using FirstLab.Flying;
using FirstLab.Quacking;
using FirstLab.Swimming;

namespace FirstLab.Ducks
{
    public class DecoyDuck : BaseDuck
    {
        public DecoyDuck() : base(new NotFly(), new FakeQuack(), new NotSwim())
        {
        }

        public override void Display()
        {
            Console.WriteLine("Утка-приманка");
        }
    }
}
