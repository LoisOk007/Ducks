using System;

namespace DuckLibrary.Flying
{
    public class FlyLow : IFlying
    {
        public void Fly()
        {
            Console.WriteLine("Я летаю низко.");
        }
    }
}
