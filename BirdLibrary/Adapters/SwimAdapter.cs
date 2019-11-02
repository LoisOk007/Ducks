using DuckLibrary.Swimming;
using System;

namespace BirdLibrary.Adapters
{
    public class SwimAdapter : ISwimming
    {
        BaseBird _bird;
        public SwimAdapter(BaseBird bird)
        {
            _bird = bird ?? throw new ArgumentNullException();
        }
        public void Swim()
        {
            _bird.Swim();
        }
    }
}
