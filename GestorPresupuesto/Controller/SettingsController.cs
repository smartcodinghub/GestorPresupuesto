using GestorPresupuesto.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorPresupuesto.Controller
{
    public class SettingsController
    {
        public Settings Settings { get; set; }

        public SettingsController(IPersistenceController persistenceController)
        {
            this.Settings = persistenceController.Get().Settings;
        }
    }
}
