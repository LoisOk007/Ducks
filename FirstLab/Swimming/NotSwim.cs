using System;

namespace DuckLibrary.Swimming
{
    public class NotSwim : ISwimming
    {
        public void Swim()
        {
            Console.WriteLine("Я не умею плавать.");
        }
    }
}
