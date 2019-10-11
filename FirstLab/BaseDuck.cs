using FirstLab.Flying;
using FirstLab.Quacking;
using FirstLab.Swimming;
using System;

namespace FirstLab
{
    public abstract class BaseDuck:IFlying,ISwimming,IQuacking
    {
        IFlying _fly;
        ISwimming _swim;
        IQuacking _quack;
        protected BaseDuck(IFlying fly,IQuacking quack,ISwimming swim)
        {
            if (fly == null)
                throw new ArgumentNullException();
            if (quack == null)
                throw new ArgumentNullException();
            if (swim == null)
                throw new ArgumentNullException();
            _fly = fly;
            _swim = swim;
            _quack = quack;
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
