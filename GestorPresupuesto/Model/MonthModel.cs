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
        public int Month { get; set; }

        public int Year { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
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

        public override int GetHashCode()
        {
            return Year * 100 + Month;
        }

        public Boolean Equals(MonthModel other)
        {
            return other.Month.Equals(other.Month) && other.Year.Equals(other.Year);
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
