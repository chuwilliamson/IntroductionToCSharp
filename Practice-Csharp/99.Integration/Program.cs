using _4.Serialization;
using System;
using System.Collections.Generic;
using _4.Serialization.Abilities;
using _4.Serialization.Base;
using _4.Serialization.Equipment.Armor;
using _4.Serialization.Equipment.Weapons;
using _4.Serialization.Interfaces;
using _4.Serialization.Skills;

namespace _99.Integration
{
    class Program
    {
        public static readonly Class Barbarian = new Class()
        {
            Name = "Barbarian",
            Experience = 0,
            Attack = new Dice(20),
            Damage = new Dice(20),
            HitDice = new IRollable[] { new Dice(12) },
            Initiative = new Dice(20),
            HitPoints = 12,
            PrimaryAbility = typeof(Strength),
            Abilities = new Abilities(),
            Armor = new IEquipment[] { new HeavyArmor() },
            Weapon = new IEquipment[] { new Club() },
            Shield = new IEquipment[] { },
            Proficiences = new Proficiencies
            {
                Armor = new Type[] { typeof(LightArmor), typeof(MediumArmor), typeof(Shield) },
                Weapons = new Type[] { typeof(IMartialWeapon), typeof(ISimpleWeapon) },
                Tools = null,
                SavingThrows = new Type[] { typeof(Strength), typeof(Constitution) },
                Skills = new Type[]
                {
                    typeof(AnimalHandling),
                    typeof(Athletics),
                    typeof(Intimidation),
                    typeof(Nature),
                    typeof(Perception),
                    typeof(Survival)
                },
            }
        };
        static void Main(string[] args)
        {
            var str = new Strength();
            var a = new Abilities();
            var DwarfRacial = new Modifier { Amount = 2, AffectedAbility = typeof(Constitution) };
            var drguid = a.AddModifier(DwarfRacial);
            //1. Choose a Race
            //2. Choose a Class
            //3. Determine Ability Scores
            //4. Describe your character            

        }
    }
}