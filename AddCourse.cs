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
    public partial class AddCourse : Form
    {
        COURSE CR = new COURSE();
        public AddCourse()
        {
            InitializeComponent();
            edit_btn.Enabled = false;
            edit_btn.Visible = false;
            del_btn.Enabled = false;
            del_btn.Visible = false;
        }
        public AddCourse(string id, string label, int period, string decription)
        {
            InitializeComponent();
            textBox1.Text = id.Trim();
            textBox2.Text = label.Trim();
            textBox4.Text = decription.Trim();
            decimal d = period;
            numericUpDown1.Value = d;
            button1.Enabled = false;
            button1.Visible = false;
            ID_err.Dispose();
            textBox1.Enabled = false;
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (CR.CheckIDCourse(Convert.ToInt32(textBox1.Text)))
            {
                ID_err.Clear();
            }
            else
            {
                ID_err.SetError(textBox1, "Already exist");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
                if (CR.CheckIDCourse(Convert.ToInt32(textBox1.Text)))
                {
                    ID_err.Clear();
                    if (CR.AddCourse(Convert.ToInt32(textBox1.Text), textBox2.Text, decimal.ToInt32(numericUpDown1.Value), textBox4.Text))
                    {
                        ID_err.Clear();
                    }
                    else
                    {
                        ID_err.SetError(button1, "error");
                    }
                }
                else
                {
                    ID_err.SetError(textBox1, "Already exist");
                }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if(textBox2.Text.Trim() == "")
            {
                label_err.SetError(textBox2, "Empty !");
            }
            else
            {
                label_err.Clear();
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if(decimal.ToInt32(numericUpDown1.Value) == 0)
            {
                period_err.SetError(numericUpDown1, "Not equal 0");
            }
            else
            {
                period_err.Clear();
            }
        }

        private void edit_btn_Click(object sender, EventArgs e)
        {
            if (CR.EditCourse(Convert.ToInt32(textBox1.Text), textBox2.Text, decimal.ToInt32(numericUpDown1.Value), textBox4.Text))
            {
                edit_err.Clear();
            }
            else
            {
                edit_err.SetError(button1, "error");
            }
        }

        private void del_btn_Click(object sender, EventArgs e)
        {
            if (CR.RemoveCourse(Convert.ToInt32(textBox1.Text)))
            {
                MessageBox.Show("Ok");
            }
            else
            {
                MessageBox.Show("error");   
            }
        }
    }
}
