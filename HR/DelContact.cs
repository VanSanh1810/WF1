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
    public partial class DelContact : Form
    {
        CONTACT ct = new CONTACT();
        public DelContact()
        {
            InitializeComponent();

            GlobalsVars.Set_Global_ConTract_ID("");
        }

        private void DelContact_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLSVDBDataSet16.myGroup' table. You can move, or remove it, as needed.
            this.myGroupTableAdapter.Fill(this.qLSVDBDataSet16.myGroup);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SelectContact a = new SelectContact();
            if(a.ShowDialog() == DialogResult.OK)
            {
                tbx_ID.Text = ct.GetInFo(0, GlobalsVars.Global_ConTract_ID);
                tbx_fname.Text = ct.GetInFo(1, GlobalsVars.Global_ConTract_ID);
                tbx_lname.Text = ct.GetInFo(2, GlobalsVars.Global_ConTract_ID);
                comboBox1.SelectedValue = ct.GetInFo(3, GlobalsVars.Global_ConTract_ID);
                tbx_phone.Text = ct.GetInFo(4, GlobalsVars.Global_ConTract_ID);
                tbx_email.Text = ct.GetInFo(5, GlobalsVars.Global_ConTract_ID);
                tbx_address.Text = ct.GetInFo(6, GlobalsVars.Global_ConTract_ID);
                pictureBox1.Image = Image.FromStream(ct.GetPic(GlobalsVars.Global_ConTract_ID));
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if(tbx_ID.Text == "" || tbx_fname.Text == "" || tbx_lname.Text == "" || tbx_phone.Text == "" || tbx_email.Text == "" || tbx_address.Text == "" || pictureBox1.Image == null)
            {
                MessageBox.Show("Điền đầy đủ thông tin");
            }
            else
            {
                MemoryStream pic = new MemoryStream();
                pictureBox1.Image.Save(pic, pictureBox1.Image.RawFormat);
                ct.EditContact(tbx_ID.Text, tbx_fname.Text, tbx_lname.Text,comboBox1.SelectedValue.ToString(), tbx_phone.Text, tbx_email.Text, tbx_address.Text, pic);
                MessageBox.Show("Success !");
            }
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            if(tbx_ID.Text == "")
            {
                MessageBox.Show("Thiếu Contact ID");
            }
            else
            {
                ct.DelContract(tbx_ID.Text);
                MessageBox.Show("Success !");
                this.Close();
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
    }
}
