using LMS.Application.Student;
using LMS.Models.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Domain.Student
{
    public class StudentDomain : IStudentDomain
    {
        public IStudentDataService StudentDataService { get; set; }
        public StudentDomain(IStudentDataService studentDataService)
        {
            StudentDataService = studentDataService;
        }
        public bool DeleteStudent(int id)
        {
            return this.StudentDataService.DeleteStudent(id);
        }

        public StudentDBModel GetStudent(int id)
        {
            return this.StudentDataService.GetStudent(id);
        }

        public IEnumerable<StudentDBModel> GetStudents()
        {
            return this.StudentDataService.GetStudents();
        }

        public bool InsertStudent(StudentDBModel student)
        {
            return this.StudentDataService.InsertStudent(student);
        }

        public bool UpdateStudent(StudentDBModel student)
        {
            return this.StudentDataService.UpdateStudent(student);
        }
    }
}
