using System;

namespace FirstLab.Flying
{
    class NotFly : IFlying
    {
        public void Fly()
        {
            Console.WriteLine("Я не умею летать.");
        }
    }
}
