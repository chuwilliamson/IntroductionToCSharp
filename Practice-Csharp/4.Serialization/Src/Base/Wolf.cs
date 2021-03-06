﻿using System;
using _4.Serialization.Skills;

namespace _4.Serialization.Base
{
    public class Wolf : Monster
    {
        public override int ArmorCount => 13;
        public override int HitPoints => 11;
        public override int Speed => 40;


        public override ISkill[] Skills => new ISkill[] {new Perception(), new Stealth()};

        public override Action Action

        {
            get
            {
                Console.WriteLine("Wolf Attack!");
                return () => new Dice(4).Roll();
            }
        }
    }
}