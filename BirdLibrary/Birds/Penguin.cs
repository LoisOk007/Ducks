using System;
using BirdLibrary.Sound;
using DuckLibrary.Flying;
using DuckLibrary.Swimming;

namespace BirdLibrary.Birds
{
    public class Penguin : BaseBird
    {
        public Penguin() : base(new NotFly(), new PenguinSound(), new Swim())
        {
        }

        public override void Display()
        {
            Console.WriteLine("Пингвин:");
        }
    }
}
