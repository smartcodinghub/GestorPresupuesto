using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorPresupuesto.Model
{
    public class MonthModel
    {
        public int Month { get; set; }

        public int Year { get; set; }

        public List<Expense> Expenses { get; set; }

        public MonthModel()
        {
            this.Expenses = new List<Expense>();
        }

        public MonthModel(int month, int year) : base()
        {
            this.Month = month;
            this.Year = year;
        }
    }
}
