using System;

namespace Coodinators
{
    public interface ICoodinatedViewController
    {
        protected WeakReference<MainCoodinator>? _weakCoodinator { get; set; }

        public sealed MainCoodinator Coodinator
        {
            get
            {
                if (_weakCoodinator is null)
                    throw new NullReferenceException($"{nameof(_weakCoodinator)}が設定されていません。");

                if (_weakCoodinator.TryGetTarget(out MainCoodinator coodinator) is false)
                    throw new NullReferenceException($"{nameof(_weakCoodinator)}が設定されていません。");

                return coodinator;
            }
            set => _weakCoodinator = new WeakReference<MainCoodinator>(value);
        }
    }
}
