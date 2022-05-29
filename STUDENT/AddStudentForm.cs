using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class AddStudentForm : Form
    {
        public AddStudentForm()
        {
            InitializeComponent();
        }

        private void Male_ckd_CheckedChanged(object sender, EventArgs e)
        {
            if (Male_ckd.Checked)
            {
                Female_ckd.Checked = false;
            }
            else
            {
                Female_ckd.Checked = true;
            }
        }

        private void Female_ckd_CheckedChanged(object sender, EventArgs e)
        {
            if (Female_ckd.Checked)
            {
                Male_ckd.Checked = false;
            }
            else
            {
                Male_ckd.Checked = true;
            }
        }

        private void savsv_btn_Click(object sender, EventArgs e)
        {
            STUDENT st = new STUDENT();
            int id = Convert.ToInt32(stuID_tbx.Text);
            string fname = fname_tbx.Text;
            string lname = lname_tbx.Text;
            DateTime bdate = dateTimePicker1.Value;
            string phone = phone_tbx.Text;
            string address = adrs_tbx.Text;
            string gender = "Male";

            if (!Male_ckd.Checked)  
            {
                gender = "Female";
            }
            MemoryStream pic = new MemoryStream();

            int born_year = dateTimePicker1.Value.Year;
            int this_year = DateTime.Now.Year;
            if((this_year - born_year < 10) || (this_year - born_year > 100))
            {
                MessageBox.Show("The student age must between 10 and 100","Invalid birthdate");
            }
            else 
            {
                pictureBoxStu.Image.Save(pic, pictureBoxStu.Image.RawFormat);
                st.insertStudent(id, fname, lname, bdate, gender, phone, address, pic); //add
                MessageBox.Show("Success!");
                this.Close();
            }
        }

        private void AddPic_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            //ofd.Filter = "Select Image (*.jpg,*.png,*.gif)|*.jpg,*.png,*.gif ";
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBoxStu.Image = Image.FromFile(ofd.FileName);
            }
        }
    }
}
