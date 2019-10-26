using DuckLibrary.Quacking;

namespace DuckLibrary.QuackFactory
{
    public enum QuackType
    {
        Default=0,
        Quack,
        NotQuack,
        FakeQuack,
        RoboQuack
    }
    public interface IQuackFactory
    {
        IQuacking Create(QuackType quack);
    }
}
