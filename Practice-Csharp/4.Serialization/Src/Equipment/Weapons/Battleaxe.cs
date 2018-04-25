using _4.Serialization.Base;

namespace _4.Serialization.Equipment.Weapons
{
    public class Battleaxe : Weapon, IRollable, IMartialWeapon
    {
        public override bool IsRanged => false;
        public override IRollable Damage => new Dice(8);
        public override DamageType DamageType => DamageType.Slashing;
        public override object[] SpecialProperties => new object[] { };
        public override string Name => "Battleaxe";
        public override int Cost => 10;
        public override int Weight => 4;

        public int Roll()
        {
            return Damage.Roll();
        }
    }
}