using System;

namespace DuckLibrary.Flying
{
    public class RoboFly : IFlying
    {
        public void Fly()
        {
            Console.WriteLine("Включаю реактивную тягу.");
        }
    }
}
