using RabbitMQClient.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace RabbitMQClient.ConfigHandling
{
    internal class JsonFileConfigHandler : IConfigHandler
    {
        //IConfig _config;
        object _config;
        string _path;

        public JsonFileConfigHandler(object config, string path)
        {
            _config = config;
            _path = path;
        }

        public JsonFileConfigHandler(string path)
        {
            _path = path;
        }
        public T ReadConfig<T>()
        {
            T config;
            string jsonString = File.ReadAllText(_path);

            // JSON-String in ein Config-Objekt deserialisieren
            config = JsonSerializer.Deserialize<T>(jsonString);

            return config;
        }

        public void WriteConfig()
        {
            string jsonString = JsonSerializer.Serialize(_config, new JsonSerializerOptions { WriteIndented = true });

            File.WriteAllText(_path, jsonString);
        }
    }
}
