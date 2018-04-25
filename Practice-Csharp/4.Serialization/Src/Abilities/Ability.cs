using System;
using _4.Serialization.Base;

namespace _4.Serialization.Abilities
{
    [Serializable]
    public class Ability : IAbility, ILogger
    {
        public Ability()
        {
            _score = Extensions.Roll4AddTop3;
        }
        
        public Type Type => GetType();
        public int _score;
        public int Score => _score;
        public int Modifier => (Score - 10) / 2;

        public override string ToString() 
        {
            return GetType().Name;
        }

        public string Info => string.Format("Name: {0} Score: {1} Modifier: {2}", ToString(), Score, Modifier);
        public void Log()
        {
            throw new NotImplementedException();
        }
    }
}