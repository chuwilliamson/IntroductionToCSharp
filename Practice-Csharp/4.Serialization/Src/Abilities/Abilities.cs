using System;
using System.Collections;
using System.Collections.Generic;

namespace _4.Serialization
{
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
 
        private readonly List<Ability> _abilities;

        public Dictionary<Guid, Modifier> Modifiers;

        public Guid AddModifier(Modifier modifier)
        {
            if(Modifiers == null)
                Modifiers = new Dictionary<Guid, Modifier>();
            Modifiers.Add(Guid.NewGuid(), modifier);
            var mods = Modifiers.Values;
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