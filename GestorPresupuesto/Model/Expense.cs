using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorPresupuesto.Model
{
    public class Expense : IEquatable<Expense>
    {
        public String Name { get; set; }

        public decimal Cost { get; set; }

        public Boolean IsFixed { get; set; }

        public override int GetHashCode()
        {
            return this.Name?.GetHashCode() ?? 0 * 13
                + (int)Cost * 7 + (IsFixed ? 1 : 0);
        }

        public override bool Equals(object obj)
        {
            Expense other = obj as Expense;

            if (other != null)
                return Equals(other);

            return false;
        }

        public Boolean Equals(Expense other)
        {
            return String.Equals(other.Name, this.Name)
                && other.Cost.Equals(this.Cost)
                && other.IsFixed == this.IsFixed;
        }
    }
}
