using System;
using DuckLibrary;

namespace BirdLibrary.Adapters
{
    public class DuckToBirdAdapter : IBird
    {
        private readonly IDuck _duck;
        public DuckToBirdAdapter(IDuck duck)
        {
            _duck = duck ?? throw new ArgumentNullException();
        }
        public void Display()
        {
            _duck.Display();
        }

        public void Fly()
        {
            _duck.Fly();
        }

        public void Sound()
        {
            _duck.Quack();
        }

        public void Swim()
        {
            _duck.Swim();
        }
    }
}
