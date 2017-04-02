using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorPresupuesto.UserControl
{
    public partial class NewMonthForm : Form
    {
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

        }

        private void bCancel_Click(object sender, EventArgs e)
        {

        }
    }
}
