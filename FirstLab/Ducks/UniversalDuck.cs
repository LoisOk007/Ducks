using System;
using DuckLibrary.Flying;
using DuckLibrary.Quacking;
using DuckLibrary.Swimming;

namespace DuckLibrary.Ducks
{
    class UniversalDuck : BaseDuck
    {
        public UniversalDuck(IFlying fly, IQuacking quack, ISwimming swim) : base(fly, quack, swim)
        {
        }

        public override void Display()
        {
            Console.WriteLine("Универсальная уточка.");
        }
    }
}
