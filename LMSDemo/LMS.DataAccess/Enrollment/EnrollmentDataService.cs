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

namespace LMS.DataAccess.Enrollment
{
    public class EnrollmentDataService : IEnrollmentDataService
    {
        private string ConnectionString;
        public EnrollmentDataService()
        {
            this.ConnectionString = Configuration.GetDBConfiguration();
        }

        public bool DeleteEnrollment(int id)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(this.ConnectionString))
                {
                    SqlCommand cmd = new SqlCommand(SQLQueries.DeleteEnrollment, con);
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

        public EnrollmentDBModel GetEnrollment(int id)
        {
            try
            {
                EnrollmentDBModel enrollment = new EnrollmentDBModel();
                using (SqlConnection con = new SqlConnection(this.ConnectionString))
                {
                    string sqlQuery = SQLQueries.GetEnrollmentByID.Replace("@ID", id.ToString());
                    SqlCommand cmd = new SqlCommand(sqlQuery, con);
                    cmd.CommandType = CommandType.Text;

                    con.Open();
                    SqlDataReader rdr = cmd.ExecuteReader();

                    while (rdr.Read())
                    {

                        enrollment.ID = Convert.ToInt32(rdr["ID"]);
                        enrollment.StudentID = Convert.ToInt32(rdr["StudentID"]);
                        enrollment.CourseID = Convert.ToInt32(rdr["CourseID"].ToString());
                        enrollment.GradeID = Convert.ToInt32(rdr["GradeID"].ToString());
                    }
                }
                return enrollment;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public IEnumerable<EnrollmentDBModel> GetEnrollmentByCources(int id)
        {
            List<EnrollmentDBModel> lstEnrollmenets = new List<EnrollmentDBModel>();

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                SqlCommand cmd = new SqlCommand(SQLQueries.GetEnrollmentByCourse.Replace("@ID",id.ToString()), con);
                cmd.CommandType = CommandType.Text;

                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    EnrollmentDBModel enrollment = new EnrollmentDBModel();

                    enrollment.ID = Convert.ToInt32(rdr["ID"]);
                    enrollment.StudentID = Convert.ToInt32(rdr["StudentID"]);
                    enrollment.CourseID = Convert.ToInt32(rdr["CourseID"].ToString());
                    enrollment.GradeID = Convert.ToInt32(rdr["GradeID"].ToString());

                    lstEnrollmenets.Add(enrollment);
                }
                con.Close();
            }
            return lstEnrollmenets;
        }

        public IEnumerable<EnrollmentDBModel> GetEnrollmentByStudent(int id)
        {
            List<EnrollmentDBModel> lstEnrollmenets = new List<EnrollmentDBModel>();

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                SqlCommand cmd = new SqlCommand(SQLQueries.GetEnrollmentByStudent.Replace("@ID", id.ToString()), con);
                cmd.CommandType = CommandType.Text;

                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    EnrollmentDBModel enrollment = new EnrollmentDBModel();

                    enrollment.ID = Convert.ToInt32(rdr["ID"]);
                    enrollment.StudentID = Convert.ToInt32(rdr["StudentID"]);
                    enrollment.CourseID = Convert.ToInt32(rdr["CourseID"].ToString());
                    enrollment.GradeID = Convert.ToInt32(rdr["GradeID"].ToString());

                    lstEnrollmenets.Add(enrollment);
                }
                con.Close();
            }
            return lstEnrollmenets;
        }

        public IEnumerable<EnrollmentDBModel> GetEnrollments()
        {
            List<EnrollmentDBModel> lstEnrollmenets = new List<EnrollmentDBModel>();

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                SqlCommand cmd = new SqlCommand(SQLQueries.GetAllEnrollments, con);
                cmd.CommandType = CommandType.Text;

                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    EnrollmentDBModel enrollment = new EnrollmentDBModel();

                    enrollment.ID = Convert.ToInt32(rdr["ID"]);
                    enrollment.StudentID = Convert.ToInt32(rdr["StudentID"]);
                    enrollment.CourseID = Convert.ToInt32(rdr["CourseID"].ToString());
                    enrollment.GradeID = Convert.ToInt32(rdr["GradeID"].ToString());

                    lstEnrollmenets.Add(enrollment);
                }
                con.Close();
            }
            return lstEnrollmenets;
        }

        public bool InsertEnrollment(EnrollmentDBModel enrollment)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(this.ConnectionString))
                {
                    SqlCommand cmd = new SqlCommand(SQLQueries.InsertEnrollment, con);
                    cmd.CommandType = CommandType.Text;

                    cmd.Parameters.AddWithValue("@StudentID", enrollment.StudentID);
                    cmd.Parameters.AddWithValue("@CourseID", enrollment.CourseID);
                    cmd.Parameters.AddWithValue("@GradeID", enrollment.GradeID);

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

        public bool UpdateEnrollment(EnrollmentDBModel enrollment)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(this.ConnectionString))
                {
                    SqlCommand cmd = new SqlCommand(SQLQueries.UpdateEnrollment, con);
                    cmd.CommandType = CommandType.Text;

                    cmd.Parameters.AddWithValue("@StudentID", enrollment.StudentID);
                    cmd.Parameters.AddWithValue("@CourseID", enrollment.CourseID);
                    cmd.Parameters.AddWithValue("@GradeID", enrollment.GradeID);
                    cmd.Parameters.AddWithValue("@ID", enrollment.ID);

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
