using System;
using BirdLibrary.Sound;
using DuckLibrary.Flying;
using DuckLibrary.Swimming;

namespace BirdLibrary.Birds
{
    public class Raven : IBird
    {
        public Raven() : base(new FlyHigh(), new RavenSound(), new NotSwim())
        {
        }

        public override void Display()
        {
            Console.WriteLine("Ворон:");
        }
    }
}
