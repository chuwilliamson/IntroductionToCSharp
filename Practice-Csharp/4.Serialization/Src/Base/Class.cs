using System;
using System.Linq;
using _4.Serialization.Equipment.Armor;
using _4.Serialization.Interfaces;

namespace _4.Serialization.Base
{
    [Serializable]
    public class Class
    {
        internal sealed class BarbarianAttackRoll : IRollable
        {
            private readonly Class owner;
            public BarbarianAttackRoll(Class owner)
            {
                this.owner = owner;
            }
            
            public int Roll()
            {
                var proficient = false;
                foreach (var weapon in owner.Proficiences.Weapons)
                    proficient |= weapon.IsInstanceOfType(owner.Weapon[0]);
         
                var rollamount = new Dice(20).Roll();
                var abilityModifier = (owner.CurrentWeapon as IWeapon).IsRanged ? 
                    owner.Abilities.IAbilities[1].Score :
                    owner.Abilities.IAbilities[0].Score;

                var extra = proficient ? owner.ProficiencyBonus + abilityModifier: abilityModifier;
                
                var info = string.Format("rolled a {0} out of a possible {1} with prof modifier + {2} and ability modifier + {3}", rollamount, 20, owner.ProficiencyBonus, abilityModifier);
                System.Console.WriteLine(info);
                return rollamount + extra;
            }
        }
 
        public IRollable Attack
        {
            get { return new BarbarianAttackRoll(this); }
        }

        public string Name;
        public Race Race;
        
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
        public IRollable CurrentWeapon => Weapon[0] as IRollable;

        public Abilities.Abilities Abilities;

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
            var info = string.Format("Name{0} \n AC{1} ", Name, ArmorCount);
            Console.WriteLine(info);
        }
    }
}