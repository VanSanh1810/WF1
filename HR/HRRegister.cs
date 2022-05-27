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
    public partial class HRRegister : Form
    {
        HR hR = new HR();
        public HRRegister()
        {
            InitializeComponent();
            tbx_ID.Text = "HR" + DateTime.Now.Month.ToString()
                                + DateTime.Now.Day.ToString()
                                + DateTime.Now.Hour.ToString()
                                + DateTime.Now.Minute.ToString()
                                + DateTime.Now.Second.ToString();
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            if (tbx_fname.Text.Trim() == "" || tbx_lname.Text.Trim() == "" || tbx_username.Text.Trim() == "" || tbx_pass.Text.Trim() == "" || pictureBox1.Image == null)
            {
                MessageBox.Show("Điền đủ thông tin !");
            }
            else
            {
                if (!hR.CheckSameUsername(tbx_username.Text.Trim()))
                {
                    err_username.Clear();
                    MemoryStream pic = new MemoryStream();
                    pictureBox1.Image.Save(pic, pictureBox1.Image.RawFormat);
                    hR.RegisterHR(tbx_ID.Text, tbx_fname.Text, tbx_lname.Text, tbx_username.Text, tbx_pass.Text, pic);
                    MessageBox.Show("Success !");
                    this.Close();
                }
                else
                {
                    err_username.SetError(tbx_username, "Username exist !");
                }
            }
        }

        private void btn_upload_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Select Image (*.jpg,*.png,*.gif)|*.jpg;*.png;*.gif ";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void tbx_ID_Leave(object sender, EventArgs e)
        {
            if(tbx_ID.Text.Trim() == "")
            {
                err_ID.SetError(tbx_ID, "Empty!");
            }
            else
            {
                err_ID.Clear();
            }
        }

        private void tbx_fname_Leave(object sender, EventArgs e)
        {
            if (tbx_fname.Text.Trim() == "")
            {
                err_fname.SetError(tbx_fname, "Empty!");
            }
            else
            {
                err_fname.Clear();
            }
        }

        private void tbx_lname_Leave(object sender, EventArgs e)
        {
            if (tbx_lname.Text.Trim() == "")
            {
                err_lname.SetError(tbx_lname, "Empty!");
            }
            else
            {
                err_lname.Clear();
            }
        }

        private void tbx_username_Leave(object sender, EventArgs e)
        {
            if (tbx_username.Text.Trim() == "")
            {
                err_username.SetError(tbx_username, "Empty!");
            }
            else
            {
                err_username.Clear();
            }
        }

        private void tbx_pass_Leave(object sender, EventArgs e)
        {
            if (tbx_pass.Text.Trim() == "")
            {
                err_pass.SetError(tbx_pass, "Empty!");
            }
            else
            {
                err_pass.Clear();
            }
        }
    }
}
