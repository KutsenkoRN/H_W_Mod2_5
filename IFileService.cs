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
    internal interface IFileService
    {
        void Save(string messages);
    }
       
}