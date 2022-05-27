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
    public partial class ShowFullListContact : Form
    {
        CONTACT ct = new CONTACT();
        public ShowFullListContact()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.contactTableAdapter.Fill(this.qLSVDBDataSet18.contact);
            dataGridView1.DataSource = this.qLSVDBDataSet18.contact;
        }

        private void ShowFullListContact_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLSVDBDataSet19.myGroup' table. You can move, or remove it, as needed.
            this.myGroupTableAdapter.Fill(this.qLSVDBDataSet19.myGroup);
            // TODO: This line of code loads data into the 'qLSVDBDataSet18.contact' table. You can move, or remove it, as needed.
            this.contactTableAdapter.Fill(this.qLSVDBDataSet18.contact);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedValue != null)
            {
                dataGridView1.DataSource = ct.GetContactWithGroup(comboBox1.SelectedValue.ToString().Trim());
            }
        }
    }
}
