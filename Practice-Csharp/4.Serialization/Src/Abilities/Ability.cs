using System;

namespace _4.Serialization
{
    public class Ability : IAbility
    {
        public Type Type => GetType();
        public int Value => Score;
        public int Score => Extensions.Roll4AddTop3;
        public int Modifier => (Score - 10) / 2;
    }
}