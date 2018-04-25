using System;
using System.Linq;
using _4.Serialization.Equipment;
using _4.Serialization.Equipment.Armor;
using _4.Serialization.Equipment.Weapons;

namespace _4.Serialization.Base
{
    [Serializable]
    public class Class
    {
        public Abilities.Abilities Abilities;

        public IEquipment[] Armor;
        public int Experience = 0;
        public IRollable[] HitDice;

        public int HitPointMaximum;
        public int HitPoints;
        public IRollable Initiative;

        public string Name;
        public Type PrimaryAbility;
        public Proficiencies Proficiences;
        public Race Race;
        public IEquipment[] Shield;
        public IEquipment[] Weapon;

        public IRollable Attack => new BarbarianAttackRoll(this);

        public IRollable Damage => CurrentWeapon;
        public int Level => 1 + Experience / 300;
        public int ProficiencyBonus => 2 + Level / 4;

        public IRollable CurrentWeapon => Weapon[0] as IRollable;

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
            var info = string.Format("Name{0} \n AC{1} ", arg0: Name, arg1: ArmorCount);
            Console.WriteLine(value: info);
        }

        internal sealed class BarbarianAttackRoll : IRollable
        {
            readonly Class owner;

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
                var abilityModifier = ((IWeapon) owner.CurrentWeapon).IsRanged
                    ? owner.Abilities.Dexterity.Modifier
                    : owner.Abilities.Strength.Modifier;

                //if you are proficent then use the abilityModifier STR + the proficiency bonus
                var extra = proficient ? owner.ProficiencyBonus : 0;

                var info = string.Format(
                    "rolled a {0} out of a possible {1} with proficency bonus of +{2} and ability modifier+ {3}",
                    rollamount, 20, extra, abilityModifier);
                Console.WriteLine(value: info);
                return rollamount + extra + abilityModifier;
            }
        }
    }
}