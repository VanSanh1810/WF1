using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class CONTACT
    {
        MY_DB dB = new MY_DB();
        public MemoryStream GetPic (string ID)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM contact WHERE id = @id AND user_id = @user", dB.getConnection);
            command.Parameters.Add("@id", SqlDbType.VarChar).Value = ID;
            command.Parameters.Add("@user", SqlDbType.VarChar).Value = GlobalsVars.Global_HR_ID;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            byte[] pic;
            pic = (byte[])table.Rows[0][7];
            MemoryStream picCol = new MemoryStream(pic);
            return picCol;
        }

        public string GetInFo(int state, string ID)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM contact WHERE id = @id AND user_id = @user", dB.getConnection);
            command.Parameters.Add("@id", SqlDbType.VarChar).Value = ID;
            command.Parameters.Add("@user", SqlDbType.VarChar).Value = GlobalsVars.Global_HR_ID;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table.Rows[0][state].ToString().Trim();
        }

        public bool EditContact(string ID, string fname, string lname, string group_id, string phone, string email, string address, MemoryStream pic)
        {
            SqlCommand command = new SqlCommand("UPDATE contact SET fname = @fname, lname = @lname, group_id = @group, phone = @phone, email = @email, address = @address, pic = @pic WHERE id = @id AND user_id = @user", dB.getConnection);
            command.Parameters.Add("@id", SqlDbType.VarChar).Value = ID;
            command.Parameters.Add("@user", SqlDbType.VarChar).Value = GlobalsVars.Global_HR_ID;

            command.Parameters.Add("@fname", SqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@lname", SqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@group", SqlDbType.VarChar).Value = group_id;
            command.Parameters.Add("@phone", SqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@email", SqlDbType.VarChar).Value = email;
            command.Parameters.Add("@address", SqlDbType.VarChar).Value = address;
            command.Parameters.Add("@pic", SqlDbType.Image).Value = pic.ToArray();
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

        public bool DelContract(string ID)
        {
            SqlCommand command = new SqlCommand("DELETE FROM contact WHERE id = @id AND user_id = @user", dB.getConnection);
            command.Parameters.Add("@id", SqlDbType.VarChar).Value = ID;
            command.Parameters.Add("@user", SqlDbType.VarChar).Value = GlobalsVars.Global_HR_ID;
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

        public bool AddContact( string fname, string lname, string group_id, string phone, string email, string address, MemoryStream pic)
        {
            SqlCommand command = new SqlCommand("INSERT INTO contact(id, fname, lname, group_id, phone, email, address, pic, user_id) VALUES (@id, @fname, @lname, @group_id, @phone, @email, @address, @pic, @user_id)", dB.getConnection);
            command.Parameters.Add("@id", SqlDbType.VarChar).Value = "CONT" + DateTime.Now.Month.ToString()
                                                                            + DateTime.Now.Day.ToString()
                                                                            + DateTime.Now.Hour.ToString()
                                                                            + DateTime.Now.Minute.ToString()
                                                                            + DateTime.Now.Second.ToString();
            command.Parameters.Add("@user_id", SqlDbType.VarChar).Value = GlobalsVars.Global_HR_ID;

            command.Parameters.Add("@fname", SqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@lname", SqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@group_id", SqlDbType.VarChar).Value = group_id;
            command.Parameters.Add("@phone", SqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@email", SqlDbType.VarChar).Value = email;
            command.Parameters.Add("@address", SqlDbType.VarChar).Value = address;
            command.Parameters.Add("@pic", SqlDbType.Image).Value = pic.ToArray();
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

        public DataTable GetContactWithGroup(string Group_id)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM contact WHERE group_id = @g_id ", dB.getConnection);
            command.Parameters.Add("@g_id", SqlDbType.VarChar).Value = Group_id;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public DataTable GetContact(SqlCommand command)
        {
            command.Connection = dB.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
    }
}
