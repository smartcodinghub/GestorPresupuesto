using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorPresupuesto.Model
{
    public class Expense
    {
        public String Name { get; set; }

        public double Cost { get; set; }

        public Boolean IsFixed { get; set; }
    }
}
