using System;

namespace DuckLibrary.Quacking
{
    public class RoboQuack : IQuacking
    {
        public void Quack()
        {
            Console.WriteLine("Бип-Буп-Кря.");
        }
    }
}
