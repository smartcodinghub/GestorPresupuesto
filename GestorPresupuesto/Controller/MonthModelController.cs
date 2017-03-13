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
        public List<MonthModel> Meses { get; set; }

        public MonthModelController()
        {
            this.Meses = new List<MonthModel>();
        }
    }
}
