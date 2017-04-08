using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorPresupuesto.Model
{
    public class MonthModel : IEquatable<MonthModel>
    {
        [JsonIgnore]
        public int Id => Year * 100 + Month;

        public int Month { get; set; }
        public int Year { get; set; }
        public decimal ExpenseMax { get; set; }
        public decimal ContinuosExpenseMax { get; set; }

        private List<Expense> expenses;
        public List<Expense> Expenses { get => expenses; set { if (value != null) expenses = value; } }


        public MonthModel()
        {
            this.Expenses = new List<Expense>();
        }

        public MonthModel(int month, int year) : this()
        {
            this.Month = month;
            this.Year = year;
        }

        public MonthModel(DateTime date) : this(date.Month, date.Year) { }

        public override int GetHashCode()
        {
            return Id;
        }

        public Boolean Equals(MonthModel other)
        {
            return other.Month.Equals(this.Month) && other.Year.Equals(this.Year);
        }

        public override bool Equals(object obj)
        {
            MonthModel other = obj as MonthModel;

            if (other != null)
                return Equals(other);

            return false;
        }
    }
}
