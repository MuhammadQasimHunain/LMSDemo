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
        public static string UpdateCourse = "UPDATE [flexiSchoolUser].[Course] SET [Name] = @Name,[Semester] = @Semester,[CreditUnits] = @CreditUnits  WHERE ID = @ID";
        public static string DeleteCourse = "DELETE [flexiSchoolUser].[Course] WHERE ID = @ID";
        public static string GetCourseByID= "SELECT [ID],[Name],[Semester],[CreditUnits] FROM [FlexiSchool].[flexiSchoolUser].[Course] WHERE ID = @ID";
        public static string InsertCourse = "INSERT INTO [flexiSchoolUser].[Course] ([Name],[Semester],[CreditUnits]) VALUES (@Name,@Semester,@CreditUnits)";


        #endregion

        #region Student Queries
        public static string GetAllStudent  = "SELECT [ID],[FirstName],[LastName],[Phone] FROM [FlexiSchool].[flexiSchoolUser].[Student]";
        public static string UpdateStudent  = "UPDATE [flexiSchoolUser].[Student] SET [FirstName] = @FirstName,[LastName] = @LastName,[Phone] = @Phone  WHERE ID = @ID";
        public static string DeleteStudent  = "DELETE [flexiSchoolUser].[Student] WHERE ID = @ID";
        public static string GetStudentByID = "SELECT [ID],[FirstName],[LastName],[Phone] FROM [FlexiSchool].[flexiSchoolUser].[Student] WHERE ID = @ID";
        public static string InsertStudent  = "INSERT INTO [flexiSchoolUser].[Student] ([FirstName],[LastName],[Phone] ) VALUES (@FirstName,@LastName,@Phone)";


        #endregion


        #region Lecture Room Queries
        public static string GetAllLectureRoom  = "SELECT [ID],[Name] FROM [FlexiSchool].[flexiSchoolUser].[LectureRoom]";
        public static string UpdateLectureRoom  = "UPDATE [flexiSchoolUser].[LectureRoom] SET [Name] = @Name WHERE ID = @ID";
        public static string DeleteLectureRoom  = "DELETE [flexiSchoolUser].[LectureRoom] WHERE ID = @ID";
        public static string GetLectureRoomByID = "SELECT [ID],[Name] FROM [FlexiSchool].[flexiSchoolUser].[LectureRoom] WHERE ID = @ID";
        public static string InsertLectureRoom  = "INSERT INTO [flexiSchoolUser].[LectureRoom] ([Name]) VALUES (@Name)";


        #endregion



        #region Lecture Resource Queries
        public static string GetAllLectureResource  = "SELECT [ID],[CourseID],[Resource],[Extension] FROM [FlexiSchool].[flexiSchoolUser].[LectureResource]";
        public static string UpdateLectureResource  = "UPDATE [flexiSchoolUser].[LectureResource] SET [CourseID] = @CourseID,[Resource] = @Resource,[Extension] = @Extension  WHERE ID = @ID";
        public static string DeleteLectureResource  = "DELETE [flexiSchoolUser].[LectureResource] WHERE ID = @ID";
        public static string GetLectureResourceByID = "SELECT [ID],[CourseID],[Resource],[Extension] FROM [FlexiSchool].[flexiSchoolUser].[LectureResource] WHERE ID = @ID";
        public static string InsertLectureResource  = "INSERT INTO [flexiSchoolUser].[LectureResource] ([CourseID],[Resource],[Extension]) VALUES (@CourseID,@Resource,@Extension)";


        #endregion



        #region Enrollments Queries
        public static string GetAllEnrollments = "SELECT [ID],[CourseID],[Resource],[Extension] FROM [FlexiSchool].[flexiSchoolUser].[LectureResource]";
        public static string UpdateEnrollment = "";
        public static string DeleteEnrollment = "";
        public static string GetEnrollmentByID = "";
        public static string InsertEnrollment = "";


        #endregion
    }
}
