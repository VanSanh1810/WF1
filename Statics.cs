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
    public partial class Statics : Form
    {
        STUDENT std = new STUDENT();
        public Statics()
        {
            InitializeComponent();
        }

        private void Statics_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM std");
            DataTable tb = new DataTable();
            tb = std.getStudent(command);
            int total = tb.Rows.Count;
            SqlCommand command1 = new SqlCommand("SELECT * FROM std WHERE gender = 'Male' ");
            SqlCommand command2 = new SqlCommand("SELECT * FROM std WHERE gender = 'Female' ");
            tb.Clear();
            tb = std.getStudent(command1);
            int Male = tb.Rows.Count;
            tb.Clear();
            tb = std.getStudent(command2);
            int FeMale = tb.Rows.Count;
            total_lb.Text = total.ToString();
            male_lb.Text = Male.ToString();
            female_lb.Text = FeMale.ToString();
        }
    }
}
