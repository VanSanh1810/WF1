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
    public partial class ManageCourse : Form
    {
        COURSE cr = new COURSE();
        public ManageCourse()
        {
            InitializeComponent();
        }

        private void ManageCourse_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLSVDBDataSet9.Course' table. You can move, or remove it, as needed.
            this.courseTableAdapter1.Fill(this.qLSVDBDataSet9.Course);
            // TODO: This line of code loads data into the 'qLSVDBDataSet1.Course' table. You can move, or remove it, as needed.


        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            AddCourse a = new AddCourse(dataGridView1.CurrentRow.Cells[0].Value.ToString(), 
                                        dataGridView1.CurrentRow.Cells[1].Value.ToString(), 
                                        Convert.ToInt32(dataGridView1.CurrentRow.Cells[2].Value.ToString().Trim()), 
                                        dataGridView1.CurrentRow.Cells[3].Value.ToString());
            a.Show(this);
        }

        private void refresh_btn_Click(object sender, EventArgs e)
        {
            this.courseTableAdapter1.Fill(this.qLSVDBDataSet9.Course);
        }

        private void find_btn_Click(object sender, EventArgs e)
        {
            if(find_txb.Text.Trim() != "")
            {
                dataGridView1.DataSource = cr.getCourseID(Convert.ToInt32(find_txb.Text));
                errorProvider1.Clear();
            }
            else
            {
                errorProvider1.SetError(find_txb, "Empty!");
            }
        }
    }
}
