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
        public Type Type => GetType();
        public int Value;// => Score;
        public int Score => Extensions.Roll4AddTop3;
        public int Modifier => (Score - 10) / 2;

        public string JsonString { get; set; }
        
    }
}