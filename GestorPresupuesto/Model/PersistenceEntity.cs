using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorPresupuesto.Model
{
    public class PersistenceEntity
    {
        public Settings Settings { get; set; }

        public List<MonthModel> Months { get; set; }

        public PersistenceEntity()
        {
            this.Months = new List<MonthModel>();
            this.Settings = new Settings();
        }
    }
}
