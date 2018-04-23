 

using _4.Serialization.Base;
using _4.Serialization.Interfaces;

namespace _4.Serialization.Equipment.Weapons
{
    public abstract class Weapon : IWeapon
    {
        public abstract bool IsRanged { get; }
        public abstract IRollable Damage { get; }
        public abstract DamageType DamageType { get; }
        public abstract object[] SpecialProperties { get; }
        public abstract string Name { get; }
        public abstract int Cost { get; }
        public abstract int Weight { get; }
    }
}