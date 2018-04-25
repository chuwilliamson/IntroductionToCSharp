using System;
using _4.Serialization.Base;

namespace _4.Serialization.Equipment.Weapons
{
    public class Dart : Weapon, IRollable, ISimpleWeapon
    {
        public int Roll()
        {
            var roll1 = Damage.Roll();
            Console.WriteLine("roll1d4 " + "1:" + roll1);
            return roll1;
        }

        public override bool IsRanged => true;
        public override IRollable Damage => new Dice(4);
        public override DamageType DamageType => DamageType.Piercing;
        public override object[] SpecialProperties => new object[] { };
        public override string Name => "Dart";
        public override int Cost => 5;
        public override int Weight => 1;
    }
}