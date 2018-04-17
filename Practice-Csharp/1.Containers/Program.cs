using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Containers
{
    public class Stat
    {
        public string Name { get; set; }
        public int Value { get; set; }
        public string Description { get; set; }     
    }

    public class Character
    {
        public Dictionary<string, Stat> SavingThrows { get; set; }
        public int ExperiencePoints { get; set; }
        public string CharacterName { get; set; }
        public int Level { get; set; }
    }    
}
