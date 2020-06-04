//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using System;
using System.Configuration;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now.ToString("yyyyMMddhhmmss"));
            Console.ReadKey();
        }
    }

    public class SystemConfiguration
    {
        public string GetAppsettingsData(string key,string fileName)
        {
            string configFileName = AppDomain.CurrentDomain.SetupInformation.ApplicationBase + fileName;

            ExeConfigurationFileMap map = new ExeConfigurationFileMap
            {
                ExeConfigFilename = configFileName
            };

            Configuration config = ConfigurationManager.OpenMappedExeConfiguration(map, ConfigurationUserLevel.None);

            KeyValueConfigurationElement keyvalue = config.AppSettings.Settings[key];

            return keyvalue.Value;
        }
    }
}
