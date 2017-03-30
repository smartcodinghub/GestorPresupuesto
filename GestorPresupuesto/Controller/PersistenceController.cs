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
using static System.Environment;

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
            String persistencePath = ConfigurationUtil.ReadConfiguration("PersistencePath", "GestorPresupuesto\\Saved.json");
            path = Path.Combine(Environment.GetFolderPath(SpecialFolder.MyDocuments), persistencePath);
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
                FileInfo file = new FileInfo(path);

                if (!file.Exists)
                    Directory.CreateDirectory(file.DirectoryName);

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
