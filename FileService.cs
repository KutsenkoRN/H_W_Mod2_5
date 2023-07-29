using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using static System.Net.WebRequestMethods;
using File = System.IO.File;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace H_W_Mod2_5
{
    sealed class FileService : IFileService
    {
        private string _fileName;
        readonly string _fileConfig = "config.json";

        public FileService()
        {
            if (File.Exists(_fileConfig))
            {
                var readAllText = File.ReadAllText(_fileConfig);
                Config = string.IsNullOrEmpty(readAllText) ? Config.DefConfig() : JsonSerializer.Deserialize<Config>(readAllText);
            }
        }

        public Config Config { get; set; } = Config.DefConfig();

        public void ClearDirectory()
        {
            IEnumerable<string> fileFromDirectory = Directory.GetFiles(path: Config.DirectoryName).Reverse().Skip(Config.MaxQuantityOfFile);

            foreach (var file in fileFromDirectory)
            {
                File.Delete(file);
            }
        }

        public void Save(string messages)

        {
            _fileName = $"{DateTime.Now.ToString("HH-mm-ss dd-MM-yyyy")}.txt";

            if (!Directory.Exists(Config.DirectoryName))
                Directory.CreateDirectory(Config.DirectoryName);

            File.AppendAllLines(Path.Combine(Config.DirectoryName, _fileName), new List<string> { messages });

            ClearDirectory();
        }
    }
}
