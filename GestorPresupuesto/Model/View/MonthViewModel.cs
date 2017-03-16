using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorPresupuesto.Model
{
    public class MonthViewModel
    {
        public readonly MonthModel Model;

        public String MonthTitle => String.Format("{0:00}/{1}", Model.Month, Model.Year);
        public int NonFixedExpensesCount => Model.Expenses.Count(e => e.IsFixed);
        public double NonFixedExpensesTotalCost => Model.Expenses.Where(e => e.IsFixed).Sum(e => e.Cost);
        public int ExpensesCount => Model.Expenses.Count;
        public double ExpensesTotalCost => Model.Expenses.Sum(e => e.Cost);

        public MonthViewModel(MonthModel model)
        {
            this.Model = model;
        }
    }
}
