using System;
using _4.Serialization.Base;
using _4.Serialization.Interfaces;

namespace _4.Serialization.Equipment.Weapons
{
    public class Dagger : ISimpleWeapon
    {
        public bool IsRanged => throw new NotImplementedException();

        public IRollable Damage => throw new NotImplementedException();

        public DamageType DamageType => throw new NotImplementedException();

        public object[] SpecialProperties => throw new NotImplementedException();

        public string Name => throw new NotImplementedException();

        public int Cost => throw new NotImplementedException();

        public int Weight => throw new NotImplementedException();
    }
}