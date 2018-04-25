using System;
using _4.Serialization.Base;

namespace _4.Serialization.Equipment.Weapons
{
    public class Greatsword : Weapon, IRollable, IMartialWeapon
    {
        public override bool IsRanged => false;
        public override IRollable Damage => new Dice(6);
        public override DamageType DamageType => DamageType.Slashing;
        public override object[] SpecialProperties => new object[] { };
        public override string Name => "Greatsword";
        public override int Cost => 50;
        public override int Weight => 6;

        public int Roll()
        {
            var roll1 = Damage.Roll();
            var roll2 = Damage.Roll();
            Console.WriteLine("roll1d6 " + "1:" + roll1);
            Console.WriteLine("roll1d6 " + "2:" + roll2);
            return roll1 + roll2;
        }
    }
}