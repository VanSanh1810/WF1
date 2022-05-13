using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class StudentList : Form
    {
        public StudentList()
        {
            InitializeComponent();
        }
        STUDENT student = new STUDENT();
        MY_DB db = new MY_DB();
        private void StudentList_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLSVDBDataSet.std' table. You can move, or remove it, as needed.
            this.stdTableAdapter.Fill(this.qLSVDBDataSet.std);
            SqlCommand command = new SqlCommand("SELECT * FROM std");
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = student.getStudent(command);
        }

        private void refres_btn_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM std");
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = student.getStudent(command);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            UpdateDeleteStudent a = new UpdateDeleteStudent();
            a.ID_tbx.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            a.fname_tbx.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            a.lname_tbx.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            a.dateTimePicker1.Value = (DateTime)dataGridView1.CurrentRow.Cells[3].Value;
            if(dataGridView1.CurrentRow.Cells[4].Value.ToString().Trim() == "Male")
            {
                a.male_btn.Checked = true;
                a.female_btn.Checked = false;
            }
            else
            {
                a.female_btn.Checked = true;
                a.male_btn.Checked = false;
            }
            a.phone_tbx.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            a.adrs_tbx.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();

            byte[] pic;
            pic = (byte[])dataGridView1.CurrentRow.Cells[7].Value;
            MemoryStream picture = new MemoryStream(pic);
            a.pictureBox1.Image = Image.FromStream(picture);
            this.Show();
            a.Show();
        }

        private void FWN_btn_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM std WHERE fname = @fname", db.getConnection);
            command.Parameters.Add("@fname", SqlDbType.VarChar).Value = FWN_tbx.Text.Trim();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if(table.Rows.Count == 0)
            {
                MessageBox.Show("Cant find student !");
            }
            else
            {
                FindWithName a = new FindWithName(FWN_tbx.Text.Trim());
                a.dataGridView_findwithname.DataSource = table;
                this.Show();
                a.Show();
            }
        }

        private void FWN_tbx_Leave(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM std WHERE fname = @fname", db.getConnection);
            command.Parameters.Add("@fname", SqlDbType.VarChar).Value = FWN_tbx.Text.Trim();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if (table.Rows.Count == 0)
            {
                errorProvider1.SetError(FWN_tbx, "Cant find student");
            }
            else
            {
                errorProvider1.Clear();
            }
        }
    }
}
