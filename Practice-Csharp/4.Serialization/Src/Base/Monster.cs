using System;
using _4.Serialization.Interfaces;

namespace _4.Serialization.Base
{
    public abstract class Monster
    {
        public Abilities.Abilities Abilities;
        public abstract int ArmorCount { get; }
        public abstract int HitPoints { get; }
        public abstract int Speed { get; }
        public abstract ISkill[] Skills { get; }
        public abstract Action Action { get; }
    }
}