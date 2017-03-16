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
        public HashSet<MonthModel> Months { get; set; }

        public MonthModelController(IPersistenceController persistenceController)
        {
            this.Months = persistenceController.Get().Months;
            this.AddTodaysMonth();
        }

        public MonthViewModel[] AsViewModel()
        {
            return this.Months.Select(m => new MonthViewModel(m)).ToArray();
        }

        private void AddTodaysMonth()
        {
            Months.Add(new MonthModel(DateTime.Now.Month, DateTime.Now.Year));
        }
    }
}
