using _4.Serialization.Base;

namespace _4.Serialization.Equipment.Weapons
{
    public class Club : Weapon, ISimpleWeapon, IRollable
    {
        public int Roll()
        {
            return Damage.Roll();
        }

        public override string Name => "Club";

        public override int Cost => 1;

        public override int Weight => 2;

        public override IRollable Damage => new Dice(4);

        public override DamageType DamageType => DamageType.Bludgeoning;

        public override object[] SpecialProperties => new object[5];

        public override bool IsRanged => false;
    }
}