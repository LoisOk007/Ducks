using System;

namespace FirstLab.Quacking
{
    public class FakeQuack : IQuacking
    {
        public void Quack()
        {
            Console.WriteLine("Крья-Крья");
        }
    }
}
