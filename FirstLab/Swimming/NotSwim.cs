using System;

namespace FirstLab.Swimming
{
    class NotSwim : ISwimming
    {
        public void Swim()
        {
            Console.WriteLine("Я не умею плавать.");
        }
    }
}
