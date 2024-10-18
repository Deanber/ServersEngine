using System.Text.Json;
using System.IO;
using System;

namespace Editor
{
    namespace Json
    {
        class JsonRead
        {
            string Jsonpath = "/Users/zefa/Documents/GitHub/ServersEngine/Server/Editor/Core/Json/Test.json";
            public void Seriliziable()
            {
                string Json = File.ReadAllText(Jsonpath);
                Property pp = new Property();
                pp = JsonSerializer.Deserialize<Property>(Json);
                Console.WriteLine(pp.property);
            }

        }
        class Property
        {
            public object property { get; set; }
        }
        class shuxing
        { 
            int 
        }
    }
}