//using System;
//using System.IO;
//using _4.Serialization.Abilities;
//using _4.Serialization.Base;
//using _4.Serialization.Equipment;
//using _4.Serialization.Equipment.Armor;
//using _4.Serialization.Equipment.Weapons;
//using _4.Serialization.Skills;
using _6.CodeReview1;
using MyCodeReview;

//namespace _99.Integration
//{
class Program
{
    static void Main()
    {
        var c = new _6.CodeReview1.Review();
        System.Console.WriteLine(c.Runit());
        System.Console.ReadLine();
    }   
}
//        public static readonly Class Barbarian = new Class
//        {
//            Name = "Barbarian",
//            Experience = 0,
//            HitDice = new IRollable[] {new Dice(12)},
//            Initiative = new Dice(20),
//            HitPoints = 12,
//            PrimaryAbility = typeof(Strength),
//            Abilities = new Abilities(),
//            Armor = new IEquipment[] {new Padded()},
//            Weapon = new IEquipment[] {new Club()},
//            Shield = new IEquipment[] {new Shield()},
//            Proficiences = new Proficiencies
//            {
//                Armor = new[] {typeof(ILightArmor), typeof(IMediumArmor), typeof(Shield)},
//                Weapons = new[] {typeof(IMartialWeapon), typeof(ISimpleWeapon)},
//                Tools = null,
//                SavingThrows = new[] {typeof(Strength), typeof(Constitution)},
//                Skills = new[]
//                {
//                    typeof(AnimalHandling), typeof(Athletics), typeof(Intimidation), typeof(Nature), typeof(Perception),
//                    typeof(Survival)
//                }
//            }
//        };


//        static void Main()
//        {
//            //var path = Path.Combine(path1: Environment.CurrentDirectory, path2: "Barbarian.json");
//            var input = ConsoleKey.Play;
//            while (input != ConsoleKey.Q)
//            {
//                var weapons = new IWeapon[] {new Greatsword(), new Club(), new Dart(), new Dagger()};

//                Barbarian.Weapon[0] = weapons[new Random().Next(4)];

//                var CurrentWeapon = Barbarian.Weapon[0];

//                Console.Clear();

//                Console.WriteLine("Current Weapon " + CurrentWeapon.Info);
//                Console.WriteLine("Attack Roll => " + Barbarian.Attack.Roll());
//                Console.WriteLine("Damage Roll => " + Barbarian.Damage.Roll());
//                foreach (var ability in Barbarian.Abilities.IAbilities)
//                    Console.WriteLine(value: ability.Info);

//                input = Console.ReadKey().Key;
//            }
//        }
//    }
//}