using System;
using DuckLibrary.Flying;

namespace DuckLibrary.FlyFactory
{
    public class FlyCreator : IFlyFactory
    {
        public IFlying Create(FlyType fly)
        {
            switch (fly)
            {

                case FlyType.FlyHigh:
                    return new FlyHigh();
                case FlyType.FlyLow:
                    return new FlyLow();
                case FlyType.NotFly:
                    return new NotFly();
                case FlyType.RoboFly:
                    return new RoboFly();
                case FlyType.Default:
                    throw new ArgumentNullException();
                default:
                    throw new ArgumentNullException();
            }
        }
    }
}
