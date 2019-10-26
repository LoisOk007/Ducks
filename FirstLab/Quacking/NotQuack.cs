using System;

namespace DuckLibrary.Quacking
{
    public class NotQuack : IQuacking
    {
        public void Quack()
        {
            Console.WriteLine("Не крякаю.");
        }
    }
}
