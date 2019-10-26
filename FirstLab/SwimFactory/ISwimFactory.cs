using DuckLibrary.Swimming;

namespace DuckLibrary.SwimFactory
{
    public enum SwimType
    {
        Default = 0,
        Swim,
        NotSwim,
        RoboSwim
    }
    public interface ISwimFactory
    {
        ISwimming Create(SwimType swim);
    }
}
