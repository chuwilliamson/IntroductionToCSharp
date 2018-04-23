using System;
using _4.Serialization.Base;
using _4.Serialization.Interfaces;
 
namespace _4.Serialization.Equipment.Weapons
{
    public class ShortSword : Weapon, ISimpleWeapon
    {
        public override bool IsRanged => throw new NotImplementedException();

        public override IRollable Damage => throw new NotImplementedException();

        public override DamageType DamageType => throw new NotImplementedException();

        public override object[] SpecialProperties => throw new NotImplementedException();

        public override string Name => throw new NotImplementedException();

        public override int Cost => throw new NotImplementedException();

        public override int Weight => throw new NotImplementedException();
    }
}