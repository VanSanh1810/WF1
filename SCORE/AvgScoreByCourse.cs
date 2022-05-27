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
    public partial class AvgScoreByCourse : Form
    {
        SCORE sc = new SCORE();
        public AvgScoreByCourse()
        {
            InitializeComponent();
            dataGridView1.DataSource =  sc.AvgScoreByCourse();
        }
    }
}
