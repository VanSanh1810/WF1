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
    public partial class SelectContact : Form
    {
        CONTACT ct = new CONTACT();
        public SelectContact()
        {
            InitializeComponent();
        }

        private void SelectContact_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLSVDBDataSet15.contact' table. You can move, or remove it, as needed.
            ///this.contactTableAdapter.Fill(this.qLSVDBDataSet15.contact);
            dataGridView1.DataSource = ct.GetContact(new System.Data.SqlClient.SqlCommand("SELECT * FROM contact"));
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //return dataGridView1.CurrentRow.Cells[0].Value.ToString().Trim();
            GlobalsVars.Set_Global_ConTract_ID(dataGridView1.CurrentRow.Cells[0].Value.ToString().Trim());
            Close();
            this.DialogResult = DialogResult.OK;
        }

        private void SelectContact_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
