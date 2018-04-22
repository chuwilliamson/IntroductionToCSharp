using System;
using System.Linq;

namespace _4.Serialization.src
{
    public abstract class Entity { protected string name; }

    public class Class
    {
        public string Name;
        public IRollable IAttack;
        public IRollable IDamage;
        public IRollable IHitDice;
        public IRollable IInitiative;
        public Type PrimaryAbility;

        public IEquipment[] Armor;
        public IEquipment[] Shield;
        public IEquipment[] Weapon;

        public Abilities Abilities;

        public Proficiencies Proficiences;

        public int ArmorCount
        {
            get
            {
                var total = 0;
                total += Armor.Sum(a => ((Armor)a).ArmorClass);
                total += Shield.Sum(a => ((Armor)a).ArmorClass);
                return total;
            }
        }

        public void Log()
        {
            string info = string.Format("Name{0} \n AC{1} ", Name, ArmorCount);
            Console.WriteLine(info);
        }
    }
}
