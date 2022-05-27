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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void addStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddStudentForm addStudentForm = new AddStudentForm();
            addStudentForm.Show(this);
        }

        private void studentListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentList studentList = new StudentList();
            studentList.Show(this);
        }

        private void staticToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Statics Stc = new Statics();
            Stc.Show(this);
        }

        private void editRemoveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateDeleteStudent a = new UpdateDeleteStudent();
            a.Show(this);
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintSTUDENT a = new PrintSTUDENT();
            a.Show(this);
        }

        private void addCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCourse a = new AddCourse();
            a.Show(this);
        }

        private void manageCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageCourse a = new ManageCourse();
            a.Show(this);
        }

        private void printToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PrintCOURSE a = new PrintCOURSE();
            a.Show(this);
        }

        private void addScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddScore a = new AddScore();
            a.Show(this);
        }

        private void avgScoreByCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AvgScoreByCourse a = new AvgScoreByCourse();
            a.Show(this);
        }

        private void printResultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintScore a = new PrintScore();
            a.Show(this);
        }

        private void aVGResultByScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AVGResultByByCourse a = new AVGResultByByCourse();
            a.Show(this);
        }

        private void staticsResultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StaticsResult a = new StaticsResult();
            a.Show(this);
        }

        private void manageStudentFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageStudentForm a = new ManageStudentForm();
            a.Show(this);
        }

        private void removeCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveCourse a = new RemoveCourse();
            a.Show(this);
        }

        private void removeCourseToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RemoveCourse a = new RemoveCourse();
            a.Show(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
        }
    }
}
