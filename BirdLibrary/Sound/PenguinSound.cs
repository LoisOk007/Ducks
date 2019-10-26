using System;

namespace BirdLibrary.Sound
{
    class PenguinSound : ISound
    {
        public void Sound()
        {
            Console.WriteLine("Гули-гули по пингвиньи...");
        }
    }
}
