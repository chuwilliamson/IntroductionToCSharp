using System;
using System.Collections;
using System.Collections.Generic;
using _4.Serialization.Base;
using _4.Serialization.Interfaces;

namespace _4.Serialization.Abilities
{
    [System.Serializable]
    public class Abilities : IEnumerable
    {
        public Abilities()
        {
            _abilities = new List<Ability>
            {
                new Strength(),
                new Dexterity(),
                new Constitution(),
                new Intelligence(),
                new Wisdom(),
                new Charisma()
            }; 
        }
 
        private List<Ability> _abilities; 
        public Dictionary<Guid, Modifier> Modifiers;

        public Guid AddModifier(Modifier modifier)
        {
            if(Modifiers == null)
                Modifiers = new Dictionary<Guid, Modifier>();
            Modifiers.Add(Guid.NewGuid(), modifier);
            return Guid.NewGuid();
        }

        public bool RemoveModifier(Guid guid)
        {
            return Modifiers.Remove(guid);
        }

        public IEnumerator GetEnumerator()
        {
            return ((IEnumerable) _abilities).GetEnumerator();
        }
    }
}