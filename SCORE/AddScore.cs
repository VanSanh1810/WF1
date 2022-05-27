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
    public partial class AddScore : Form
    {
        SCORE sc = new SCORE();
        COURSE co = new COURSE();
        STUDENT st = new STUDENT();
        public AddScore()
        {
            InitializeComponent();
        }

        private void AddScore_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLSVDBDataSet13.Course' table. You can move, or remove it, as needed.
            this.courseTableAdapter2.Fill(this.qLSVDBDataSet13.Course);
            // TODO: This line of code loads data into the 'qLSVDBDataSet3.Course' table. You can move, or remove it, as needed.
            comboBox1.SelectedIndex = 0;
            DataRowView dataRow = (DataRowView)comboBox1.SelectedItem;
            dataGridView1.DataSource = co.getStuWithCourse(Convert.ToInt32(dataRow.Row.ItemArray[0].ToString().Trim()));
            del_btn.Enabled = false;
            del_btn.Visible = false;
            edit_btn.Enabled = false;
            edit_btn.Visible = false;
            add_btn.Enabled = true;
            add_btn.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataRowView dataRow = (DataRowView)comboBox1.SelectedItem;
            //MessageBox.Show(dataRow.Row.ItemArray[0].ToString());
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            if (stuID_tbx.Text == "")
            {
                err_IDstu.SetError(stuID_tbx, "Empty !");
            }
            else
            {
                err_IDstu.Clear();
                if (!st.checkStu(Convert.ToInt32(stuID_tbx.Text.Trim())))
                {
                    err_IDstu.SetError(stuID_tbx, "Exits!");
                }
                else
                {
                    if (score_tbx.Text == "")
                    {
                        err_score.SetError(stuID_tbx, "Empty !");
                    }
                    else
                    {
                        DataRowView dataRow = (DataRowView)comboBox1.SelectedItem;
                        err_IDstu.Clear();
                        if (sc.studentScoreExits(Convert.ToInt32(stuID_tbx.Text), Convert.ToInt32(dataRow.Row.ItemArray[0].ToString().Trim())))
                        {
                            MessageBox.Show("Student score already exits");
                        }
                        else
                        {
                            sc.insertScore(Convert.ToInt32(stuID_tbx.Text.Trim()), Convert.ToInt32(dataRow.Row.ItemArray[0].ToString().Trim()), Convert.ToInt32(score_tbx.Text), desc__tbx.Text);
                        }
                    }
                }
            }
        }

        private void stuID_tbx_Leave(object sender, EventArgs e)
        {
            if(stuID_tbx.Text == "")
            {
                err_IDstu.SetError(stuID_tbx, "Empty !");
            }
            else
            {
                err_IDstu.Clear();
                if (!st.checkStu(Convert.ToInt32(stuID_tbx.Text.Trim())))
                {
                    err_IDstu.SetError(stuID_tbx, "Exits!");
                }
                else
                {
                    err_IDstu.Clear();
                    add_btn.Enabled = true;
                    add_btn.Visible = true;
                    del_btn.Enabled = false;
                    del_btn.Visible = false;
                    edit_btn.Enabled = false;
                    edit_btn.Visible = false;
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            score_tbx.Text = "";
            desc__tbx.Text = "";
            DataRowView dataRow = (DataRowView)comboBox1.SelectedItem;
            if(dataRow == null)
            {

            }
            else
            {
                dataGridView1.DataSource = co.getStuWithCourse(Convert.ToInt32(dataRow.Row.ItemArray[0].ToString().Trim()));
            }
        }

        private void score_tbx_Leave(object sender, EventArgs e)
        {
            if (score_tbx.Text == "")
            {
                err_score.SetError(score_tbx, "Empty !");
            }
            else
            {
                err_score.Clear();
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dataGridView1.CurrentRow.Cells.Count == 8)
            {
                stuID_tbx.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString().Trim();
                del_btn.Enabled = false;
                del_btn.Visible = false;
                edit_btn.Enabled = false;
                edit_btn.Visible = false;
                add_btn.Enabled = true;
                add_btn.Visible = true;

            }
            else
            {
                stuID_tbx.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString().Trim();
                score_tbx.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString().Trim();
                desc__tbx.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString().Trim();
                del_btn.Enabled = true;
                del_btn.Visible = true;
                edit_btn.Enabled = true;
                edit_btn.Visible = true;
                add_btn.Enabled = false;
                add_btn.Visible = false;
            }
        }

        private void refresh_btn_Click(object sender, EventArgs e)
        {
            DataRowView dataRow = (DataRowView)comboBox1.SelectedItem;
            dataGridView1.DataSource = co.getStuWithCourse(Convert.ToInt32(dataRow.Row.ItemArray[0].ToString().Trim()));
        }

        private void del_btn_Click(object sender, EventArgs e)
        {
            if (stuID_tbx.Text == "")
            {
                err_IDstu.SetError(stuID_tbx, "Empty !");
            }
            else
            {
                err_IDstu.Clear();
                if (!st.checkStu(Convert.ToInt32(stuID_tbx.Text.Trim())))
                {
                    err_IDstu.SetError(stuID_tbx, "Exits!");
                }
                else
                {
                    DataRowView dataRow = (DataRowView)comboBox1.SelectedItem;
                    sc.delScore(Convert.ToInt32(stuID_tbx.Text.Trim()), Convert.ToInt32(dataRow.Row.ItemArray[0].ToString().Trim()));
                }
            }
        }

        private void avgscore_btn_Click(object sender, EventArgs e)
        {
            AvgScoreByCourse a = new AvgScoreByCourse();
            a.Show(this);
        }

        private void btn_shstu_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = st.getAllStudent();
        }

        private void btn_shsco_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = sc.getAllScore();
        }
    }
}
