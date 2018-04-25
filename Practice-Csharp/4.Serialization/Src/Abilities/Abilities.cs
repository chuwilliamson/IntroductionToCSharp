using System;

namespace _4.Serialization.Abilities
{
    [Serializable]
    public class Abilities : IAbilities
    {
        public Abilities()
        {
            IAbilities = new IAbility[]
            {
                new Strength(),
                new Dexterity(),
                new Constitution(),
                new Intelligence(),
                new Wisdom(),
                new Charisma()
            };
        }

        public IAbility[] IAbilities { get; set; }

        public IAbility Strength => IAbilities[0];
        public IAbility Dexterity => IAbilities[1];
        public IAbility Constitution => IAbilities[2];
        public IAbility Wisdom => IAbilities[3];
        public IAbility Intelligence => IAbilities[4];
        public IAbility Charisma => IAbilities[5];
    }
}