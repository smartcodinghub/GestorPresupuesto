using GestorPresupuesto.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorPresupuesto.Controller
{
    public class PersistenceController
    {
        private String path;
        public PersistenceEntity Cache { get; private set; }

        public PersistenceController()
        {
            path = ReadConfiguration();
            ReadFile();

            if (Cache == null)
                Cache = new PersistenceEntity();
            else if (Cache.Settings == null)
                Cache.Settings = new Settings();
            else if (Cache.Months == null)
                Cache.Months = new List<MonthModel>();
        }

        private String ReadConfiguration()
        {
            try { return ConfigurationManager.AppSettings["PersistencePath"]; }
            catch (Exception) { return "./Stored.json"; }
        }

        private void ReadFile()
        {
            try
            {
                String textRead = File.ReadAllText(path);

                if (!String.IsNullOrEmpty(textRead))
                    Cache = JsonConvert.DeserializeObject<PersistenceEntity>(textRead);
            }
            catch (Exception ex) { }
        }
    }
}
