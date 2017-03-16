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

            dataGridMonths.DataSource = modelController.AsViewModel();
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            persistenceController.Save(new Model.PersistenceEntity()
            {
                Settings = settingsController.Settings,
                Months = modelController.Months
            });
        }

        private void dataGridMonths_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridMonths.SelectedRows.Count > 0)
            {
                MonthViewModel[] monthModels = dataGridMonths.DataSource as MonthViewModel[];

                if (monthModels != null)
                {
                    int index = dataGridMonths.SelectedRows[0].Index;

                    if (index < monthModels.Length)
                    {
                        dataGridExpenses.DataSource = new ExpenseViewModel[]
                        {
                            new ExpenseViewModel(new Expense() { Name = "3x Raspberry Pi Zero", Cost = 20, IsFixed = false }),
                            new ExpenseViewModel(new Expense() { Name = "Flexo", Cost = 45, IsFixed = false }),
                            new ExpenseViewModel(new Expense() { Name = "Netflix", Cost = 12, IsFixed = true }),
                        };
                    }
                }
            }
        }
    }
}
