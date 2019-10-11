using System;

namespace FirstLab.Swimming
{
    class Swim : ISwimming
    {
        void ISwimming.Swim()
        {
            Console.WriteLine("Я умею плавать.");
        }
    }
}
