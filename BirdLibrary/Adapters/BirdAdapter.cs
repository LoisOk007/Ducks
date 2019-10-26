using DuckLibrary;
using DuckLibrary.Flying;
using DuckLibrary.Quacking;
using DuckLibrary.Swimming;
using System;

namespace BirdLibrary.Adapters
{
    public class BirdAdapter : IAdapter
    {
        BaseBird _bird;
        public BirdAdapter(BaseBird bird)
        {
            _bird = bird ?? throw new ArgumentNullException();
        }

        public void Display()
        {
            _bird.Display();
        }

        public void Quack()
        {
            _bird.Sound();
        }
    }
}
