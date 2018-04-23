﻿using System;


namespace _4.Serialization
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

        public override object[] SpecialProperties => throw new NotImplementedException();
        public override bool IsRanged => false;
    }
}