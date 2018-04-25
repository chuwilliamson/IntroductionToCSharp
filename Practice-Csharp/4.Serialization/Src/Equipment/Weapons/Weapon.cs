using _4.Serialization.Base;

namespace _4.Serialization.Equipment.Weapons
{
    public abstract class Weapon : Equipment, IWeapon
    {
        public abstract bool IsRanged { get; }
        public abstract IRollable Damage { get; }
        public abstract DamageType DamageType { get; }
        public abstract object[] SpecialProperties { get; }
        public override string ToString() => GetType().Name;
        public override string Info => base.Info + string.Format(" \nRanged: {0} \nDamage {1} \nDamageType {2} \nSpecialProperties: {3}", IsRanged, Damage, DamageType, SpecialProperties);
    }
}