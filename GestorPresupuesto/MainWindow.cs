using GestorPresupuesto.Controller;
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
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            persistenceController.Save(new Model.PersistenceEntity()
            {
                Settings = settingsController.Settings,
                Months = modelController.Months
            });
        }
    }
}
