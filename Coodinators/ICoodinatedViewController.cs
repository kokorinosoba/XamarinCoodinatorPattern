using System;

namespace Coodinators
{
    public interface ICoodinatedViewController
    {
        public WeakReference<MainCoodinator>? Coodinator { get; set; }
    }
}
