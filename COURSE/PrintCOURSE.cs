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
    public partial class PrintCOURSE : Form
    {
        COURSE cr = new COURSE();
        MY_DB db = new MY_DB();
        public PrintCOURSE()
        {
            InitializeComponent();
        }

        private void filter_tbx_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&(e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void filter_tbx_Leave(object sender, EventArgs e)
        {
            if(filter_tbx.Text.Trim() == "")
            {
                errorProvider1.SetError(filter_tbx, "Empty!");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (filter_tbx.Text.Trim() == "")
            {
                errorProvider1.SetError(filter_tbx, "Empty!");
            }
            else
            {
                SqlCommand command = new SqlCommand("SELECT * FROM Course WHERE Id = @id", db.getConnection);
                command.Parameters.Add("@id", SqlDbType.Int).Value = Convert.ToInt32(filter_tbx.Text);
                dataGridView1.DataSource = cr.getCourse(command);
                errorProvider1.Clear();
            }
        }

        private void savetxt_btn_Click(object sender, EventArgs e)
        {
            String path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\course.txt";
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
    }
}
