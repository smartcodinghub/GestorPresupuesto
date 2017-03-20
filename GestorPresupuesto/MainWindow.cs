﻿using GestorPresupuesto.Controller;
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

        private void dataGridMonths_SelectionChanged(object sender, EventArgs e)
        {
            MonthViewModel selectedMonth = this.GetSelectedMonth();

            if (selectedMonth != null)
            {
                dataGridExpenses.DataSource = modelController.ExpensesByMonthIdAsExpenseViewModel(selectedMonth.Model.Id);

                lblMonthTotal.Text = selectedMonth.ExpensesTotalCost.ToString("#,00");

                nMonthLimit.Value = selectedMonth.Model.ExpenseMax;
                nMonthContinuosLimit.Value = selectedMonth.Model.ContinuosExpenseMax;
            }
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

                RefreshView();
            }
        }

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
    }
}
