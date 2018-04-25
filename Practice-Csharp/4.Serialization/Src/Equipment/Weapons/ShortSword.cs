using System;
using _4.Serialization.Base;

namespace _4.Serialization.Equipment.Weapons
{
    public class ShortSword : Weapon, ISimpleWeapon
    {
        public override int Cost
        {
            get { throw new NotImplementedException(); }
        }

        public override IRollable Damage
        {
            get { throw new NotImplementedException(); }
        }

        public override DamageType DamageType
        {
            get { throw new NotImplementedException(); }
        }

        public override bool IsRanged
        {
            get { throw new NotImplementedException(); }
        }

        public override string Name
        {
            get { throw new NotImplementedException(); }
        }

        public override object[] SpecialProperties
        {
            get { throw new NotImplementedException(); }
        }

        public override int Weight
        {
            get { throw new NotImplementedException(); }
        }
    }
}