using DuckLibrary.Quacking;
using System;

namespace BirdLibrary.Adapters
{
    public class SoundAdapter : IQuacking
    {
        BaseBird _bird;
        public SoundAdapter(BaseBird bird)
        {
            _bird = bird ?? throw new ArgumentNullException();
        }
        public void Quack()
        {
            _bird.Sound();
        }
    }
}
