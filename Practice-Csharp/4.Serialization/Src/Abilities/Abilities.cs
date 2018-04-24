using System;
using System.Collections;
using System.Collections.Generic;
using _4.Serialization.Base;
using _4.Serialization.Interfaces;

namespace _4.Serialization.Abilities
{
    public enum AbilityType
    {
        STRENGTH = 1,
        DEXTERITY = 2,
        CONSTITUTION = 3,
        WISDOM =4,
        INTELLIGENCE =5,
        CHARISMA = 6
    }

    public interface IAbilities
    {
        Strength STR { get; }
        Dexterity DEX { get; }
        Constitution CON { get; }
        Wisdom WIS { get; }
        Intelligence INT { get; }
        Charisma CHR { get; }
    }

    [System.Serializable]
    public class Abilities
    {
        public Abilities()
        {
            IAbilities = new List<IAbility>
            {
                new Strength(),
                new Dexterity(),
                new Constitution(),
                new Intelligence(),
                new Wisdom(),
                new Charisma()
            };

            Modifiers = new Dictionary<string, Modifier>();
            foreach (var a in IAbilities)
            {
                Modifiers.Add(Guid.NewGuid().ToString(), new Modifier { AffectedAbility = a.GetType(), Amount = 5 });
            }
        }

        public List<IAbility> IAbilities { get; set; }

        public Dictionary<string, Modifier> Modifiers;

        public Guid AddModifier(Modifier modifier)
        {
            Modifiers.Add(Guid.NewGuid().ToString(), modifier);
            return Guid.NewGuid();
        }

        public bool RemoveModifier(Guid guid)
        {
            return Modifiers.Remove(guid.ToString());
        }
    }
}