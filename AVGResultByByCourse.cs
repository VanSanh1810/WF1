using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class AVGResultByByCourse : Form
    {
        STUDENT st = new STUDENT();
        SCORE sc = new SCORE();
        public AVGResultByByCourse()
        {
            InitializeComponent();
        }

        private void AVGResultByByCourse_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLSVDBDataSet7.std' table. You can move, or remove it, as needed.
            this.stdTableAdapter.Fill(this.qLSVDBDataSet7.std);

        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable a = new DataTable();
            a = sc.getScoreInfoStu(Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value.ToString().Trim()));
            if(a.Rows.Count != 0)
            {
                mainboard.DataSource = a;
            }
            else
            {
                MessageBox.Show("Student dont have course");
            }
        }

        private void find_btn_Click(object sender, EventArgs e)
        {
            if(ID_tbx.Text.Trim() == "")
            {
                this.stdTableAdapter.Fill(this.qLSVDBDataSet7.std);
                dataGridView2.DataSource = this.qLSVDBDataSet7.std;
            }
            else
            {
                SqlCommand command = new SqlCommand("SELECT Id, fname, lname FROM std WHERE Id = @id");
                command.Parameters.Add("@id", SqlDbType.Int).Value = Convert.ToInt32(ID_tbx.Text);
                dataGridView2.DataSource = st.getStudent(command);
            }
        }

        private void ID_tbx_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if(ID_tbx.Text == "")
            {
                this.stdTableAdapter.Fill(this.qLSVDBDataSet7.std);
            }
        }
    }
}
