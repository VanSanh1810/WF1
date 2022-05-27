using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class HR
    {
        MY_DB dB = new MY_DB();

        public MemoryStream GetPic(string ID)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM User_HR WHERE id = @id", dB.getConnection);
            command.Parameters.Add("@id", SqlDbType.VarChar).Value = ID;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            byte[] tmp;
            tmp = (byte[])table.Rows[0][5];
            MemoryStream picCol = new MemoryStream(tmp);
            return picCol;
        }

        public string GetInfo(int type, string ID)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM User_HR WHERE id = @id", dB.getConnection);
            command.Parameters.Add("@id", SqlDbType.VarChar).Value = ID;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            string tmp;
            switch (type)
            {
                case 1: //fname
                    {
                        tmp = table.Rows[0][1].ToString().Trim();
                        return tmp;
                    }
                case 2: //lname
                    {
                        tmp = table.Rows[0][2].ToString().Trim();
                        return tmp;
                    }
                case 3: //user
                    {
                        tmp = table.Rows[0][3].ToString().Trim();
                        return tmp;
                    }
                case 4: //pass
                    {
                        tmp = table.Rows[0][4].ToString().Trim();
                        return tmp;
                    }
            }
            return "-1";
        }
        public bool RegisterHR(string ID, string fname, string lname, string username, string pass, MemoryStream pic)
        {
            SqlCommand command = new SqlCommand("INSERT INTO User_HR(id, fname, lname, uname, pass, pic) VALUES (@id,@fn,@ln,@user,@pass,@pic)", dB.getConnection);
            command.Parameters.Add("@id", SqlDbType.VarChar).Value = ID;
            command.Parameters.Add("@fn", SqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@ln", SqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@user", SqlDbType.VarChar).Value = username;
            command.Parameters.Add("@pass", SqlDbType.VarChar).Value = pass;
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

        public bool EDITRegisterHR(string ID, string fname, string lname, string username, string pass, MemoryStream pic)
        {
            SqlCommand command = new SqlCommand("UPDATE User_HR SET fname = @fname, lname = @lname, uname = @uname, pass = @pass , pic = @pic WHERE id = @id", dB.getConnection);
            command.Parameters.Add("@id", SqlDbType.VarChar).Value = ID;
            command.Parameters.Add("@fname", SqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@lname", SqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@uname", SqlDbType.VarChar).Value = username;
            command.Parameters.Add("@pass", SqlDbType.VarChar).Value = pass;
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

        public bool CheckHRLogin(string username, string pass)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM User_HR WHERE uname = @user AND pass = @pass ", dB.getConnection);
            command.Parameters.Add("@user", SqlDbType.VarChar).Value = username;
            command.Parameters.Add("@pass", SqlDbType.VarChar).Value = pass;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if(table.Rows.Count != 0)
            {
                return true;
            }
            return false;
        }

        public bool CheckSameUsername(string username)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM User_HR WHERE uname = @user", dB.getConnection);
            command.Parameters.Add("@user", SqlDbType.VarChar).Value = username;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if (table.Rows.Count > 1)
            {
                return true;
            }
            return false;
        }
        public string GetID(string username, string pass)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM User_HR WHERE uname = @user AND pass = @pass ", dB.getConnection);
            command.Parameters.Add("@user", SqlDbType.VarChar).Value = username;
            command.Parameters.Add("@pass", SqlDbType.VarChar).Value = pass;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table.Rows[0][0].ToString().Trim();
        }
    }
}
