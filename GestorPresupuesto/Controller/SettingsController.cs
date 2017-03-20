using GestorPresupuesto.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorPresupuesto.Controller
{
    public class SettingsController : ISettingsController
    {
        public Settings Settings { get; set; }

        public SettingsController(IPersistenceController persistenceController)
        {
            this.Settings = persistenceController.Get().Settings;

            if (Settings.MonthContinuosExpenseMax == 0)
                this.Settings.MonthContinuosExpenseMax = 100;

            if (Settings.MonthExpenseMax == 0)
                this.Settings.MonthExpenseMax = 200;
        }
    }
}
