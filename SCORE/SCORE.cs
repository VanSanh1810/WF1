using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class SCORE
    {
        MY_DB mydb = new MY_DB();
        STUDENT st = new STUDENT();
        COURSE co = new COURSE();
        public DataTable getScoreInfoStu(int stu_id)
        {
            SqlCommand command = new SqlCommand("SELECT std.Id , std.fname , std.lname , std.bdate, std.gender, std.phone, std.address , Course.Id, Course.label , Score.student_score Score " +
                                                "FROM Score INNER JOIN std ON Score.student_id = std.Id " +
                                                            "INNER JOIN Course ON Score.course_id = Course.Id " +
                                                "WHERE std.Id = @id", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = stu_id;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            /////////////////////////////////////////////////////////////////////////////////////////////////////
            SqlCommand command2 = new SqlCommand("SELECT std.Id, AVG(Score.student_score) AVGScore  " +
                                                "FROM Score INNER JOIN std ON Score.student_id = std.Id " +
                                                            "INNER JOIN Course ON Score.course_id = Course.Id " +
                                                "WHERE std.Id = @id " +
                                                "GROUP BY std.Id", mydb.getConnection); //Lấy điểm trung bình
            command2.Parameters.Add("@id", SqlDbType.Int).Value = stu_id;
            SqlDataAdapter adapter2 = new SqlDataAdapter(command2);
            DataTable table2 = new DataTable();
            adapter2.Fill(table2);
            if(table2.Rows.Count != 0) //Check sinh viên có điểm trung bình hay k
            {
                string a = table2.Rows[0][1].ToString().Trim();
                double AVGScore = Convert.ToDouble(a);

                /////////////////////////////////////////////////////////////////////////////////////////////////////
                int coursecount = table.Rows.Count;
                DataTable maintable = new DataTable();
                maintable.Columns.Add("Student ID");
                maintable.Columns.Add("First Name");
                maintable.Columns.Add("Last Name");
                maintable.Columns.Add("BirthDay");
                maintable.Columns.Add("Gender");
                maintable.Columns.Add("Phone");
                maintable.Columns.Add("Address");
                for (int i = 0; i < coursecount; i++)
                {
                    maintable.Columns.Add(table.Rows[i][8].ToString().Trim());
                }
                maintable.Columns.Add("AVG Score");
                maintable.Columns.Add("Result");
                //////////////////////////////////////////////////////////////////////////////////////////////////////
                DataRow dataRow = maintable.NewRow();
                dataRow["Student ID"] = table.Rows[0][0].ToString().Trim();
                dataRow["First Name"] = table.Rows[0][1].ToString().Trim();
                dataRow["Last Name"] = table.Rows[0][2].ToString().Trim();
                dataRow["BirthDay"] = table.Rows[0][3].ToString().Trim();
                dataRow["Gender"] = table.Rows[0][4].ToString().Trim();
                dataRow["Phone"] = table.Rows[0][5].ToString().Trim();
                dataRow["Address"] = table.Rows[0][6].ToString().Trim();
                for (int i = 0; i < coursecount; i++)
                {
                    dataRow[table.Rows[i][8].ToString().Trim()] = table.Rows[i][9].ToString().Trim();
                }
                dataRow["AVG Score"] = AVGScore;
                if (AVGScore / coursecount >= 5)
                {
                    dataRow["Result"] = "PASS";
                }
                else
                {
                    dataRow["Result"] = "FAIL";
                }
                maintable.Rows.Add(dataRow);
                return maintable;
            }
            else{
                DataTable a = new DataTable();
                return a;
            }
        }

        public DataTable getAllScore()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Score", mydb.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public DataTable getScore(int state, int id)
        {
            DataTable table = new DataTable();
            switch (state)
            {
                case 1: //Group by student
                    {
                        SqlCommand command = new SqlCommand("SELECT std.Id, std.fname, std.lname, Score.student_score, Score.description FROM Score INNER JOIN std ON Score.student_id = std.Id WHERE Score.student_id = @id ", mydb.getConnection);
                        command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        adapter.Fill(table);
                        break;
                    }
                case 2: //Group by course
                    {
                        SqlCommand command = new SqlCommand("SELECT Course.Id, Course.label, Score.student_score, Score.description FROM Score INNER JOIN Course ON Course.Id = Score.course_id WHERE Score.course_id = @id", mydb.getConnection);
                        command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        adapter.Fill(table);
                        break;
                    }
            }
            return table;
        }
        public bool insertScore(int student_id, int course_id, float student_score, string description)
        {
            SqlCommand command = new SqlCommand("INSERT INTO Score(student_id, course_id, student_score, description) VALUES (@student_id, @course_id, @student_score, @description)", mydb.getConnection);
            command.Parameters.Add("@student_id", SqlDbType.Int).Value = student_id;
            command.Parameters.Add("@course_id", SqlDbType.Int).Value = course_id;
            command.Parameters.Add("@student_score", SqlDbType.Float).Value = student_score;
            command.Parameters.Add("@description", SqlDbType.VarChar).Value = description;
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
        public bool delScore(int student_id, int course_id)
        {
            SqlCommand command = new SqlCommand("DELETE FROM Score WHERE student_id = @student_id AND course_id = @course_id", mydb.getConnection);
            command.Parameters.Add("@student_id", SqlDbType.Int).Value = student_id;
            command.Parameters.Add("@course_id", SqlDbType.Int).Value = course_id;
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

        public bool studentScoreExits(int student_id, int course_id)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Score WHERE student_id = @student_id AND course_id = @course_id", mydb.getConnection);
            command.Parameters.Add("@student_id", SqlDbType.Int).Value = student_id;
            command.Parameters.Add("@course_id", SqlDbType.Int).Value = course_id;
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

        public DataTable AvgScoreByCourse()
        {
            SqlCommand command = new SqlCommand("SELECT Score.course_id ID, Course.label Course, AVG(student_score) AVGScore FROM Score INNER JOIN Course ON Score.course_id = Course.Id GROUP BY Score.course_id, Course.label ", mydb.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table; 
        }
    }
}
