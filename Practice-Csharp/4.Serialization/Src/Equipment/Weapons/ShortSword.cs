using System;

/// <summary>
/// Your race, class, and feats can grant you proficiency with certain weapons or categories of weapons.
/// The two categories are simple and martial.
/// Most people can use simple weapons with proficiency.
/// These weapons include clubs, maces, and other weapons often found in the hands of commoners.

/// Martial weapons, including swords, axes, and polearms, require more specialized training tO use effectively.
/// Most warriors use martial weapons because these weapons put their fighting style and training to best use.
/// Proficiency with a weapon allows you to
/// add your proficiency bonus to the attack roll for any attack you make with that weapon. 
/// If you make an attack roll using a weapon with which you lack proficiency, you do not add your proficiency bonus to the attack roll.
/// </summary>
namespace _4.Serialization
{
    public class ShortSword : Weapon, ISimpleWeapon
    {
        public override bool IsRanged => throw new NotImplementedException();

        public override IRollable Damage => throw new NotImplementedException();

        public override DamageType DamageType => throw new NotImplementedException();

        public override object[] SpecialProperties => throw new NotImplementedException();

        public override string Name => throw new NotImplementedException();

        public override int Cost => throw new NotImplementedException();

        public override int Weight => throw new NotImplementedException();
    }
}