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
    public partial class EditHRProfile : Form
    {
        HR hR = new HR();
        string ID;
        public EditHRProfile(string ID)
        {
            InitializeComponent();
            this.ID = ID;
        }

        private void EditHRProfile_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromStream(hR.GetPic(ID));
            tbx_ID.Text = ID;
            tbx_fname.Text = hR.GetInfo(1, ID);
            tbx_lname.Text = hR.GetInfo(2, ID);
            tbx_username.Text = hR.GetInfo(3, ID);
            tbx_pass.Text = hR.GetInfo(4, ID);
        }

        private void tbx_username_Leave(object sender, EventArgs e)
        {
            if (hR.CheckHRLogin(tbx_username.Text, tbx_pass.Text))
            {
                //MessageBox.Show("Username đã tồn tại !");
                errorProvider1.SetError(tbx_username, "Username đã tồn tại !");
            }
            else
            {
                errorProvider1.Clear();
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

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (tbx_fname.Text == ""|| tbx_lname.Text == "" || tbx_username.Text == "" || tbx_pass.Text == "" ||pictureBox1.Image == null)
            {
                MessageBox.Show("Hãy điền đủ thông tin !");
            }
            else
            {
                errorProvider1.Clear();
                MemoryStream pic = new MemoryStream();
                pictureBox1.Image.Save(pic, pictureBox1.Image.RawFormat);
                if(hR.EDITRegisterHR(ID, tbx_fname.Text, tbx_lname.Text, tbx_username.Text, tbx_pass.Text, pic))
                {
                    MessageBox.Show("Success !!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
        }
    }
}
