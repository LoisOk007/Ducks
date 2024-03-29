﻿using System;
using DuckLibrary.Flying;
using DuckLibrary.Quacking;
using DuckLibrary.Swimming;

namespace DuckLibrary.Ducks
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
