using LMS.Domain.Student;
using LMS.Models.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Application.Student
{
    public class StudentApplication : IStudentApplication
    {
        public IStudentDomain StudentDomain { get; set; }
        public StudentApplication(IStudentDomain studentDomain)
        {
            StudentDomain = studentDomain;
        }
        public bool DeleteStudent(int id)
        {
            return StudentDomain.DeleteStudent(id);
        }


        public StudentDBModel GetStudent(int id)
        {
            return StudentDomain.GetStudent(id);
        }

        public IEnumerable<StudentDBModel> GetStudents()
        {
            return StudentDomain.GetStudents();
        }

        public bool InsertStudent(StudentDBModel student)
        {
            return StudentDomain.InsertStudent(student);
        }

        public bool UpdateStudent(StudentDBModel student)
        {
            return StudentDomain.UpdateStudent(student);
        }
    }
}
