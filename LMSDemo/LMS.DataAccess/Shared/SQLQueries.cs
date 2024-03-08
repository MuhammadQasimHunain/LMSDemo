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
        public static string GetAllLectureRoom  = "SELECT [ID],[Name],[Capaicty] FROM [FlexiSchool].[flexiSchoolUser].[LectureRoom]";
        public static string UpdateLectureRoom  = "UPDATE [flexiSchoolUser].[LectureRoom] SET [Name],[Capaicty] = @Name WHERE ID = @ID";
        public static string DeleteLectureRoom  = "DELETE [flexiSchoolUser].[LectureRoom] WHERE ID = @ID";
        public static string GetLectureRoomByID = "SELECT [ID],[Name],[Capaicty] FROM [FlexiSchool].[flexiSchoolUser].[LectureRoom] WHERE ID = @ID";
        public static string InsertLectureRoom  = "INSERT INTO [flexiSchoolUser].[LectureRoom] ([Name],[Capaicty]) VALUES (@Name,@Capaicty)";


        #endregion



        #region Lecture Resource Queries
        public static string GetAllLectureResource  = "SELECT [ID],[CourseID],[Resource],[Extension] FROM [FlexiSchool].[flexiSchoolUser].[LectureResource]";
        public static string UpdateLectureResource  = "UPDATE [flexiSchoolUser].[LectureResource] SET [CourseID] = @CourseID,[Resource] = @Resource,[Extension] = @Extension  WHERE ID = @ID";
        public static string DeleteLectureResource  = "DELETE [flexiSchoolUser].[LectureResource] WHERE ID = @ID";
        public static string GetLectureResourceByID = "SELECT [ID],[CourseID],[Resource],[Extension] FROM [FlexiSchool].[flexiSchoolUser].[LectureResource] WHERE ID = @ID";
        public static string InsertLectureResource  = "INSERT INTO [flexiSchoolUser].[LectureResource] ([CourseID],[Resource],[Extension]) VALUES (@CourseID,@Resource,@Extension)";


        #endregion



        #region Enrollments Queries
        public static string GetAllEnrollments = "SELECT [StudentID],[CourseID],[GradeID],[ID],[LectureRoomID] FROM [FlexiSchool].[flexiSchoolUser].[Enrollment]";
        public static string UpdateEnrollment = "UPDATE [flexiSchoolUser].[Enrollment] SET [CourseID] = @CourseID,[StudentID] = @StudentID,[GradeID] = @GradeID WHERE ID = @ID";
        public static string DeleteEnrollment = "DELETE [flexiSchoolUser].[LectureResource] WHERE ID = @ID";
        public static string GetEnrollmentByID = "SELECT [StudentID],[CourseID],[GradeID],[ID],[LectureRoomID] FROM [FlexiSchool].[flexiSchoolUser].[Enrollment]  WHERE ID = @ID";
        public static string GetEnrollmentByCourse = "SELECT [StudentID],[CourseID],[GradeID],[ID],[LectureRoomID] FROM [FlexiSchool].[flexiSchoolUser].[Enrollment]  WHERE CourseID = @ID";
        public static string GetEnrollmentByLectureRoomID = "SELECT [StudentID],[CourseID],[GradeID],[ID],[LectureRoomID] FROM [FlexiSchool].[flexiSchoolUser].[Enrollment]  WHERE LectureRoomID = @ID";
        public static string GetEnrollmentByStudent = "SELECT [StudentID],[CourseID],[GradeID],[ID],[LectureRoomID] FROM [FlexiSchool].[flexiSchoolUser].[Enrollment]  WHERE StudentID = @ID";
        public static string InsertEnrollment = "INSERT INTO [flexiSchoolUser].[Enrollment] ([CourseID],[StudentID],[GradeID],[LectureRoomID]) VALUES (@CourseID,@StudentID,@GradeID,@LectureRoomID)";


        #endregion
    }
}
