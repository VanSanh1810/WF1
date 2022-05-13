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
    public partial class UpdateDeleteStudent : Form
    {
        STUDENT Stu = new STUDENT();
        public UpdateDeleteStudent()
        {
            InitializeComponent();
        }

        private void male_btn_CheckedChanged(object sender, EventArgs e)
        {
            if (male_btn.Checked)
            {
                female_btn.Checked = false;
            }
            else
            {
                female_btn.Checked = true;
            }
        }

        private void female_btn_CheckedChanged(object sender, EventArgs e)
        {
            if (female_btn.Checked)
            {
                male_btn.Checked = false;
            }
            else
            {
                male_btn.Checked = true;
            }
        }

        private void find_btn_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(ID_tbx.Text);
            SqlCommand command = new SqlCommand("SELECT * FROM std WHERE id = " + id);
            DataTable dataTableStu = Stu.getStudent(command);

            if(dataTableStu.Rows.Count > 0)
            {
                fname_tbx.Text = dataTableStu.Rows[0]["fname"].ToString();
                lname_tbx.Text = dataTableStu.Rows[0]["lname"].ToString();
                dateTimePicker1.Value = (DateTime)dataTableStu.Rows[0]["bdate"];
                if(dataTableStu.Rows[0]["gender"].ToString() == "Male")
                {
                    male_btn.Checked = true;
                    female_btn.Checked = false;
                }
                else
                {
                    male_btn.Checked = false;
                    female_btn.Checked = true;
                }
                phone_tbx.Text = dataTableStu.Rows[0]["phone"].ToString();
                adrs_tbx.Text = dataTableStu.Rows[0]["address"].ToString();
                byte[] pic;
                pic = (byte[])dataTableStu.Rows[0]["pic"];
                MemoryStream picture = new MemoryStream(pic);
                pictureBox1.Image = Image.FromStream(picture);
            }
            else
            {
                MessageBox.Show("Not found !", "Find student");
            }
        }

        private void chagepic_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Select Image(*.jpg,*.png,*.gif)|*.jpg,*.png,*.gif";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void remove_btn_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(ID_tbx.Text);
            SqlCommand command = new SqlCommand("SELECT * FROM std WHERE id = " + id);
            DataTable dataTableStu = Stu.getStudent(command);

            if (dataTableStu.Rows.Count > 0)
            {
                SqlCommand command1 = new SqlCommand("DELETE FROM std WHERE id = " + id);
                Stu.getStudent(command1);
                MessageBox.Show("Success !", "Delete student");
                Close();
            }
            else
            {
                MessageBox.Show("Not found !", "Delete student");
            }
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(ID_tbx.Text);
            SqlCommand command = new SqlCommand("SELECT * FROM std WHERE id = " + id);
            DataTable dataTableStu = Stu.getStudent(command);

            if (dataTableStu.Rows.Count > 0)
            {
                SqlCommand command1 = new SqlCommand("UPDATE std SET fname = @fname, lname = @lname, bdate = @bdate, gender = @gender, phone = @phone, address = @address, pic = @pic WHERE id = " + id);
                command1.Parameters.Add("@fname", SqlDbType.VarChar).Value = fname_tbx.Text;
                command1.Parameters.Add("@lname", SqlDbType.VarChar).Value = lname_tbx.Text;
                command1.Parameters.Add("@bdate", SqlDbType.DateTime).Value = dateTimePicker1.Value;
                string gender;
                if(male_btn.Checked == true)
                {
                    gender = "Male";
                }
                else
                {
                    gender = "Female";
                }
                command1.Parameters.Add("@gender", SqlDbType.VarChar).Value = gender;

                command1.Parameters.Add("@phone", SqlDbType.VarChar).Value = phone_tbx.Text;
                command1.Parameters.Add("@address", SqlDbType.VarChar).Value = adrs_tbx.Text;

                MemoryStream pic = new MemoryStream();
                pictureBox1.Image.Save(pic, pictureBox1.Image.RawFormat);
                command1.Parameters.Add("@pic", SqlDbType.Image).Value = pic.ToArray();
                Stu.getStudent(command1);
                MessageBox.Show("Success !", "Find student");
            }
            else
            {
                MessageBox.Show("Not found !", "Find student");
            }
        }

        private void UpdateDeleteStudent_Load(object sender, EventArgs e)
        {

        }

        private void ID_tbx_Leave(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(ID_tbx.Text.Trim());
            SqlCommand command = new SqlCommand("SELECT * FROM std WHERE id = " + ID);
            DataTable dataTableStu = Stu.getStudent(command);
            if(dataTableStu.Rows.Count == 0)
            {
                errorProvider1.SetError(ID_tbx,"Cant find student");
            }
            else
            {
                errorProvider1.Clear();
            }
        }
    }
}
