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
        public static readonly Class Barbarian = new Class
        {
            Name = "Barbarian",
            Experience = 0,
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
                Armor = new[] { typeof(LightArmor), typeof(MediumArmor), typeof(Shield) },
                Weapons = new[] { typeof(IMartialWeapon), typeof(ISimpleWeapon) },
                Tools = null,
                SavingThrows = new[] { typeof(Strength), typeof(Constitution) },
                Skills = new[]
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
            var path = Path.Combine(Environment.CurrentDirectory, "Barbarian.json");

            ConsoleKey input;
            while ((input = Console.ReadKey().Key) != ConsoleKey.Q)
            {
                Console.Clear();
                Console.WriteLine("result => " + Barbarian.Attack.Roll());
                var CurrentWeapon = Barbarian.Weapon[0];
                Console.WriteLine("current weapon " + CurrentWeapon.ToString());
                foreach (IAbility ability in Barbarian.Abilities.IAbilities)
                {
                    System.Console.WriteLine(ability.ToString() + " :: " + ability.Score);
                }
                if (input == ConsoleKey.F)
                {
                    Barbarian.Weapon[0] = new Dagger();
                 
                }
                if (input == ConsoleKey.C)
                {
                    Barbarian.Weapon[0] = new Club();
                    
                }


            }
    

        }
    }
}