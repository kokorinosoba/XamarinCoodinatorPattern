using System;

namespace Coodinators
{
    public interface IStoryboarded<Self>
    {
        public static Self Instantiate() => throw new NotImplementedException();
    }
}
