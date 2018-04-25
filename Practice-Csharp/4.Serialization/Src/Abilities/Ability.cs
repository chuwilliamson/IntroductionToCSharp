using System;
using System.Collections;
using _4.Serialization.Base;
using _4.Serialization.Interfaces;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace _4.Serialization.Abilities
{
    [System.Serializable]
    public class Ability : IAbility, ISaveable
    {
        public Ability()
        {
            _score = Extensions.Roll4AddTop3;
        }
        public Type Type => GetType();
        public int Value;// => Score;
        public int _score;

        public int Score
        {
            get { return _score; }
            set
            {
                _score = value;
                
            }
        }

        public int Modifier => (Score - 10) / 2;

        public string JsonString { get; set; }
        
    }
}