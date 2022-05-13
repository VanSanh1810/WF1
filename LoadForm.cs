using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class LoadForm : Form
    {
        public LoadForm()
        {
            InitializeComponent();
            progressBar1.Value = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.PerformStep();
            label2.Text = progressBar1.Value.ToString() + "%";
            if (progressBar1.Value == 100)
            {
                this.DialogResult = DialogResult.OK;
                timer1.Dispose();
            }
        }
    }
}
