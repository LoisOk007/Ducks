using System;
using BirdLibrary.Sound;
using DuckLibrary.Flying;
using DuckLibrary.Swimming;

namespace BirdLibrary.Birds
{
    public class Pigeon : BaseBird
    {
        public Pigeon() : base(new FlyHigh(), new PigeonSound(), new NotSwim())
        {
        }

        public override void Display()
        {
            Console.WriteLine("Голубь:");
        }
    }
}
