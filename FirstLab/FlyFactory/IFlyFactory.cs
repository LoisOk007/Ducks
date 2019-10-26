using DuckLibrary.Flying;

namespace DuckLibrary.FlyFactory
{
    public enum FlyType
    {
        Default=0,
        FlyHigh,
        FlyLow,
        NotFly,
        RoboFly
    }
    public interface IFlyFactory
    {
        IFlying Create(FlyType fly);
    }
}
