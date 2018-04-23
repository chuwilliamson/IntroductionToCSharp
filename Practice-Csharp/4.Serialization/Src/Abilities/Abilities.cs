using System;
using System.Collections;
using System.Collections.Generic;
using _4.Serialization.Base;
using _4.Serialization.Interfaces;
using Newtonsoft.Json;
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

            Modifiers = new Dictionary<string, Modifier>();
            foreach (var a in _abilities)
            {
                Modifiers.Add(Guid.NewGuid().ToString(), new Modifier { AffectedAbility = a.GetType(), Amount = 5 });
            }
            
            
        } 

        public List<Ability> _abilities; 
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

        public IEnumerator GetEnumerator()
        {
            return ((IEnumerable) _abilities).GetEnumerator();
        }
    }
}