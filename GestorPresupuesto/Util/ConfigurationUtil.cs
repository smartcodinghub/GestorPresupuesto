using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorPresupuesto.Util
{
    public class ConfigurationUtil
    {
        public static String ReadConfiguration(String name, String def)
        {
            try
            {
                return ConfigurationManager.AppSettings[name];
            }
            catch (Exception) { }

            return def;
        }

        public static int ReadConfigurationAsInt(String name, int def)
        {
            try
            {
                int result;
                return int.TryParse(ConfigurationManager.AppSettings[name], out result) ? result : def;
            }
            catch (Exception) { }

            return def;
        }
    }
}
