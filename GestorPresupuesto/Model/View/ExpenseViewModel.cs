using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorPresupuesto.Model
{
    public class ExpenseViewModel
    {
        public readonly Expense Model;

        public String Name => Model.Name;
        public decimal Cost => Model.Cost;
        public Boolean IsFixed => Model.IsFixed;

        public ExpenseViewModel(Expense model)
        {
            this.Model = model;
        }
    }
}
