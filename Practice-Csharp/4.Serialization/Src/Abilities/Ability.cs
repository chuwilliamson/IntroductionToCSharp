using System;
using _4.Serialization.Base;
using _4.Serialization.Interfaces;

namespace _4.Serialization.Abilities
{
    public class Ability : IAbility
    {
        public Type Type => GetType();
        public int Value => Score;
        public int Score => Extensions.Roll4AddTop3;
        public int Modifier => (Score - 10) / 2;
    }
}