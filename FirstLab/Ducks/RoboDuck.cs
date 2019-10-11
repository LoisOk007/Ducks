using FirstLab.Flying;
using FirstLab.Quacking;
using FirstLab.Swimming;
using System;

namespace FirstLab.Ducks
{
    public class RoboDuck : BaseDuck
    {
        public RoboDuck() : base(new RoboFly(), new RoboQuack(), new RoboSwim())
        {
        }

        public override void Display()
        {
            Console.WriteLine("Робо-Утка.");
        }
    }
}
