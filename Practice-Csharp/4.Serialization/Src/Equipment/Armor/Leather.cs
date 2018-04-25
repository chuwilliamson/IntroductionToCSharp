using _4.Serialization.Abilities;
using _4.Serialization.Base;

namespace _4.Serialization.Equipment.Armor
{
    public class Leather : Armor, ILightArmor
    {
        public override int Cost => 5;
        public override int Weight => 8;
        public override int ArmorClass => 11;
        public override Modifier Modifier => new Modifier<Dexterity>();
        public override Strength Strength { get; }
        public override bool Stealth { get; }
    }
}