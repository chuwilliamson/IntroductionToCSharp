using _4.Serialization.Base;

namespace _4.Serialization.Equipment.Weapons
{
    public interface IWeapon : IEquipment
    {
        bool IsRanged { get; }
        IRollable Damage { get; }
        DamageType DamageType { get; }
        object[] SpecialProperties { get; }
    }
}