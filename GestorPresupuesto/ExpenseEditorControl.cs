using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestorPresupuesto.Model;

namespace GestorPresupuesto
{
    public partial class ExpenseEditorControl : UserControl
    {
        private Expense expense;

        public Boolean IsEditing { get; private set; }


        public ExpenseEditorControl()
        {
            InitializeComponent();
            this.expense = null;
            this.IsEditing = false;
        }

        public void NewExpense()
        {
            this.CancelAndClearModification();
        }

        public void ModifyExpense(Expense expense)
        {
            SetExpense(expense);
            this.IsEditing = true;
        }

        public void CancelAndClearModification()
        {
            SetExpense(new Expense());
            this.IsEditing = false;
        }

        private void SetExpense(Expense expense)
        {
            this.expense = expense;
            this.tbConcept.Text = expense.Name;
            this.nCost.Value = expense.Cost;
            this.cbFixed.Checked = expense.IsFixed;
        }

        public (Boolean, Expense) CommitExpense()
        {
            if (nCost.Value > 0)
            {
                expense.Name = String.IsNullOrWhiteSpace(tbConcept.Text) ? "No hay concepto" : tbConcept.Text;
                expense.Cost = nCost.Value;
                expense.IsFixed = cbFixed.Checked;

                (Boolean, Expense) toReturn = (true, expense);

                return toReturn;
            }

            return (false, expense);
        }
    }
}
