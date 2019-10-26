using System;

namespace DuckLibrary.Quacking
{
    public class FakeQuack : IQuacking
    {
        public void Quack()
        {
            Console.WriteLine("Крья-Крья");
        }
    }
}
