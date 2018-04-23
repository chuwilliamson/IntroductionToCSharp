using _4.Serialization;
using System;
using System.IO;
using System.Collections.Generic;
using _4.Serialization.Abilities;
using _4.Serialization.Base;
using _4.Serialization.Equipment.Armor;
using _4.Serialization.Equipment.Weapons;
using _4.Serialization.Interfaces;
using _4.Serialization.Skills;
using Newtonsoft.Json;

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
        public class Person
        {
            public string Name = "bob";
            public Stats s;
        }

        public class Stats
        {
            public Abilities Abilities = new Abilities
            {
                Modifiers = new Dictionary<string, Modifier>
                {
                    { "bob", new Modifier { AffectedAbility = typeof(Strength), Amount = 2} }
                }
            };
        }

        static void Main(string[] args)
        {

            var path0 = Path.Combine(Environment.CurrentDirectory, "stats.json");
            var path1 = Path.Combine(Environment.CurrentDirectory, "Barbarian.json");
            var path2 = Path.Combine(Environment.CurrentDirectory, "Person.json");

            

            var stats = new Stats();
            var stats_string = JsonConvert.SerializeObject(stats, Formatting.Indented);

            var person = new Person() { s = stats };
            var person_string = JsonConvert.SerializeObject(person, Formatting.Indented);

            var barb_string = JsonConvert.SerializeObject(Barbarian, Formatting.Indented);
            
            File.WriteAllText(path0, stats_string);
            File.WriteAllText(path1, barb_string);
            File.WriteAllText(path2, person_string);


            //1. Choose a Race
            //2. Choose a Class
            //3. Determine Ability Scores
            //4. Describe your character            

        }
    }
}