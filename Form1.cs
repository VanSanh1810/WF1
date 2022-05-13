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
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand("SELECT * FROM log_in WHERE username = @User AND password = @Pass",db.getConnection);
            command.Parameters.Add("@User", SqlDbType.VarChar).Value = usern_tbx.Text;
            command.Parameters.Add("@Pass", SqlDbType.VarChar).Value = pssw_txb.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);
            if(table.Rows.Count > 0)
            {
                //MessageBox.Show("Success");
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Fail!");
            }
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Register_btn_Click(object sender, EventArgs e)
        {
            RegisterForm a = new RegisterForm();
            this.Show();
            a.Show();
        }
    }
}
