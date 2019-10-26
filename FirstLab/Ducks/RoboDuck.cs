using DuckLibrary.Flying;
using DuckLibrary.Quacking;
using DuckLibrary.Swimming;
using System;

namespace DuckLibrary.Ducks
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
