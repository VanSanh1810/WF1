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
            Form1 form1 = new Form1();
            if(form1.ShowDialog() == DialogResult.OK)
            {
                LoadForm a = new LoadForm();
                if (a.ShowDialog() == DialogResult.OK)
                {
                    Application.Run(new MainForm());
                }
            }
            else
            {
                Application.Exit();
            }
        }
    }
}
