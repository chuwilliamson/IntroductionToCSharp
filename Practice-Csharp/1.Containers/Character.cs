using System.Collections.Generic;

namespace _1.Containers
{
    public class Character
    {
        public Dictionary<string, Stat> SavingThrows { get; set; }
        public int ExperiencePoints { get; set; }
        public string CharacterName { get; set; }
        public int Level { get; set; }
    }
}