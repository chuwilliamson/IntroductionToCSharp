using System.Collections;
using System.Collections.Generic;

namespace _4.Serialization.src
{
    public class Abilities : IEnumerable
    {
        public Abilities()
        {
            abilities = new List<Ability>
        {
            new Strength(),
            new Dexterity(),
            new Constitution(),
            new Intelligence(),
            new Wisdom(),
            new Charisma()
        };
            foreach (Ability a in abilities)
                a.Score = CharacterCreator.Roll4AddTop3;
        }

        public List<Ability> abilities;

        public IEnumerator GetEnumerator()
        {
            return ((IEnumerable)abilities).GetEnumerator();
        }
    }
}
