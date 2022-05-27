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
    public partial class RemoveCourse : Form
    {
        COURSE cr = new COURSE();
        public RemoveCourse()
        {
            InitializeComponent();
        }

        private void remove_txb_Leave(object sender, EventArgs e)
        {
            if (!cr.CheckIDCourse(Convert.ToInt32(remove_txb.Text)))
            {
                errorProvider1.SetError(remove_txb, "Not exits");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void remove_btn_Click(object sender, EventArgs e)
        {
            if (cr.RemoveCourse(Convert.ToInt32(remove_txb.Text)))
            {
                errorProvider2.Clear();
            }
            else
            {
                errorProvider2.SetError(remove_btn, "error!");
            }
        }
    }
}
