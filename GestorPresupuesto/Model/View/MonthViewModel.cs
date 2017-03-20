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

        public decimal NonFixedExpensesTotalCost => Model.Expenses.Where(e => !e.IsFixed).Sum(e => e.Cost);
        public decimal FixedExpensesTotalCost => Model.Expenses.Where(e => e.IsFixed).Sum(e => e.Cost);
        public decimal ExpensesTotalCost => Model.Expenses.Sum(e => e.Cost);

        public decimal ExpenseMax => Model.ExpenseMax;
        public decimal ContinuosExpenseMax => Model.ContinuosExpenseMax;

        public Boolean IsOverLimit => ExpensesTotalCost > (ExpenseMax + ContinuosExpenseMax)
                                      || NonFixedExpensesTotalCost > ExpenseMax
                                      || ExpensesTotalCost - NonFixedExpensesTotalCost > (ContinuosExpenseMax);

        public MonthViewModel(MonthModel model)
        {
            this.Model = model;
        }
    }
}
