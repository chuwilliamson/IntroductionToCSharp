using _4.Serialization.Abilities;
using _4.Serialization.Base;

namespace _4.Serialization.Equipment.Armor
{
    public interface IArmor
    {
        int ArmorClass { get; }
        Modifier Modifier { get; }
        Strength Strength { get; }
        bool Stealth { get; }
    }
}