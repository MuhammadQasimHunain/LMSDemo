using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.DataAccess.Shared
{
    public static class SQLQueries
    {
        #region Course Queries
        public static string GetAllCourses = "";
        public static string UpdateCourse = "";
        public static string DeleteCourse = "";
        public static string GetCourseByID= "";
        public static string InsertCourse = "";


        #endregion

        #region Student Queries
        public static string GetAllStudent = "";
        public static string UpdateStudent = "";
        public static string DeleteStudent = "";
        public static string GetStudentByID = "";
        public static string InsertStudent = "";


        #endregion


        #region Lecture Room Queries
        public static string GetAllLectureRoom = "";
        public static string UpdateLectureRoom = "";
        public static string DeleteLectureRoom = "";
        public static string GetLectureRoomByID = "";
        public static string InsertLectureRoom = "";


        #endregion



        #region Lecture Resource Queries
        public static string GetAllLectureResource = "";
        public static string UpdateLectureResource = "";
        public static string DeleteLectureResource = "";
        public static string GetLectureResourceByID = "";
        public static string InsertLectureResource = "";


        #endregion
    }
}
