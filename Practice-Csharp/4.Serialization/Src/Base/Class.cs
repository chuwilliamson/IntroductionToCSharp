using System;
using System.Linq;
using _4.Serialization.Equipment.Armor;
using _4.Serialization.Interfaces;

namespace _4.Serialization.Base
{
    public class Class
    {
        public string Name;
        public Race Race;
        public IRollable Attack;
        public IRollable Damage;
        public IRollable[] HitDice;
        public IRollable Initiative;
        public Type PrimaryAbility;
        public int Experience = 0;
        public int Level => 1 + Experience / 300;

        public int HitPointMaximum;
        public int HitPoints;
        public int ProficiencyBonus => 2 + Level / 4;

        public IEquipment[] Armor;
        public IEquipment[] Shield;
        public IEquipment[] Weapon;

        public Abilities.Abilities Abilities;

        public Proficiencies Proficiences;

        public int ArmorCount
        {
            get
            {
                var total = 0;
                total += Armor.Sum(a => ((Armor) a).ArmorClass);
                total += Shield.Sum(a => ((Armor) a).ArmorClass);
                return total;
            }
        }

        public void Log()
        {
            var info = string.Format("Name{0} \n AC{1} ", Name, ArmorCount);
            Console.WriteLine(info);
        }
    }
}