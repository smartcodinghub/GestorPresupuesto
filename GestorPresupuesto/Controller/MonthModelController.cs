using GestorPresupuesto.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorPresupuesto.Controller
{
    public class MonthModelController
    {
        public HashSet<MonthModel> Meses { get; set; }

        public MonthModelController(IPersistenceController persistenceController)
        {
            this.Meses = persistenceController.Get().Months;
            this.AddTodaysMonth();
        }

        private void AddTodaysMonth()
        {
            Meses.Add(new MonthModel(DateTime.Now.Month, DateTime.Now.Year));
        }
    }
}
