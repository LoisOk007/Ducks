using System;

namespace FirstLab.Quacking
{
    public class Quack : IQuacking
    {
        void IQuacking.Quack()
        {
            Console.WriteLine("Кря-Кря.");
        }
    }
}
