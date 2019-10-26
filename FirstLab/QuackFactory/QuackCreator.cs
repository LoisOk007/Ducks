using System;
using DuckLibrary.Quacking;

namespace DuckLibrary.QuackFactory
{
    public class QuackCreator : IQuackFactory
    {
        public IQuacking Create(QuackType quack)
        {
            switch (quack)
            {
                case QuackType.Quack:
                    return new Quack();
                case QuackType.NotQuack:
                    return new NotQuack();
                case QuackType.FakeQuack:
                    return new FakeQuack();
                case QuackType.RoboQuack:
                    return new RoboQuack();
                case QuackType.Default:
                    throw new ArgumentNullException();
                default:
                    throw new ArgumentNullException();
            }
        }
    }
}
