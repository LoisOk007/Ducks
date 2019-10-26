using DuckLibrary.FlyFactory;
using DuckLibrary.QuackFactory;
using DuckLibrary.SwimFactory;

namespace DuckLibrary.DuckFactory
{
    public interface IDuckFactory
    {
        BaseDuck Create(FlyType fly,QuackType quack,SwimType swim);
    }
}
