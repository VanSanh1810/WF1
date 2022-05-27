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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }
        MY_DB db = new MY_DB();
        private void signup_btn_Click(object sender, EventArgs e)
        {
            if(usern_tbx.TextLength > 0 && pssw_tbx.TextLength > 0 && rpssw_tbx.TextLength > 0)
            {
                SqlCommand command1 = new SqlCommand("SELECT * FROM log_in WHERE username = @user", db.getConnection);
                command1.Parameters.Add("@user", SqlDbType.VarChar).Value = usern_tbx.Text;
                SqlDataAdapter adapter1 = new SqlDataAdapter(command1);
                DataTable table = new DataTable();
                adapter1.Fill(table);
                if(table.Rows.Count == 0)
                {
                    if (!pssw_tbx.Text.Equals(rpssw_tbx.TextLength))
                    {
                        SqlCommand command = new SqlCommand("INSERT INTO log_in(Id,username,password) VALUES (@id,@user,@pass)", db.getConnection);
                        command.Parameters.Add("@id", SqlDbType.Int).Value = Convert.ToInt32(DateTime.Now.Day.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Year.ToString());
                        command.Parameters.Add("@user", SqlDbType.VarChar).Value = usern_tbx.Text;
                        command.Parameters.Add("@pass", SqlDbType.VarChar).Value = pssw_tbx.Text;
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        db.openConnection();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Success");
                    }
                    else
                    {
                        MessageBox.Show("Password and re_password are not the same !");
                    }
                }
                else
                {
                    MessageBox.Show("Username already exist !");
                }
                
            }
            else
            {
                MessageBox.Show("Fill the information !");
            }
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void usern_tbx_Leave(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM log_in WHERE username = @username ", db.getConnection);
            command.Parameters.Add("@username", SqlDbType.VarChar).Value = usern_tbx.Text.Trim();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable tb = new DataTable();
            adapter.Fill(tb);
            if(tb.Rows.Count > 0)
            {
                usern_tbx.Focus();
                errorProvider1.SetError(usern_tbx, "Username exist !!");
            }
            else
            {
                errorProvider1.SetError(usern_tbx, null);
            }
        }

        private void lklb_goback_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Close();
        }
    }
}
