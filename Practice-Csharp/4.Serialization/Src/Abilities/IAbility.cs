using System;
using _4.Serialization.Base;

namespace _4.Serialization.Abilities
{
    public interface IAbility : ILogger
    {
        Type Type { get; }
        int Score { get; }
        int Modifier { get; }
    }
}