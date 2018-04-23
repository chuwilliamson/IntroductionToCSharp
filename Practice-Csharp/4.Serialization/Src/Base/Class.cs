﻿using System;
using System.Linq;

namespace _4.Serialization
{
    public class Class
    {
        public string Name;
        public Race Race;
        public IRollable IAttack;
        public IRollable IDamage;
        public IRollable[] IHitDice;
        public IRollable IInitiative;
        public Type PrimaryAbility;
        public int Experience = 0;
        public int Level => 1 + Experience / 300;

        public int HitPointMaximum;
        public int HitPoints;
        public int ProficiencyBonus => 2 + Level / 4;

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