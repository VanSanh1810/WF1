using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class PrintSTUDENT : Form
    {
        STUDENT std = new STUDENT();
        public PrintSTUDENT()
        {
            InitializeComponent();
        }

        private void yes_btn_CheckedChanged(object sender, EventArgs e)
        {
            if(yes_btn.Checked == false)
            {
                dateTimePicker1.Enabled = false;
                dateTimePicker2.Enabled = false;
            }
            else
            {
                dateTimePicker1.Enabled = true;
                dateTimePicker2.Enabled = true;
            }
        }
        private void fillGrig(SqlCommand command)
        {
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = std.getStudent(command);
            dataGridView1.AllowUserToAddRows = false;
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            SqlCommand command;
            string query = "";
            if (yes_btn.Checked)
            {
                string date1 = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                string date2 = dateTimePicker2.Value.ToString("yyyy-MM-dd");
                if (male_btn.Checked)
                {
                    query = "SELECT * FROM std WHERE gender = 'Male' AND bdate BETWEEN '"+date1+"' AND '"+date2+"'";
                }
                else if (female_btn.Checked)
                {
                    query = "SELECT * FROM std WHERE gender = 'Female' AND bdate BETWEEN '" + date1 + "' AND '" + date2 + "'";
                }
                else
                {
                    query = "SELECT * FROM std WHERE bdate BETWEEN '" + date1 + "' AND '" + date2 + "'";
                }
            }
            else
            {
                if (male_btn.Checked)
                {
                    query = "SELECT * FROM std WHERE gender = 'Male'";
                }
                else if (female_btn.Checked)
                {
                    query = "SELECT * FROM std WHERE gender = 'Female'";
                }
                else
                {
                    query = "SELECT * FROM std";
                }
            }
            command = new SqlCommand(query);
            fillGrig(command);
        }

        private void savetxt_btn_Click(object sender, EventArgs e)
        {
            String path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\studentlist.txt";
            using(var writer = new StreamWriter(path))
            {
                if (!File.Exists(path))
                {
                    File.Create(path);
                }
                DateTime bdate;
                for(int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    for(int j = 0; j < dataGridView1.Columns.Count - 1; j++)
                    {
                        if (j == 3)
                        {
                            bdate = Convert.ToDateTime(dataGridView1.Rows[i].Cells[j].Value.ToString());
                            writer.Write("\t" + bdate.ToString("yyyy-MM-dd")+ "\t" + "|");
                        }else if (j == dataGridView1.Columns.Count - 2)
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

        private void print_btn_Click(object sender, EventArgs e)
        {
            PrintDialog printDlg = new PrintDialog();
            PrintDocument printDoc = new PrintDocument();
            printDoc.DocumentName = "Print Document";
            printDlg.Document = printDoc;
            printDlg.AllowSelection = true;
            printDlg.AllowSomePages = true;
            if(printDlg.ShowDialog() == DialogResult.OK)
            {
                printDoc.Print();
            }
        }
    }
}
