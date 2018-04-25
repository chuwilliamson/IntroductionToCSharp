using System;

namespace _4.Serialization.Base
{
    [Serializable]
    public class Proficiency<T>
    {
        public int Amount;
        public T Target;
    }
}