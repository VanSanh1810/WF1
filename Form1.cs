using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            MY_DB db = new MY_DB();
            HR hR = new HR();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            if (rbtn_HR.Checked)
            {
                if (hR.CheckHRLogin(usern_tbx.Text, pssw_txb.Text))
                {
                    //MessageBox.Show("Success");
                    GlobalsVars.Set_Global_HR_ID(hR.GetID(usern_tbx.Text, pssw_txb.Text));
                    this.DialogResult = DialogResult.Yes;
                }
                else
                {
                    MessageBox.Show("Fail!");
                }
            }
            else
            {
                SqlCommand command = new SqlCommand("SELECT * FROM log_in WHERE username = @User AND password = @Pass", db.getConnection);
                command.Parameters.Add("@User", SqlDbType.VarChar).Value = usern_tbx.Text;
                command.Parameters.Add("@Pass", SqlDbType.VarChar).Value = pssw_txb.Text;

                adapter.SelectCommand = command;
                adapter.Fill(table);
                if (table.Rows.Count > 0)
                {
                    //MessageBox.Show("Success");
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Fail!");
                }
            }
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Register_btn_Click(object sender, EventArgs e)
        {
            if (rbtn_HR.Checked)
            {
                HRRegister a = new HRRegister();
                this.Show();
                a.Show();
            }
            else
            {
                RegisterForm a = new RegisterForm();
                this.Show();
                a.Show();
            }
        }

        private void usern_tbx_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                login_btn_Click(sender,e);
            }
        }

        private void pssw_txb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                login_btn_Click(sender, e);
            }
        }
    }
}
