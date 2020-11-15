using System;

using System.IO;

using System.Text.Json;

using ProjetoBase.NET.Models;


namespace ProjetoBase.NET.Layers.Config

{
    class Config
    {
        public static string ReadConfigString()
        {
            string jsonString;
            ConfigModel model;
            try
            {
                jsonString = File.ReadAllText("Config.json");
                model = JsonSerializer.Deserialize<ConfigModel>(jsonString);
                return model.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static ConfigModel ReadConfigObject()
        {
            string jsonString;
            ConfigModel model;
            try
            {
                jsonString = File.ReadAllText("Config.json");
                model = JsonSerializer.Deserialize<ConfigModel>(jsonString);
                return model;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}
