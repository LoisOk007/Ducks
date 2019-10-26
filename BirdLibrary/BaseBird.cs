using BirdLibrary.Sound;
using DuckLibrary.Flying;
using DuckLibrary.Swimming;
using System;

namespace BirdLibrary
{
    public abstract class BaseBird
    {
        ISound _sound;
        IFlying _fly;
        ISwimming _swim;
        protected BaseBird(IFlying flying, ISound sound, ISwimming swimming)
        {
            _fly = flying ?? throw new ArgumentNullException();
            _sound = sound ?? throw new ArgumentNullException();
            _swim = swimming ?? throw new ArgumentNullException();

        }
        public void Sound()
        {
            _sound.Sound();
        }
        public void Fly()
        {
            _fly.Fly();
        }
        public void Swim()
        {
            _swim.Swim();
        }
        public abstract void Display();
    }
}
