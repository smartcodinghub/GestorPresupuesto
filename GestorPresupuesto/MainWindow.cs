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

            modelController = new MonthModelController(persistenceController);
            settingsController = new SettingsController(persistenceController);

            dataGridMonths.DataSource = modelController.MonthsAsMonthViewModel();
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            persistenceController.Save(new Model.PersistenceEntity()
            {
                Settings = settingsController.Settings,
                Months = modelController.MonthsAsSet()
            });
        }

        private void dataGridMonths_SelectionChanged(object sender, EventArgs e)
        {
            MonthModel selectedMonth = this.GetSelectedMonth()?.Model;

            if (selectedMonth != null)
                dataGridExpenses.DataSource = modelController.ExpensesByMonthIdAsExpenseViewModel(selectedMonth.Id);
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            MonthModel selectedMonth = this.GetSelectedMonth()?.Model;

            if (selectedMonth != null)
            {
                modelController.SaveNewExpense(selectedMonth.Id, new Expense()
                {
                    Name = "Prueba añadido",
                    Cost = 110,
                    IsFixed = true
                });

                dataGridMonths.DataSource = modelController.MonthsAsMonthViewModel();
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
    }
}
