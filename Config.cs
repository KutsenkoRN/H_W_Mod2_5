using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H_W_Mod2_5
{
    public class Config
    {
        public string DirectoryName { get; set; }

        public int MaxQuantityOfFile { get; set; }

        public static Config DefConfig()
        {
            return new Config() { DirectoryName = "Logs", MaxQuantityOfFile = 3 };
        }
    }
}