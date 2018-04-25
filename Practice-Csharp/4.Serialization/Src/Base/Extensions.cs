using System;
using System.Collections.Generic;
using System.Linq;

namespace _4.Serialization.Base
{
    public static class Extensions
    {
        public static int Roll4AddTop3
        {
            get
            {
                var val = new List<int>();
                for (var i = 0; i < 4; i++)
                    val.Add(new Dice(6).Roll());
                val.Sort();
                return val.Sum() - val[0];
            }
        }

        public static Type[] FindObjectsOfType<T>()
        {
            return (from domainAssembly in AppDomain.CurrentDomain.GetAssemblies()
                from assemblyType in domainAssembly.GetTypes()
                where typeof(T).IsAssignableFrom(c: assemblyType)
                select assemblyType).ToArray();
        }
    }
}