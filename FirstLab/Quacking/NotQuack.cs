using System;

namespace FirstLab.Quacking
{
    public class NotQuack : IQuacking
    {
        public void Quack()
        {
            Console.WriteLine("Не крякаю.");
        }
    }
}
