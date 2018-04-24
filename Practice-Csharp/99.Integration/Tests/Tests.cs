using _5.StatePattern;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace _99.Integration.Tests
{
    public static class Tests
    {
        public static class StatePatternTests
        {
            public static void Test()
            {
                var path = Environment.CurrentDirectory;//current directory path
                var filename = "GameState.json";//name of file
                var fullpath = System.IO.Path.Combine(path, filename);//join the paths
                var json = System.IO.File.Exists(fullpath) ? //if the file already exists then read it otherwise assign to empty string
                    System.IO.File.ReadAllText(fullpath) :
                    string.Empty;

                //serialization settings for saving abstract types
                var settings = new JsonSerializerSettings
                {
                    TypeNameHandling = TypeNameHandling.All,
                    Formatting = Formatting.Indented
                };

                var _GameContext = json != string.Empty ?
                    new GameContext { CurrentState = new GameStartState() } :
                    JsonConvert.DeserializeObject<GameContext>(json, settings);


                Console.WriteLine("Any key to start");
                Console.WriteLine("Starting Game in " + _GameContext.CurrentState.Name);

                while (Console.ReadKey().Key != ConsoleKey.Q)
                {
                    Console.Clear();
                    Console.WriteLine("Update Context");
                    Console.WriteLine("q to quit");
                    _GameContext.UpdateContext();
                }

                json = JsonConvert.SerializeObject(_GameContext, settings);
                Console.WriteLine(json);
                Console.ReadKey();
                System.IO.File.WriteAllText(fullpath, json);
            }
        }

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