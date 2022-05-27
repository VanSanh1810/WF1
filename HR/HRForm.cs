using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class HRForm : Form
    {
        HR hR = new HR();
        string ID;
        GROUP gr = new GROUP();
        CONTACT ct = new CONTACT();
        public HRForm(string userID)
        {
            this.ID = userID;
            InitializeComponent();
            FirstSetUp();
        }
        private void FirstSetUp()
        {
            pictureBox1.Image = Image.FromStream(hR.GetPic(ID));
            lb_username.Text = hR.GetInfo(1, ID) + " " +  hR.GetInfo(2, ID) + " (" + hR.GetInfo(3, ID) + ")";
        }
        private void ClearAll()
        {
            tbx_addGRName.Text = "";
            tbx_EditGRName.Text = "";
            textBox4.Text = "";
        }
        private void btn_addgroup_Click(object sender, EventArgs e)
        {
            if (tbx_addGRName.Text.Trim() != "")
            {
                gr.AddGroup(tbx_addGRName.Text);
                ClearAll();
                MessageBox.Show("Success !");
                this.myGroupTableAdapter.Fill(this.qLSVDBDataSet14.myGroup);
                comboBox1.DataSource = this.qLSVDBDataSet14.myGroup;
                comboBox2.DataSource = this.qLSVDBDataSet14.myGroup;
                tbx_addGRName.Text = "";
            }
            else
            {
                MessageBox.Show("Empty !");
            }
        }

        private void HRForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLSVDBDataSet14.myGroup' table. You can move, or remove it, as needed.
            this.myGroupTableAdapter.Fill(this.qLSVDBDataSet14.myGroup);

        }

        private void btn_editgroup_Click(object sender, EventArgs e)
        {
            if(tbx_EditGRName.Text.Trim() != "")
            {
                gr.EditGroup(comboBox1.SelectedValue.ToString().Trim(), tbx_EditGRName.Text);
                ClearAll();
                MessageBox.Show("Success !");
                this.myGroupTableAdapter.Fill(this.qLSVDBDataSet14.myGroup);
                comboBox1.DataSource = qLSVDBDataSet14.myGroup;
                comboBox2.DataSource = qLSVDBDataSet14.myGroup;
                tbx_EditGRName.Text = "";
            }
            else
            {
                MessageBox.Show("Empty !");
            }
        }

        private void btn_removegroup_Click(object sender, EventArgs e)
        {
            gr.DelGroup(comboBox2.SelectedValue.ToString().Trim());
            ClearAll();
            MessageBox.Show("Success !");
            this.myGroupTableAdapter.Fill(this.qLSVDBDataSet14.myGroup);
            comboBox1.DataSource = this.qLSVDBDataSet14.myGroup;
            comboBox2.DataSource = this.qLSVDBDataSet14.myGroup;
        }

        private void btn_showfullcontact_Click(object sender, EventArgs e)
        {
            ShowFullListContact a = new ShowFullListContact();
            a.Show(this);
        }

        private void btn_addcontact_Click(object sender, EventArgs e)
        {
            AddContact a = new AddContact();
            a.ShowDialog();
        }

        private void btn_editcontact_Click(object sender, EventArgs e)
        {
            DelContact a = new DelContact();
            a.Show(this);
        }

        private void llb_refresh_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FirstSetUp();
        }

        private void btn_selectcontactID_Click(object sender, EventArgs e)
        {
            SelectContact a = new SelectContact();
            if(a.ShowDialog() == DialogResult.OK)
            {
                textBox4.Text = GlobalsVars.Global_ConTract_ID;
            }
        }

        private void llb_editpro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            EditHRProfile a = new EditHRProfile(GlobalsVars.Global_HR_ID);
            a.Show(this);
        }

        private void btn_removecontact_Click(object sender, EventArgs e)
        {
            if(textBox4.Text.Trim() == "")
            {
                MessageBox.Show("Điền thông tin ID contact");
            }
            else
            {
                ct.DelContract(textBox4.Text.Trim());
                textBox4.Text = "";
            }
            
        }

        private void llb_logout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
        }
    }
}
