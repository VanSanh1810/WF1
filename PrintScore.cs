using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class PrintScore : Form
    {
        SCORE sc = new SCORE();
        public PrintScore()
        {
            InitializeComponent();
            dataGridView1.DataSource = sc.getAllScore();
        }

        private void print_btn_Click(object sender, EventArgs e)
        {
            PrintDialog printDlg = new PrintDialog();
            PrintDocument printDoc = new PrintDocument();
            printDoc.DocumentName = "Print Document";
            printDlg.Document = printDoc;
            printDlg.AllowSelection = true;
            printDlg.AllowSomePages = true;
            if (printDlg.ShowDialog() == DialogResult.OK)
            {
                printDoc.Print();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\scorelist.txt";
            using (var writer = new StreamWriter(path))
            {
                if (!File.Exists(path))
                {
                    File.Create(path);
                }
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count - 1; j++)
                    {
                        if (j == dataGridView1.Columns.Count - 2)
                        {
                            writer.Write("\t" + dataGridView1.Rows[i].Cells[j].Value.ToString());
                        }
                        else
                        {
                            writer.Write("\t" + dataGridView1.Rows[i].Cells[j].Value.ToString() + "\t" + "|");
                        }
                    }
                    writer.WriteLine("");
                    writer.WriteLine("----------------------------------------------------------------------------------------------------------");
                }
            }
        }

        private void PrintScore_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLSVDBDataSet6.Course' table. You can move, or remove it, as needed.
            this.courseTableAdapter1.Fill(this.qLSVDBDataSet6.Course);
            // TODO: This line of code loads data into the 'qLSVDBDataSet5.Course' table. You can move, or remove it, as needed.
            this.courseTableAdapter.Fill(this.qLSVDBDataSet5.Course);
            // TODO: This line of code loads data into the 'qLSVDBDataSet4.std' table. You can move, or remove it, as needed.
            this.stdTableAdapter.Fill(this.qLSVDBDataSet4.std);
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            comboBox1.Enabled = false;
        }

        private void raStu_btn_CheckedChanged(object sender, EventArgs e)
        {
            if (raStu_btn.Checked)
            {
                comboBox2.Enabled = true;
                comboBox1.Enabled = false;
                DataRowView dataRow = (DataRowView)comboBox2.SelectedItem;
                //MessageBox.Show(dataRow.Row.ItemArray[0].ToString());
                if (dataRow != null)
                {
                    dataGridView1.DataSource = sc.getScore(1, Convert.ToInt32(dataRow.Row.ItemArray[0].ToString()));
                }
            }
            else
            {
                comboBox1.Enabled = true;
                comboBox2.Enabled = false;
                DataRowView dataRow = (DataRowView)comboBox1.SelectedItem;
                //MessageBox.Show(dataRow.Row.ItemArray[0].ToString());
                if (dataRow != null)
                {
                    dataGridView1.DataSource = sc.getScore(2, Convert.ToInt32(dataRow.Row.ItemArray[0].ToString()));
                }
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e) //Student
        {
            DataRowView dataRow = (DataRowView)comboBox2.SelectedItem;
            //MessageBox.Show(dataRow.Row.ItemArray[0].ToString());
            if(dataRow != null)
            {
                dataGridView1.DataSource = sc.getScore(1, Convert.ToInt32(dataRow.Row.ItemArray[0].ToString()));
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) //Course
        {
            DataRowView dataRow = (DataRowView)comboBox1.SelectedItem;
            //MessageBox.Show(dataRow.Row.ItemArray[0].ToString());
            if(dataRow != null)
            {
                dataGridView1.DataSource = sc.getScore(2, Convert.ToInt32(dataRow.Row.ItemArray[0].ToString()));
            }
        }

        private void refresh_btn_Click(object sender, EventArgs e)
        {
            if (raStu_btn.Checked)
            {
                DataRowView dataRow = (DataRowView)comboBox2.SelectedItem;
                //MessageBox.Show(dataRow.Row.ItemArray[0].ToString());
                dataGridView1.DataSource = sc.getScore(1, Convert.ToInt32(dataRow.Row.ItemArray[0].ToString()));
            }
            else
            {
                DataRowView dataRow = (DataRowView)comboBox1.SelectedItem;
                //MessageBox.Show(dataRow.Row.ItemArray[0].ToString());
                dataGridView1.DataSource = sc.getScore(2, Convert.ToInt32(dataRow.Row.ItemArray[0].ToString()));
            }
        }
    }
}
