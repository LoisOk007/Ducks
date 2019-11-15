using System;
using BirdLibrary.Sound;
using DuckLibrary.Flying;
using DuckLibrary.Swimming;

namespace BirdLibrary.Birds
{
    public class UniversalBird : IBird
    {
        public UniversalBird(IFlying flying, ISound sound, ISwimming swimming) : base(flying, sound, swimming)
        {
        }

        public override void Display()
        {
            Console.WriteLine("Универсальная птица");
        }
    }
}
