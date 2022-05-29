using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public static class GlobalsVars
    {
        

        // public get, and private set for strict access control
        public static string Global_HR_ID { get; private set; }
        public static string Global_ConTract_ID { get; private set; } = "0";
        public static int Global_FGPass_Type { get; private set; }
        public static string Global_UserNameFG_ID { get; private set; }

        // GlobalInt can be changed only via this method
        public static void Set_Global_HR_ID(string newInt)
        {
            Global_HR_ID = newInt;
        }

        public static void Set_Global_ConTract_ID(string newInt)
        {
            Global_ConTract_ID = newInt;
        }

        public static void Set_Global_UserNameFG_ID(string newInt)
        {
            Global_UserNameFG_ID = newInt;
        }
        public static void Set_Global_FGPass_Type(int newInt)
        {
            Global_FGPass_Type = newInt;
        }
    }
}
