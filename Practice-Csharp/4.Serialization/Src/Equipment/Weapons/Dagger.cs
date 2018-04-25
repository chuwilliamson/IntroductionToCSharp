using _4.Serialization.Base;

namespace _4.Serialization.Equipment.Weapons
{
    public class Dagger : Weapon, IRollable
    {
        public override string Name => "Dagger";
        public override int Cost => 1;
        public override int Weight => 2;
        public override IRollable Damage => new Dice(4);
        public override DamageType DamageType => DamageType.Piercing;
        public override object[] SpecialProperties => new object[] { };
        public override bool IsRanged => false;

        public int Roll()
        {
            return Damage.Roll();
        }
    }
}