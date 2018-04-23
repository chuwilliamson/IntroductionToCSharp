using System;
using System.Collections.Generic;

namespace _99.Integration.Tests
{
    public static class Tests
    {
        public static void TestProficiencyBonus()
        {
            var results = new List<int>();
            for (int level = 0; level < 20; level++)
            {
                results.Add(2 + level / 4);
            }
            results.ForEach(Console.WriteLine);
        }

        public static void TestExperienceRequiredAtLevel(int level)
        {
        
        }
    }
}