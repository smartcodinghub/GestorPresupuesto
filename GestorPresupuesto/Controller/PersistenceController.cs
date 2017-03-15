using GestorPresupuesto.Model;
using GestorPresupuesto.Util;
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
    public class PersistenceController : IPersistenceController
    {
        private String path;
        private int secondsToSave;
        private PersistenceEntity cache;
        private DateTime lastRead;

        public PersistenceController()
        {
            path = ConfigurationUtil.ReadConfiguration("PersistencePath", "./Stored.json");
            secondsToSave = ConfigurationUtil.ReadConfigurationAsInt("CacheWriteSeconds", 60);
            lastRead = DateTime.MinValue;
            cache = ReadFile();
        }

        private PersistenceEntity ReadFile()
        {
            try
            {
                if (!File.Exists(path))
                    WriteFile(new PersistenceEntity());

                String textRead = File.ReadAllText(path);

                if (!String.IsNullOrEmpty(textRead))
                    return JsonConvert.DeserializeObject<PersistenceEntity>(textRead);
            }
            catch (Exception ex) { }

            return new PersistenceEntity();
        }

        private Boolean WriteFile(PersistenceEntity toWrite)
        {
            try
            {
                File.WriteAllText(path, JsonConvert.SerializeObject(toWrite));
                return true;
            }
            catch (Exception ex) { }

            return false;
        }

        public PersistenceEntity Get()
        {
            return cache;
        }

        public Boolean Save(PersistenceEntity toSave)
        {
            Boolean correct = WriteFile(toSave);

            if (correct)
                cache = ReadFile();

            return correct;
        }
    }
}
