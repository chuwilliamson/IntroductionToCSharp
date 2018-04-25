using System;

namespace _4.Serialization.Base
{
    public class Modifier<T> : Modifier
    {
        public override Type AffectedAbility => typeof(T);
    }

    [Serializable]
    public class Modifier
    {
        public virtual Type AffectedAbility { get; set; }
        public virtual int Amount { get; set; }
    }
}