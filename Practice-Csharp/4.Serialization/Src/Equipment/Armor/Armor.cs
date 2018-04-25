using System;
using _4.Serialization.Abilities;
using _4.Serialization.Base;

namespace _4.Serialization.Equipment.Armor
{
    [Serializable]
    public abstract class Armor : Equipment, IArmor
    {
        public abstract int ArmorClass { get; }
        public abstract Modifier Modifier { get; }
        public abstract Strength Strength { get; }
        public abstract bool Stealth { get; }
        public override string Info => base.Info + string.Format("ArmorClass: {0} Modifier: {1} Strength: {2} Stealth: {3} ", ArmorClass, Modifier, Strength, Stealth);
    }
}