using System.Text.Json;
using System.IO;
using System;
using System.Text.Json.Serialization;

namespace Editor
{
    namespace Json
    {
        class JsonRead
        {
            string Jsonpath = "/Users/zefa/Documents/GitHub/ServersEngine/Server/Editor/Core/Json/Test.json";
            public void Seriliziable()
            {
                string json = File.ReadAllText(Jsonpath);
                JsonDocument jd = JsonDocument.Parse(json);
                JsonElement shuxing = jd.RootElement.GetProperty("属性").GetProperty("力量");
                Console.WriteLine();
            }

        }

    }
}