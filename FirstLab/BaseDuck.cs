using DuckLibrary.Flying;
using DuckLibrary.Quacking;
using DuckLibrary.Swimming;
using System;

namespace DuckLibrary
{
    internal abstract class BaseDuck : IDuck
    {
        public readonly IFlying _fly;
        public readonly ISwimming _swim;
        public readonly IQuacking _quack;
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
        public virtual void Display() { }
    }
}
