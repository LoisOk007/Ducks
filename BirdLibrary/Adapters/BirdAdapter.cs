using DuckLibrary;
using System;

namespace BirdLibrary.Adapters
{
    public class BirdAdapter : BaseDuck
    {
        BaseBird _bird;
        public BirdAdapter(BaseBird bird) : base(new FlyAdapter(bird), new SoundAdapter(bird), new SwimAdapter(bird))
        {
            _bird = bird ?? throw new ArgumentNullException();
        }

        public override void Display()
        {
            _bird.Display();
        }
    }
}
