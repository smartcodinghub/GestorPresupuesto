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
        private ISettingsController settingsController;
        public Dictionary<int, MonthModel> Months { get; set; }

        public MonthModelController(IPersistenceController persistenceController, ISettingsController settingsController)
        {
            this.Months = persistenceController.Get().Months.ToDictionary(m => m.Id);
            this.settingsController = settingsController;
            this.AddMonthInner(DateTime.Now);
        }

        private void AddMonthInner(DateTime time)
        {
            AddMonthInner(new MonthModel(time));
        }

        private void AddMonthInner(int month, int year)
        {
            AddMonthInner(new MonthModel(month, year));
        }

        private void AddMonthInner(MonthModel model)
        {
            if (!Months.ContainsKey(model.Id))
            {
                Settings settings = settingsController.Settings;

                model.ContinuosExpenseMax = settings.MonthContinuosExpenseMax;
                model.ExpenseMax = settings.MonthExpenseMax;

                this.Months[model.Id] = model;
            }
        }

        public void AddMonth(MonthModel month)
        {
            if (!Months.ContainsKey(month.Id))
                this.Months.Add(month.Id, month);
        }

        public void AddExpense(int id, Expense expense)
        {
            /* If it doesn't exists, create it */
            if (!Months.ContainsKey(id))
                AddMonthInner(id % 100, id / 100);

            this.Months[id].Expenses.Add(expense);
        }

        public void RemoveMonth(int id)
        {
            this.Months.Remove(id);
        }

        public void RemoveExpense(int id, Expense expense)
        {
            if (Months.ContainsKey(id))
                this.Months[id].Expenses.Remove(expense);
        }

        public ExpenseViewModel[] ExpensesByMonthIdAsExpenseViewModel(int id)
        {
            return this.Months[id].Expenses.Select(e => new ExpenseViewModel(e)).ToArray();
        }

        public MonthViewModel[] MonthsAsMonthViewModel()
        {
            return this.Months.Values.OrderByDescending(m => m.Month).ThenByDescending(m => m.Year).Select(m => new MonthViewModel(m)).ToArray();
        }

        public HashSet<MonthModel> MonthsAsSet()
        {
            return new HashSet<MonthModel>(this.Months.Values);
        }
    }
}
