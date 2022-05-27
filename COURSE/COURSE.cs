using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class COURSE
    {
        MY_DB mydb = new MY_DB();

        public DataTable getStuWithCourse(int courseid)
        {
            SqlCommand command = new SqlCommand("SELECT std.Id, std.fname, std.lname, Score.student_score, Score.description " +
                "                                   FROM std INNER JOIN Score " +
                "                                       ON std.Id = Score.student_id INNER JOIN Course" +
                "                                       ON Score.course_id = Course.Id  " +
                "                                   WHERE Course.Id = @id ", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = courseid;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public DataTable getCourse(SqlCommand command)
        {
            command.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public DataTable getAllCourse()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Course", mydb.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public DataTable getCourseID(int id)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Course WHERE Id = @id", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public bool AddCourse(int id, string label, int period, string decrip)
        {
            SqlCommand command = new SqlCommand("INSERT INTO Course(Id, label, period, description) VALUES (@id, @label, @period, @decrip)", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@label", SqlDbType.NVarChar).Value = label;
            command.Parameters.Add("@period", SqlDbType.Int).Value = period;
            command.Parameters.Add("@decrip", SqlDbType.Text).Value = decrip;
            mydb.openConnection();
            if (command.ExecuteNonQuery() == 1)
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

        public bool EditCourse(int id, string label, int period, string decrip)
        {
            SqlCommand command = new SqlCommand("UPDATE Course SET Id = @id, label = @label, period = @period, description = @decrip WHERE Id = @id", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@label", SqlDbType.NVarChar).Value = label;
            command.Parameters.Add("@period", SqlDbType.Int).Value = period;
            command.Parameters.Add("@decrip", SqlDbType.Text).Value = decrip;
            mydb.openConnection();
            if (command.ExecuteNonQuery() == 1)
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

        public bool RemoveCourse(int id)
        {
            SqlCommand command = new SqlCommand("DELETE FROM Course WHERE Id = @id", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            mydb.openConnection();
            if (command.ExecuteNonQuery() == 1)
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

        public bool CheckIDCourse(int id)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Course WHERE Id = @id",mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if(table.Rows.Count > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
