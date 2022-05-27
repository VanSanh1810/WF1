using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
            TOP:
            Form1 form1 = new Form1();
            DialogResult tmp = new DialogResult();
            tmp = form1.ShowDialog();
            if (tmp == DialogResult.OK) //Open MainForm
            {
                LoadForm a = new LoadForm();
                if (a.ShowDialog() == DialogResult.OK)
                {
                    MainForm mainf = new MainForm();
                    if (mainf.ShowDialog() == DialogResult.Yes)
                    {
                        goto TOP;
                    }
                }
            }
            else
            {
                if (tmp == DialogResult.Yes) //Open HR
                {
                    LoadForm a = new LoadForm();
                    if (a.ShowDialog() == DialogResult.OK)
                    {
                        HRForm hr = new HRForm(GlobalsVars.Global_HR_ID);
                        if (hr.ShowDialog() == DialogResult.Yes)
                        {
                            goto TOP;
                        }
                    }
                }
                else
                {
                    Application.Exit();
                }
                
            }
        }
    }
}
