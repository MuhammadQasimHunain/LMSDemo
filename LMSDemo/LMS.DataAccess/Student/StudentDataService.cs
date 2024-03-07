using LMS.DataAccess.Shared;
using LMS.Models.DataModels;
using LMS.Utils;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Application.Student
{
    public class StudentDataService : IStudentDataService
    {
        private string ConnectionString;
        public StudentDataService()
        {
            this.ConnectionString = Configuration.GetDBConfiguration();
        }
        public bool DeleteStudent(int id)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(this.ConnectionString))
                {
                    SqlCommand cmd = new SqlCommand(SQLQueries.DeleteStudent, con);
                    cmd.CommandType = CommandType.Text;

                    cmd.Parameters.AddWithValue("@ID", id);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public StudentDBModel GetStudent(int id)
        {
            try
            {
                StudentDBModel student = new StudentDBModel();
                using (SqlConnection con = new SqlConnection(this.ConnectionString))
                {
                    string sqlQuery = SQLQueries.GetStudentByID + id;
                    SqlCommand cmd = new SqlCommand(sqlQuery, con);

                    con.Open();
                    SqlDataReader rdr = cmd.ExecuteReader();

                    while (rdr.Read())
                    {
                        student.ID = Convert.ToInt32(rdr["ID"]);
                        student.FirstName = rdr["FirstName"].ToString();
                        student.LastName = rdr["LastName"].ToString();
                        student.Phone = rdr["Phone"].ToString();
                    }
                }
                return student;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public IEnumerable<StudentDBModel> GetStudents()
        {
            List<StudentDBModel> lstStudents = new List<StudentDBModel>();

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                SqlCommand cmd = new SqlCommand(SQLQueries.GetAllStudent, con);
                cmd.CommandType = CommandType.StoredProcedure;

                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    StudentDBModel student = new StudentDBModel();

                    student.ID = Convert.ToInt32(rdr["ID"]);
                    student.FirstName = rdr["FirstName"].ToString();
                    student.LastName = rdr["LastName"].ToString();
                    student.Phone = rdr["Phone"].ToString();

                    lstStudents.Add(student);
                }
                con.Close();
            }
            return lstStudents;
        }

        public bool InsertStudent(StudentDBModel student)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(this.ConnectionString))
                {
                    SqlCommand cmd = new SqlCommand(SQLQueries.InsertStudent, con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@FirstName", student.FirstName);
                    cmd.Parameters.AddWithValue("@LastName", student.LastName);
                    cmd.Parameters.AddWithValue("@Phone", student.Phone);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    return true;
                }

            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool UpdateStudent(StudentDBModel student)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(this.ConnectionString))
                {
                    SqlCommand cmd = new SqlCommand(SQLQueries.UpdateStudent, con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@FirstName", student.FirstName);
                    cmd.Parameters.AddWithValue("@LastName", student.LastName);
                    cmd.Parameters.AddWithValue("@Phone", student.Phone);
                    cmd.Parameters.AddWithValue("@ID", student.ID);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    return true;
                }

            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
