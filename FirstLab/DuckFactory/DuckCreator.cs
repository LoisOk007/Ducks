using DuckLibrary.Ducks;
using DuckLibrary.FlyFactory;
using DuckLibrary.Flying;
using DuckLibrary.QuackFactory;
using DuckLibrary.Quacking;
using DuckLibrary.SwimFactory;
using DuckLibrary.Swimming;

namespace DuckLibrary.DuckFactory
{
    public class DuckCreator : IDuckFactory
    {
        IFlyFactory _fly;
        IQuackFactory _quack;
        ISwimFactory _swim;
        public DuckCreator(IFlyFactory fly,IQuackFactory quack,ISwimFactory swim)
        {
            _fly = fly;
            _quack = quack;
            _swim = swim;
        }
        public BaseDuck Create(FlyType fly, QuackType quack, SwimType swim)
        {
            IFlying flying = _fly.Create(fly);
            IQuacking quacking = _quack.Create(quack);
            ISwimming swimming = _swim.Create(swim);
            return new UniversalDuck(flying, quacking, swimming);
        }
    }
}
