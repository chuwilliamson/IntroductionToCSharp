
using Newtonsoft.Json;

namespace _98.Demo
{
    class Program
    {
        [System.Serializable]
        public class Dylan
        {
            public int Age;
            public int Awesomeness;
        }
        static void Main(string[] args)
        {   
                     
            var jsonstring = System.IO.File.ReadAllText(System.Environment.CurrentDirectory + "Dylan.txt");
            var newdylan = JsonConvert.DeserializeObject(jsonstring);

            var luke_jsonstring = System.IO.File.ReadAllText(System.Environment.CurrentDirectory + "Luke.txt");
            var newluke = JsonConvert.DeserializeObject(luke_jsonstring);
            
            System.Console.ReadLine();
        }
    }
}
