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
    public partial class StaticsResult : Form
    {
        STUDENT st = new STUDENT();
        COURSE co = new COURSE();
        SCORE sc = new SCORE();

        public StaticsResult()
        {
            InitializeComponent();
        }

        private void StaticsResult_Load(object sender, EventArgs e)
        {
            GetInfoStaticByResult();
            GetInfoStaticByCourse();
        }

        private void GetInfoStaticByResult()
        {
            int pass = 0;
            int fail = 0;
            int sum = 0;
            DataTable a = st.getAllStudent();
            for (int i = 0; i < a.Rows.Count; i++)
            {
                int id = Convert.ToInt32(a.Rows[i][0].ToString().Trim());
                switch (PassOrFail(id))
                {
                    case 1: //pass
                        {
                            sum = sum + 1;
                            pass = pass + 1;
                            break;
                        }
                    case 0: //no result
                        {
                            sum = sum + 1;
                            break;
                        }
                    case -1: //fail
                        {
                            sum = sum + 1;
                            fail = fail + 1;
                            break;
                        }
                }
            }
            double passper = ((double)pass / (double)sum) * 100.0;
            double failper = ((double)fail / (double)sum) * 100.0;
            passper_lb.Text = passper.ToString() + "%";
            failper_lb.Text = failper.ToString() + "%";
            total_lb.Text = sum.ToString() + " Students";
        }
        private int PassOrFail(int id)
        {
            DataTable main =  sc.getScoreInfoStu(id);
            if(main.Rows.Count != 0)
            {
                int col = main.Columns.Count;
                if (main.Rows[0][col - 1].ToString().Trim() == "PASS")
                {
                    return 1; //pass
                }
                else
                {
                    return -1; //fail
                }
            }
            else
            {
                return 0; //no result
            }
        }


        private void GetInfoStaticByCourse()
        {
            DataTable a = co.getAllCourse();
            if(a.Rows.Count != 0)
            {
                DataTable AVGCourse = sc.AvgScoreByCourse();
                for(int i=0; i< AVGCourse.Rows.Count; i++)
                {
                    CourseChart.Series["AVG Score"].Points.AddXY(AVGCourse.Rows[i][1].ToString().Trim(), AVGCourse.Rows[i][2].ToString().Trim());
                }
            }

        }
    }
}
