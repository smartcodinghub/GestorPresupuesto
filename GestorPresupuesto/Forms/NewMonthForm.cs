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

namespace GestorPresupuesto.Forms
{
    public partial class NewMonthForm : Form
    {
        public static (Boolean, MonthModel) ShowForm()
        {
            NewMonthForm form = new NewMonthForm();
            form.ShowDialog();

            return (form.DialogResult == DialogResult.OK, form.Month);
        }

        public MonthModel Month { get; set; }

        public NewMonthForm()
        {
            InitializeComponent();
        }

        private void NewMonthForm_Load(object sender, EventArgs e)
        {
            this.nMonth.Value = DateTime.Now.Month;
            this.nYear.Value = DateTime.Now.Year;
        }

        private void bOk_Click(object sender, EventArgs e)
        {
            Month = new MonthModel((int)nMonth.Value, (int)nYear.Value);
            DialogResult = DialogResult.OK;
            Close();
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
