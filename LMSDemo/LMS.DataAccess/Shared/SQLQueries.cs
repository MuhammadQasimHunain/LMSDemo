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
        public static string GetAllCourses = "SELECT [ID],[Name],[Semester],[CreditUnits] FROM [FlexiSchool].[flexiSchoolUser].[Course]";
        public static string UpdateCourse = "";
        public static string DeleteCourse = "";
        public static string GetCourseByID= "";
        public static string InsertCourse = "";


        #endregion

        #region Student Queries
        public static string GetAllStudent = "SELECT [ID],[FirstName],[LastName],[Phone] FROM [FlexiSchool].[flexiSchoolUser].[Student]";
        public static string UpdateStudent = "";
        public static string DeleteStudent = "";
        public static string GetStudentByID = "";
        public static string InsertStudent = "";


        #endregion


        #region Lecture Room Queries
        public static string GetAllLectureRoom = "SELECT [ID],[Name] FROM [FlexiSchool].[flexiSchoolUser].[LectureRoom]";
        public static string UpdateLectureRoom = "";
        public static string DeleteLectureRoom = "";
        public static string GetLectureRoomByID = "";
        public static string InsertLectureRoom = "";


        #endregion



        #region Lecture Resource Queries
        public static string GetAllLectureResource = "SELECT [ID],[CourseID],[Resource],[Extension] FROM [FlexiSchool].[flexiSchoolUser].[LectureResource]";
        public static string UpdateLectureResource = "";
        public static string DeleteLectureResource = "";
        public static string GetLectureResourceByID = "";
        public static string InsertLectureResource = "";


        #endregion
    }
}
