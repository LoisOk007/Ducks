using System;

namespace FirstLab.Quacking
{
    public class RoboQuack : IQuacking
    {
        public void Quack()
        {
            Console.WriteLine("Бип-Буп-Кря.");
        }
    }
}
