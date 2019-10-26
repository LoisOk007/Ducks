using System;
using DuckLibrary.Swimming;

namespace DuckLibrary.SwimFactory
{
    public class SwimCreator : ISwimFactory
    {
        public ISwimming Create(SwimType swim)
        {
            switch (swim)
            {
                case SwimType.Swim:
                    return new Swim();
                case SwimType.NotSwim:
                    return new NotSwim();
                case SwimType.RoboSwim:
                    return new RoboSwim();
                case SwimType.Default:
                    throw new ArgumentNullException();
                default:
                    throw new ArgumentNullException();
            }
        }
    }
}
