using System;

namespace DuckLibrary.Swimming
{
    public class Swim : ISwimming
    {
        void ISwimming.Swim()
        {
            Console.WriteLine("Я умею плавать.");
        }
    }
}
