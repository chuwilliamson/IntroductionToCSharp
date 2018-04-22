

namespace _4.Serialization
{
    public interface IWeapon: IEquipment
    {
        bool IsRanged { get; }
        IRollable Damage { get; }
        DamageType DamageType { get; }
        object[] SpecialProperties { get; }
    }
}
