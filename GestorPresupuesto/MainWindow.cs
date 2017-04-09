using GestorPresupuesto.Controller;
using GestorPresupuesto.Forms;
using GestorPresupuesto.Model;
using GestorPresupuesto.UserControls;
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
        private TelegramTask task;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            persistenceController = new PersistenceController();

            settingsController = new SettingsController(persistenceController);
            modelController = new MonthModelController(persistenceController, settingsController);

            task = new TelegramTask(new TelegramController(settingsController, modelController));
            task.OnFetchComplete = OnFetchComplete;
            task.Start();

            expenseEditor.NewExpense();

            RefreshView();
        }

        private void OnFetchComplete(int updatesProcessed)
        {
            if (updatesProcessed > 0) Invoke(new Action(() => RefreshView()));
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

            var (correct, expense) = expenseEditor.CommitExpense();
            if (selectedMonth != null && correct)
            {
                /* If not editing, add it */
                if (!expenseEditor.IsEditing)
                    modelController.AddExpense(selectedMonth.Id, expense);

                ClearExpenseEditor();

                RefreshView();
            }
        }

        private void bClear_Click(object sender, EventArgs e)
        {
            ClearExpenseEditor();
        }

        private void ClearExpenseEditor()
        {
            expenseEditor.CancelAndClearModification();
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
            EditMonth();
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
            var (addNew, month) = NewMonthForm.ShowForm();

            if (addNew)
            {
                modelController.AddMonth(month);
                RefreshView();
            }
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

        private void EditMonth()
        {
            Expense expense = GetSelectedExpense()?.Model;

            expenseEditor.ModifyExpense(expense);
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
            int selected = dataGridMonths.SelectedRows.OfType<DataGridViewRow>().FirstOrDefault()?.Index ?? 0;
            int count = dataGridMonths.RowCount;

            dataGridMonths.DataSource = modelController.MonthsAsMonthViewModel();

            foreach (DataGridViewRow row in dataGridMonths.Rows)
            {
                if (Convert.ToBoolean(row.Cells[6].Value))
                {
                    row.DefaultCellStyle.BackColor = Color.Red;
                    row.DefaultCellStyle.ForeColor = Color.White;
                }
            }

            int diff = Math.Max(count - dataGridMonths.RowCount, 0);

            dataGridMonths.ClearSelection();

            if (dataGridMonths.Rows.Count > 0)
                dataGridMonths.Rows[Math.Max(0, selected - diff)].Selected = true;
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

        private void dataGridExpenses_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                EditMonth();
            }
        }
    }
}
