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
    public partial class AddContact : Form
    {
        CONTACT ct = new CONTACT();
        public AddContact()
        {
            InitializeComponent();
        }

        private void AddContact_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLSVDBDataSet17.myGroup' table. You can move, or remove it, as needed.
            this.myGroupTableAdapter.Fill(this.qLSVDBDataSet17.myGroup);
            tbx_ID.Text = GlobalsVars.Global_HR_ID;
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

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (tbx_fname.Text == "" || tbx_lname.Text == "" || tbx_phone.Text == "" || tbx_email.Text == "" || tbx_address.Text == "" || pictureBox1.Image == null)
            {
                MessageBox.Show("Hãy điền đủ thông tin");
            }
            else
            {
                MemoryStream pic = new MemoryStream();
                pictureBox1.Image.Save(pic, pictureBox1.Image.RawFormat);
                ct.AddContact(tbx_fname.Text, tbx_lname.Text,comboBox1.SelectedValue.ToString(), tbx_phone.Text, tbx_email.Text , tbx_address.Text , pic);
                MessageBox.Show("Success !");
                this.Close();
            }
        }
    }
}
