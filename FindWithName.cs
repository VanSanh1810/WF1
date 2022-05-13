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
    public partial class FindWithName : Form
    {
        public string datafname;
        public FindWithName(string datafname)
        {
            InitializeComponent();
            this.datafname = datafname;
        }
        MY_DB db = new MY_DB();
        STUDENT student = new STUDENT();
        private void FindWithName_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView_findwithname_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            UpdateDeleteStudent a = new UpdateDeleteStudent();
            a.ID_tbx.Text = dataGridView_findwithname.CurrentRow.Cells[0].Value.ToString();
            a.fname_tbx.Text = dataGridView_findwithname.CurrentRow.Cells[1].Value.ToString();
            a.lname_tbx.Text = dataGridView_findwithname.CurrentRow.Cells[2].Value.ToString();
            a.dateTimePicker1.Value = (DateTime)dataGridView_findwithname.CurrentRow.Cells[3].Value;
            if (dataGridView_findwithname.CurrentRow.Cells[4].Value.ToString().Trim() == "Male")
            {
                a.male_btn.Checked = true;
                a.female_btn.Checked = false;
            }
            else
            {
                a.female_btn.Checked = true;
                a.male_btn.Checked = false;
            }
            a.phone_tbx.Text = dataGridView_findwithname.CurrentRow.Cells[5].Value.ToString();
            a.adrs_tbx.Text = dataGridView_findwithname.CurrentRow.Cells[6].Value.ToString();

            byte[] pic;
            pic = (byte[])dataGridView_findwithname.CurrentRow.Cells[7].Value;
            MemoryStream picture = new MemoryStream(pic);
            a.pictureBox1.Image = Image.FromStream(picture);
            this.Show();
            a.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM std WHERE fname = @fname");
            command.Parameters.Add("@fname", SqlDbType.VarChar).Value = datafname.Trim();
            dataGridView_findwithname.ReadOnly = true;
            dataGridView_findwithname.DataSource = student.getStudent(command);
        }
    }
}
