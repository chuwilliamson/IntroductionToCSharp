using System;
using _4.Serialization.Base;
using _4.Serialization.Interfaces;

namespace _4.Serialization.Equipment.Weapons
{
    public class Club : Weapon, ISimpleWeapon
    {
        public override string Name => "Club";

        public override int Cost => 1;

        public override int Weight
        {
            get { return 2; }
        }

        public override IRollable Damage
        {
            get { return new Dice(4); }
        }

        public override DamageType DamageType
        {
            get { return DamageType.Bludgeoning; }
        }

        public override object[] SpecialProperties
        {
            get
            {
                return new object[5];
            }
        }

        public override bool IsRanged => false;
    }
}