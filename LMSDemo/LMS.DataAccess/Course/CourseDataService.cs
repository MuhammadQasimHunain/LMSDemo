using LMS.Models.DataModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LMS.Utils;
using LMS.DataAccess.Shared;

namespace LMS.Application.Course
{
    public class CourseDataService : ICourseDataService
    {
        private string ConnectionString;
        public CourseDataService()
        {
            this.ConnectionString = Configuration.GetDBConfiguration();
        }
        public bool DeleteCourse(int id)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(this.ConnectionString))
                {   
                    SqlCommand cmd = new SqlCommand(SQLQueries.DeleteCourse, con);
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

        public CourseDBModel GetCourse(int id)
        {
            try
            {
                CourseDBModel course = new CourseDBModel();
                using (SqlConnection con = new SqlConnection(this.ConnectionString))
                {
                    string sqlQuery = SQLQueries.GetCourseByID + id;
                    SqlCommand cmd = new SqlCommand(sqlQuery, con);

                    con.Open();
                    SqlDataReader rdr = cmd.ExecuteReader();

                    while (rdr.Read())
                    {

                        course.ID = Convert.ToInt32(rdr["EmployeeID"]);
                        course.Name = rdr["Name"].ToString();
                        course.CreditUnits = Convert.ToInt32(rdr["CreditUnits"].ToString());
                        course.Semester = Convert.ToInt32(rdr["Semester"].ToString());
                    }
                }
                return course;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public IEnumerable<CourseDBModel> GetCourses()
        {
            List<CourseDBModel> lstcourse = new List<CourseDBModel>();

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                SqlCommand cmd = new SqlCommand(SQLQueries.GetAllCourses, con);
                cmd.CommandType = CommandType.StoredProcedure;

                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    CourseDBModel course = new CourseDBModel();

                    course.ID = Convert.ToInt32(rdr["EmployeeID"]);
                    course.Name = rdr["Name"].ToString();
                    course.CreditUnits = Convert.ToInt32(rdr["CreditUnits"].ToString());
                    course.Semester = Convert.ToInt32(rdr["Semester"].ToString());

                    lstcourse.Add(course);
                }
                con.Close();
            }
            return lstcourse;
        }

        public bool InsertLectureResource(CourseDBModel course)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(this.ConnectionString))
                {
                    SqlCommand cmd = new SqlCommand(SQLQueries.InsertCourse, con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Name", course.Name);
                    cmd.Parameters.AddWithValue("@Semester", course.Semester);
                    cmd.Parameters.AddWithValue("@CreditUnits", course.CreditUnits);

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

        public bool UpdateCourse(CourseDBModel course)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(this.ConnectionString))
                {
                    SqlCommand cmd = new SqlCommand(SQLQueries.UpdateCourse, con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Name", course.Name);
                    cmd.Parameters.AddWithValue("@Semester", course.Semester);
                    cmd.Parameters.AddWithValue("@CreditUnits", course.CreditUnits);
                    cmd.Parameters.AddWithValue("@ID", course.ID);

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
