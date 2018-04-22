using _4.Serialization.src;
using _4.Serialization;
using System;
namespace _99.Integration
{
    class Program
    {
        static void Main(string[] args)
        {

            //1. Choose a Race
            //2. Choose a Class
            //3. Determine Ability Scores
            //4. Describe your character            

            var barb = new Class()
            {
                Name = "Barbarian",
                IHitDice = new Dice(12),
                PrimaryAbility = typeof(Strength),
                Abilities = new Abilities(),
                Armor = new IEquipment[] { new HeavyArmor() },
                Weapon = new IEquipment[] { new Club() },
                Shield = null,                

                Proficiences = new Proficiencies
                {
                    Armor = new Type[] { typeof(LightArmor), typeof(MediumArmor), typeof(Shield) },
                    Weapons = new Type[] { typeof(IMartialWeapon), typeof(ISimpleWeapon) },
                    Tools = null,
                    SavingThrows = new Type[] { typeof(Strength), typeof(Constitution) },
                    Skills = new Type[]
                    {   typeof(AnimalHandling),
                        typeof(Athletics),
                        typeof(Intimidation),
                        typeof(Nature),
                        typeof(Perception),
                        typeof(Survival)
                    },
                }
            };
            barb.Log();
        }

    }
}
