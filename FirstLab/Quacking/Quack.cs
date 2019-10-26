using System;

namespace DuckLibrary.Quacking
{
    public class Quack : IQuacking
    {
        void IQuacking.Quack()
        {
            Console.WriteLine("Кря-Кря.");
        }
    }
}
