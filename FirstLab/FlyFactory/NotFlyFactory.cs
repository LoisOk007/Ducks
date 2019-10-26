using DuckLibrary.Flying;

namespace DuckLibrary.FlyFactory
{
    public class NotFlyFactory : IFlyFactory
    {
        public IFlying Create(FlyType fly)
        {
            return new NotFly();
        }
    }
}
