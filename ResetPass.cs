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
    public partial class ResetPass : Form
    {
        MY_DB dB = new MY_DB();
        HR hR = new HR();

        public ResetPass()
        {
            InitializeComponent();
            textBox1.Text = GlobalsVars.Global_UserNameFG_ID.Trim();
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            MY_DB db = new MY_DB();
            HR hR = new HR();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            if (textBox1.Text.Trim() == "")
            {
                errorProvider1.SetError(textBox1, "Empty");
            }
            else
            {
                errorProvider1.Clear();
                switch (GlobalsVars.Global_FGPass_Type)
                {
                    case 0: //HR
                        {
                            SqlCommand command = new SqlCommand("SELECT * FROM User_HR WHERE uname = @User", db.getConnection);
                            command.Parameters.Add("@User", SqlDbType.VarChar).Value = textBox1.Text;


                            adapter.SelectCommand = command;
                            adapter.Fill(table);
                            if (table.Rows.Count > 0)
                            {
                                //MessageBox.Show("Success");

                            }
                            else
                            {
                                errorProvider1.SetError(textBox1, "KHông tồn tại Username này");
                            }
                            break;
                        }
                    case 1: //Student
                        {
                            SqlCommand command = new SqlCommand("SELECT * FROM log_in WHERE username = @User", db.getConnection);
                            command.Parameters.Add("@User", SqlDbType.VarChar).Value = textBox1.Text;

                            adapter.SelectCommand = command;
                            adapter.Fill(table);
                            if (table.Rows.Count > 0)
                            {
                                //MessageBox.Show("Success");
                                
                            }
                            else
                            {
                                errorProvider1.SetError(textBox1, "KHông tồn tại Username này");
                            }
                            break;
                        }
                }
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(textBox2.Text.Trim() != textBox3.Text.Trim())
            {
                errorProvider2.SetError(textBox2, "Mật khẩu nhập lại không trùng");
            }
            else
            {
                errorProvider2.Clear();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MY_DB db = new MY_DB();
            HR hR = new HR();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            if (textBox1.Text.Trim() == "")
            {
                errorProvider1.SetError(textBox1, "Empty");
            }
            else
            {
                errorProvider1.Clear();
                switch (GlobalsVars.Global_FGPass_Type)
                {
                    case 0: //HR
                        {
                            SqlCommand command = new SqlCommand("SELECT * FROM User_HR WHERE uname = @User", db.getConnection);
                            command.Parameters.Add("@User", SqlDbType.VarChar).Value = textBox1.Text;


                            adapter.SelectCommand = command;
                            adapter.Fill(table);
                            if (table.Rows.Count > 0)
                            {
                                //MessageBox.Show("Success");
                                if (textBox2.Text.Trim() != textBox3.Text.Trim())
                                {
                                    errorProvider2.SetError(textBox2, "Mật khẩu nhập lại không trùng");
                                }
                                else
                                {
                                    errorProvider2.Clear();
                                    hR.EDITRegisterHR_FGP(textBox1.Text, textBox3.Text);
                                    MessageBox.Show("Success !");
                                    this.Close();
                                }
                            }
                            else
                            {
                                errorProvider1.SetError(textBox1, "KHông tồn tại Username này");
                            }
                            break;
                        }
                    case 1: //Student
                        {
                            SqlCommand command = new SqlCommand("SELECT * FROM log_in WHERE username = @User", db.getConnection);
                            command.Parameters.Add("@User", SqlDbType.VarChar).Value = textBox1.Text;

                            adapter.SelectCommand = command;
                            adapter.Fill(table);
                            if (table.Rows.Count > 0)
                            {
                                //MessageBox.Show("Success");
                                if (textBox2.Text.Trim() != textBox3.Text.Trim())
                                {
                                    errorProvider2.SetError(textBox2, "Mật khẩu nhập lại không trùng");
                                }
                                else
                                {
                                    errorProvider2.Clear();
                                    SqlCommand command1 = new SqlCommand("UPDATE log_in SET password = @Pass WHERE username = @User", db.getConnection);
                                    command1.Parameters.Add("@User", SqlDbType.VarChar).Value = textBox1.Text;
                                    command1.Parameters.Add("@Pass", SqlDbType.VarChar).Value = textBox3.Text;
                                    dB.openConnection();
                                    if (command.ExecuteNonQuery() == 1)
                                    {
                                        dB.openConnection();
                                    }
                                    else
                                    {
                                        dB.openConnection();
                                    }
                                    MessageBox.Show("Success !");
                                    this.Close();
                                }
                            }
                            else
                            {
                                errorProvider1.SetError(textBox1, "KHông tồn tại Username này");
                            }
                            break;
                        }
                }
            }
        }
    }
}
