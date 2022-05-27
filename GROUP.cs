using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class GROUP
    {
        MY_DB dB = new MY_DB();
        public bool AddGroup(string Group_name)
        {
            SqlCommand command = new SqlCommand("INSERT INTO myGroup(id, Gr_name) VALUES (@id, @grname)", dB.getConnection);
            command.Parameters.Add("@id", SqlDbType.NChar).Value = "GR" + DateTime.Now.Month.ToString()
                                                                        + DateTime.Now.Day.ToString()
                                                                        + DateTime.Now.Hour.ToString()
                                                                        + DateTime.Now.Minute.ToString()
                                                                        + DateTime.Now.Second.ToString();
            command.Parameters.Add("@grname", SqlDbType.NChar).Value = Group_name;
            dB.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                dB.openConnection();
                return true;
            }
            else
            {
                dB.openConnection();
                return false;
            }
        }

        public bool EditGroup(string ID, string Group_name)
        {
            SqlCommand command = new SqlCommand("UPDATE myGroup SET Gr_name = @grname WHERE id = @id", dB.getConnection);
            command.Parameters.Add("@id", SqlDbType.NChar).Value = ID;
            command.Parameters.Add("@grname", SqlDbType.NChar).Value = Group_name;
            dB.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                dB.openConnection();
                return true;
            }
            else
            {
                dB.openConnection();
                return false;
            }
        }

        public bool DelGroup(string ID)
        {
            SqlCommand command = new SqlCommand("DELETE FROM myGroup WHERE id = @id", dB.getConnection);
            command.Parameters.Add("@id", SqlDbType.NChar).Value = ID;
            dB.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                dB.openConnection();
                return true;
            }
            else
            {
                dB.openConnection();
                return false;
            }
        }
    }
}
