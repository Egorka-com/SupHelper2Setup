using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Wix4Setup;

namespace WixSharp
{
    public class MsiConfig
    {
        public string AppVersion { get; set; }

        public static void UpdateConfig()
        {
            string path = @".\output\Release\config.json";

            var config = new MsiConfig()
            {
                AppVersion = AppConfig.ProductVersion
            };

            var json = JsonConvert.SerializeObject(config);

            System.IO.File.WriteAllText(path, json);

        }
    }
}
