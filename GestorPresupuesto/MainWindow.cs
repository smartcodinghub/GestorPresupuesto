using GestorPresupuesto.Controller;
using GestorPresupuesto.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorPresupuesto
{
    public partial class MainWindow : Form
    {
        private MonthModelController modelController;
        private PersistenceController persistenceController;
        private SettingsController settingsController;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            persistenceController = new PersistenceController();

            settingsController = new SettingsController(persistenceController);
            modelController = new MonthModelController(persistenceController, settingsController);

            RefreshView();
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            persistenceController.Save(new Model.PersistenceEntity()
            {
                Settings = settingsController.Settings,
                Months = modelController.MonthsAsSet()
            });
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            MonthModel selectedMonth = this.GetSelectedMonth()?.Model;

            if (selectedMonth != null && !String.IsNullOrEmpty(tbConcept.Text) && nCost.Value > 0)
            {
                modelController.AddExpense(selectedMonth.Id, new Expense()
                {
                    Name = tbConcept.Text,
                    Cost = nCost.Value,
                    IsFixed = cbFixed.Checked
                });

                RefreshView();
            }
        }

        #region Datagrids Events

        private void dataGridMonths_SelectionChanged(object sender, EventArgs e)
        {
            MonthViewModel selectedMonth = this.GetSelectedMonth();

            if (selectedMonth != null)
            {
                dataGridExpenses.DataSource = modelController.ExpensesByMonthIdAsExpenseViewModel(selectedMonth.Model.Id);

                lblMonthTotal.Text = selectedMonth.ExpensesTotalCost.ToString("#,00");
                lblMonthFixedTotal.Text = selectedMonth.FixedExpensesTotalCost.ToString("#,00");
                lblMonthNonFixedTotal.Text = selectedMonth.NonFixedExpensesTotalCost.ToString("#,00");

                nMonthLimit.Value = selectedMonth.Model.ExpenseMax;
                nMonthContinuosLimit.Value = selectedMonth.Model.ContinuosExpenseMax;
            }
        }

        private void dataGridMonths_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e) => GridRightClick(dataGridMonths, contextMonths, e);
        private void dataGridExpenses_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e) => GridRightClick(dataGridExpenses, contextExpenses, e);

        private void GridRightClick(DataGridView dataGrid, ContextMenuStrip menu, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && e.Button == MouseButtons.Right)
            {
                dataGrid.ClearSelection();
                dataGrid.Rows[e.RowIndex].Selected = true;
                menu.Show(dataGrid, dataGrid.PointToClient(Cursor.Position));
            }
        }

        #endregion

        #region ContextMenus

        private void contextMenuEdit_Click(object sender, EventArgs e)
        {
            Expense expense = GetSelectedExpense()?.Model;
        }

        private void contextMenuDelete_Click(object sender, EventArgs e)
        {
            Expense selectedExpense = GetSelectedExpense()?.Model;
            MonthModel selectedMonth = this.GetSelectedMonth()?.Model;

            if (selectedMonth != null && selectedExpense != null)
            {
                modelController.RemoveExpense(selectedMonth.Id, selectedExpense);
                RefreshView();
            }
        }

        private void contextMenuAddMonth_Click(object sender, EventArgs e)
        {

        }

        private void contextMenuEditMonth_Click(object sender, EventArgs e)
        {

        }

        private void contextMenuDeleteMonth_Click(object sender, EventArgs e)
        {
            MonthModel selectedMonth = this.GetSelectedMonth()?.Model;

            if (selectedMonth != null)
            {
                modelController.RemoveMonth(selectedMonth.Id);
                RefreshView();
            }
        }

        #endregion

        private void nMonthContinuosLimit_Update(object sender, EventArgs e)
        {
            KeyEventArgs evt = e as KeyEventArgs;
            if (evt == null || evt.KeyCode == Keys.Enter)
                SetLimit(nMonthContinuosLimit.Value, (m, v) => m.ContinuosExpenseMax = v);
        }

        private void nMonthLimit_Update(object sender, EventArgs e)
        {
            KeyEventArgs evt = e as KeyEventArgs;
            if (evt == null || evt.KeyCode == Keys.Enter)
                SetLimit(nMonthLimit.Value, (m, v) => m.ExpenseMax = v);
        }

        private void SetLimit(decimal value, Action<MonthModel, decimal> set)
        {
            MonthModel selectedMonth = this.GetSelectedMonth()?.Model;

            if (selectedMonth != null)
            {
                set(selectedMonth, value);
                RefreshView();
            }
        }

        #region Helpers

        private void RefreshView()
        {
            dataGridMonths.DataSource = modelController.MonthsAsMonthViewModel();
            foreach (DataGridViewRow row in dataGridMonths.Rows)
            {
                if (Convert.ToBoolean(row.Cells[6].Value))
                {
                    row.DefaultCellStyle.BackColor = Color.Red;
                    row.DefaultCellStyle.ForeColor = Color.White;
                }
            }
        }

        private MonthViewModel GetSelectedMonth()
        {
            if (dataGridMonths.SelectedRows.Count > 0)
            {
                MonthViewModel[] monthModels = dataGridMonths.DataSource as MonthViewModel[];

                if (monthModels != null)
                {
                    int index = dataGridMonths.SelectedRows[0].Index;

                    if (index < monthModels.Length)
                        return monthModels[index];
                }
            }

            return null;
        }

        private ExpenseViewModel GetSelectedExpense()
        {
            if (dataGridExpenses.SelectedRows.Count > 0)
            {
                ExpenseViewModel[] expenseModels = dataGridExpenses.DataSource as ExpenseViewModel[];

                if (expenseModels != null)
                {
                    int index = dataGridExpenses.SelectedRows[0].Index;

                    if (index < expenseModels.Length)
                        return expenseModels[index];
                }
            }

            return null;
        }

        #endregion

        private class ExpenseEditor
        {
            private Expense expense;
            private TextBox txtConcept;
            private NumericUpDown nCost;
            private CheckBox cbFixed;

            public Boolean IsEditing { get; private set; }

            public ExpenseEditor(TextBox txtConcept, NumericUpDown nCost, CheckBox cbFixed)
            {
                this.expense = null;
                this.txtConcept = txtConcept;
                this.nCost = nCost;
                this.cbFixed = cbFixed;
                this.IsEditing = false;
            }

            public Boolean ModifyExpense(Expense expense)
            {
                if (!IsEditing)
                {
                    this.expense = expense;
                    this.IsEditing = true;
                    return true;
                }

                return false;
            }

            public (Boolean, Expense) CommitExpense()
            {
                if (IsEditing && nCost.Value > 0)
                {
                    expense.Name = String.IsNullOrWhiteSpace(txtConcept.Text) ? "No hay concepto" : txtConcept.Text;
                    expense.Cost = nCost.Value;
                    expense.IsFixed = cbFixed.Checked;

                    IsEditing = false;
                    expense = null;

                    return (true, expense);
                }

                return (false, expense);
            }
        }
    }
}
