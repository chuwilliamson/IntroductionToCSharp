using _4.Serialization.Abilities;
using _4.Serialization.Base;

namespace _4.Serialization.Equipment.Armor
{
    public class Shield : Armor
    {
        public override int Cost => 10;
        public override int Weight => 10;
        public override int ArmorClass => 2;
        public override Modifier Modifier => new Modifier {AffectedAbility = null, Amount = 2};
        public override Strength Strength { get; }
        public override bool Stealth => false;
    }
}