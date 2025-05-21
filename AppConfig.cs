using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Wix4Setup
{
    class AppConfig
    {
        public static Guid Guid { get; set; }
        public static string AppDir { get; set; }
        public static string MainFile { get; set; }
        public static List<string> Dependences { get; set; }
        public static string TargetDir { get; set; }
        public static string ProductName { get; set; }
        public static string ProductVersion { get; set; }
        public static string Author { get; set; }
        public static string IconPath { get; set; }
        public static string Description { get; set; }
        public static string Language { get; set; }
    

       public static void LoadConfig()
        {
            string configPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "config", "config.json");

            if (!File.Exists(configPath))
            {
                throw new FileNotFoundException($"Configuration file not found at path: {configPath}");
            }

            string jsonContent = File.ReadAllText(configPath);
            ConfigData config = JsonConvert.DeserializeObject<ConfigData>(jsonContent);

            Guid = config.Guid;
            AppDir = Path.GetFullPath(config.AppDir);
            MainFile = config.MainFile;
            Dependences = config.Dependences;
            TargetDir = config.TargetDir;
            ProductName = config.ProductName;
            ProductVersion = config.ProductVersion;
            Author = config.Author;
            IconPath = config.IconPath;
            Description = config.Description;
            Language = config.Language;
        }


    }

    class ConfigData
    {
    public Guid Guid { get; set; }
    public string AppDir { get; set; }
    public string MainFile { get; set; }
    public List<string> Dependences { get; set; }
    public string TargetDir { get; set; }
    public string ProductName { get; set; }
    public string ProductVersion { get; set; }
    public string Author { get; set; }
    public string IconPath { get; set; }
    public string Description { get; set; }
    public string Language { get; set; }
    }
}
