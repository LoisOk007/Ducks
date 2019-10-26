using System;

namespace DuckLibrary.Flying
{
    public class NotFly : IFlying
    {
        public void Fly()
        {
            Console.WriteLine("Я не умею летать.");
        }
    }
}
