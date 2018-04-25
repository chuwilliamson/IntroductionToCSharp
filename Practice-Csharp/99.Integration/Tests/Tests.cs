using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using _5.StatePattern;

namespace _99.Integration.Tests
{
    public static class Tests
    {
        public static void TestProficiencyBonus()
        {
            var results = new List<int>();
            for (var level = 0; level < 20; level++)
                results.Add(2 + level / 4);
            results.ForEach(action: Console.WriteLine);
        }

        public static void TestExperienceRequiredAtLevel(int level)
        {
        }

        public static class StatePatternTests
        {
            public static void Test()
            {
                var path = Environment.CurrentDirectory; //current directory path
                var filename = "GameState.json"; //name of file
                var fullpath = Path.Combine(path1: path, path2: filename); //join the paths
                var json = File.Exists(path: fullpath)
                    ? //if the file already exists then read it otherwise assign to empty string
                    File.ReadAllText(path: fullpath)
                    : string.Empty;

                //serialization settings for saving abstract types
                var settings = new JsonSerializerSettings
                {
                    TypeNameHandling = TypeNameHandling.All,
                    Formatting = Formatting.Indented
                };

                var _GameContext = json != string.Empty
                    ? new GameContext {CurrentState = new GameStartState()}
                    : JsonConvert.DeserializeObject<GameContext>(value: json, settings: settings);


                Console.WriteLine("Any key to start");
                Console.WriteLine("Starting Game in " + _GameContext.CurrentState.Name);

                while (Console.ReadKey().Key != ConsoleKey.Q)
                {
                    Console.Clear();
                    Console.WriteLine("Update Context");
                    Console.WriteLine("q to quit");
                    _GameContext.UpdateContext();
                }

                json = JsonConvert.SerializeObject(value: _GameContext, settings: settings);
                Console.WriteLine(value: json);
                Console.ReadKey();
                File.WriteAllText(path: fullpath, contents: json);
            }
        }
    }
}