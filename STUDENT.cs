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
    class STUDENT
    {
        MY_DB mydb = new MY_DB();
        

        public bool checkStu(int id)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM std WHERE Id = @id ", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if(table.Rows.Count == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool insertStudent(int id, string fname, string lname, DateTime bdate, string gender, string phone, string address, MemoryStream pic)
        {
            SqlCommand command = new SqlCommand("INSERT INTO std(Id, fname, lname, bdate, gender, phone, address, pic) VALUES (@id,@fn,@ln,@bdt,@gdr,@phn,@adrs,@pic)",mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@fn", SqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@ln", SqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@bdt", SqlDbType.DateTime).Value = bdate;
            command.Parameters.Add("@gdr", SqlDbType.VarChar).Value = gender;
            command.Parameters.Add("@phn", SqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@adrs", SqlDbType.VarChar).Value = address;
            command.Parameters.Add("@pic", SqlDbType.Image).Value = pic.ToArray();
            mydb.openConnection();
            if(command.ExecuteNonQuery() == 1)
            {
                mydb.openConnection();
                return true;
            }
            else
            {
                mydb.openConnection();
                return false;
            }
        }
        public DataTable getStudent(SqlCommand command)
        {
            command.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public DataTable getAllStudent()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM std", mydb.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
    }
}
