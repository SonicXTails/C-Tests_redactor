using Newtonsoft.Json;
using System.IO;

namespace PlayMe
{
    internal class Converter_to_JSON
    {
        public static void MySerealize<T>(T questions, string filePath)
        {
            string json = JsonConvert.SerializeObject(questions);
            File.WriteAllText(filePath, json);
        }

        public static T MyDerealize<T>(string filePath)
        {
            string json = File.ReadAllText(filePath);
            T questions = JsonConvert.DeserializeObject<T>(json);
            return questions;
        }
    }
}
