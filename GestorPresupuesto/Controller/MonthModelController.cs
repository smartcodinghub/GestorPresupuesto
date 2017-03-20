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
        public Dictionary<int, MonthModel> Months { get; set; }

        public MonthModelController(IPersistenceController persistenceController, ISettingsController settingsController)
        {
            this.Months = persistenceController.Get().Months.ToDictionary(m => m.Id);
            this.AddTodaysMonth(settingsController.Settings);
        }

        public void SaveNewExpense(int id, Expense expense)
        {
            if (Months.ContainsKey(id))
                this.Months[id].Expenses.Add(expense);
        }

        public ExpenseViewModel[] ExpensesByMonthIdAsExpenseViewModel(int id)
        {
            return this.Months[id].Expenses.Select(e => new ExpenseViewModel(e)).ToArray();
        }

        public MonthViewModel[] MonthsAsMonthViewModel()
        {
            return this.Months.Values.Select(m => new MonthViewModel(m)).ToArray();
        }

        public HashSet<MonthModel> MonthsAsSet()
        {
            return new HashSet<MonthModel>(this.Months.Values);
        }

        private void AddTodaysMonth(Settings settings)
        {
            MonthModel model = new MonthModel(DateTime.Now);

            if (!Months.ContainsKey(model.Id))
            {
                model.ContinuosExpenseMax = settings.MonthContinuosExpenseMax;
                model.ExpenseMax = settings.MonthExpenseMax;
                this.Months[model.Id] = model;
            }
        }
    }
}
