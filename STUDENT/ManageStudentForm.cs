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
    public partial class ManageStudentForm : Form
    {
        STUDENT std = new STUDENT();
        MY_DB db = new MY_DB();
        public ManageStudentForm()
        {
            InitializeComponent();
        }

        private void ManageStudentForm_Load(object sender, EventArgs e)
        {
            fillGrig(new SqlCommand("SELECT * FROM std"));
        }
        private void fillGrig(SqlCommand command)
        {
            dataGridView1.ReadOnly = true;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            dataGridView1.RowTemplate.Height = 80;
            dataGridView1.DataSource = std.getStudent(command);
            picCol = (DataGridViewImageColumn)dataGridView1.Columns[7];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridView1.AllowUserToAddRows = false;
            lb_total_std.Text = "Total student: " + dataGridView1.Rows.Count.ToString();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tbx_ID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            tbx_fname.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            tbx_lname.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            dateTimePicker1.Value = (DateTime)dataGridView1.CurrentRow.Cells[3].Value;
            if (dataGridView1.CurrentRow.Cells[4].Value.ToString().Trim() == "Male")
            {
                male_btn.Checked = true;
                female_btn.Checked = false;
            }
            else
            {
                female_btn.Checked = true;
                male_btn.Checked = false;
            }
            tbx_phone.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            tbx_address.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();

            byte[] pic;
            pic = (byte[])dataGridView1.CurrentRow.Cells[7].Value;
            MemoryStream picture = new MemoryStream(pic);
            pictureBox1.Image = Image.FromStream(picture);
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM std WHERE CONCAT(fname, lname, address) LIKE '%" + tbx_search.Text + "%'");
            fillGrig(command);
        }

        private void tbx_search_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 8)
            {
                fillGrig(new SqlCommand("SELECT * FROM std"));
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (tbx_ID.Text.Trim() == "" || tbx_fname.Text.Trim() == "" || tbx_lname.Text.Trim() == "" || tbx_phone.Text.Trim() == "" || tbx_address.Text.Trim() == "" )
            {
                MessageBox.Show("Điền đủ thông tin !");
            }
            else
            {
                int id = Convert.ToInt32(tbx_ID.Text);
                string fname = tbx_fname.Text;
                string lname = tbx_lname.Text;
                DateTime bdate = dateTimePicker1.Value;
                string phone = tbx_phone.Text;
                string address = tbx_address.Text;
                string gender = "Male";

                if (!male_btn.Checked)
                {
                    gender = "Female";
                }
                MemoryStream pic = new MemoryStream();

                int born_year = dateTimePicker1.Value.Year;
                int this_year = DateTime.Now.Year;
                if ((this_year - born_year < 10) || (this_year - born_year > 100))
                {
                    MessageBox.Show("The student age must between 10 and 100", "Invalid birthdate");
                }
                else
                {
                    pictureBox1.Image.Save(pic, pictureBox1.Image.RawFormat);
                    std.insertStudent(id, fname, lname, bdate, gender, phone, address, pic); //add
                    fillGrig(new SqlCommand("SELECT * FROM std"));
                    MessageBox.Show("Success!");
                }
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(tbx_ID.Text);
            SqlCommand command = new SqlCommand("SELECT * FROM std WHERE id = " + id);
            DataTable dataTableStu = std.getStudent(command);

            if (dataTableStu.Rows.Count > 0)
            {
                SqlCommand command1 = new SqlCommand("UPDATE std SET fname = @fname, lname = @lname, bdate = @bdate, gender = @gender, phone = @phone, address = @address, pic = @pic WHERE id = " + id);
                command1.Parameters.Add("@fname", SqlDbType.VarChar).Value = tbx_fname.Text;
                command1.Parameters.Add("@lname", SqlDbType.VarChar).Value = tbx_lname.Text;
                command1.Parameters.Add("@bdate", SqlDbType.DateTime).Value = dateTimePicker1.Value;
                string gender;
                if (male_btn.Checked == true)
                {
                    gender = "Male";
                }
                else
                {
                    gender = "Female";
                }
                command1.Parameters.Add("@gender", SqlDbType.VarChar).Value = gender;

                command1.Parameters.Add("@phone", SqlDbType.VarChar).Value = tbx_phone.Text;
                command1.Parameters.Add("@address", SqlDbType.VarChar).Value = tbx_address.Text;

                MemoryStream pic = new MemoryStream();
                pictureBox1.Image.Save(pic, pictureBox1.Image.RawFormat);
                command1.Parameters.Add("@pic", SqlDbType.Image).Value = pic.ToArray();
                std.getStudent(command1);
                fillGrig(new SqlCommand("SELECT * FROM std"));
                MessageBox.Show("Success !", "Find student");
            }
            else
            {
                MessageBox.Show("Not found !", "Find student");
            }
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(tbx_ID.Text);
            SqlCommand command = new SqlCommand("SELECT * FROM std WHERE id = " + id);
            DataTable dataTableStu = std.getStudent(command);

            if (dataTableStu.Rows.Count > 0)
            {
                SqlCommand command1 = new SqlCommand("DELETE FROM std WHERE id = " + id);
                std.getStudent(command1);
                fillGrig(new SqlCommand("SELECT * FROM std"));
                MessageBox.Show("Success !", "Delete student");
            }
            else
            {
                MessageBox.Show("Not found !", "Delete student");
            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            tbx_ID.Text = "";
            tbx_fname.Text = "";
            tbx_lname.Text = "";
            tbx_phone.Text = "";
            tbx_address.Text = "";
            male_btn.Checked = true;
            pictureBox1.Image = null;
        }

        private void btn_upload_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Select Image(*.jpg,*.png,*.gif)|*.jpg,*.png,*.gif";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void tbx_ID_Leave(object sender, EventArgs e)
        {
            if(tbx_ID.Text.Trim() != "")
            {
                int ID = Convert.ToInt32(tbx_ID.Text.Trim());
                SqlCommand command = new SqlCommand("SELECT * FROM std WHERE id = " + ID);
                DataTable dataTableStu = std.getStudent(command);
                if (dataTableStu.Rows.Count == 0)
                {
                    errorProvider1.SetError(tbx_ID, "Cant find student");
                }
                else
                {
                    errorProvider1.Clear();
                }
            }
        }
    }
}
