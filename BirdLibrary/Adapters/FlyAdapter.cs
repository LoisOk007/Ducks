using DuckLibrary.Flying;
using System;

namespace BirdLibrary.Adapters
{
    public class FlyAdapter : IFlying
    {
        BaseBird _bird;
        public FlyAdapter(BaseBird bird)
        {
            _bird = bird ?? throw new ArgumentNullException();
        }
        public void Fly()
        {
            _bird.Fly();
        }
    }
}
