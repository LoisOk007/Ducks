using DuckLibrary.Flying;
using DuckLibrary.Quacking;
using DuckLibrary.Swimming;
using System;

namespace DuckLibrary
{
    public abstract class BaseDuck
    {
        IFlying _fly;
        ISwimming _swim;
        IQuacking _quack;
        protected BaseDuck(IFlying fly, IQuacking quack, ISwimming swim)
        {
            _fly = fly ?? throw new ArgumentNullException();
            _swim = swim ?? throw new ArgumentNullException();
            _quack = quack ?? throw new ArgumentNullException();
        }
        public void Fly()
        {
            _fly.Fly();
        }
        public void Swim()
        {
            _swim.Swim();
        }
        public void Quack()
        {
            _quack.Quack();
        }
        public abstract void Display();
    }
}
