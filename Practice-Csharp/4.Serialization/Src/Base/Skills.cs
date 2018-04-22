
namespace _4.Serialization
{
    public interface ISkill { }

    public class Acrobatics : ISkill { }
    public class AnimalHandling : ISkill { }
    public class Athletics : ISkill { }
    public class History : ISkill { }
    public class Insight : ISkill { }
    public class Intimidation : ISkill { }
    public class Perception : ISkill { }
    public class Survival : ISkill { }
    public class Nature : ISkill { }

    public enum DamageType
    {
        Bludgeoning, Piercing, Slashing
    }

}