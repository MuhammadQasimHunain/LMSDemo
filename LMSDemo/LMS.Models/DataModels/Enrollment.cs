using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Models.DataModels
{
    /// <summary>
    /// This defines the Lecture Enrollment DataBase Entity
    /// </summary>
    public class EnrollmentDBModel
    {
        public int ID { get; set; }
        public int StudentID { get; set; }
        public int CourseID { get; set; }
        public int GradeID { get; set; }
        public int LectureRoomID { get; set; }
    }
}
