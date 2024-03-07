using LMS.Models.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Application.Student
{
    public class StudentDataService : IStudentDataService
    {
        public bool DeleteStudent(int id)
        {
            throw new NotImplementedException();
        }

        public StudentDBModel GetStudent(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<StudentDBModel> GetStudents()
        {
            throw new NotImplementedException();
        }

        public bool InsertStudent(StudentDBModel student)
        {
            throw new NotImplementedException();
        }

        public bool UpdateStudent(StudentDBModel student)
        {
            throw new NotImplementedException();
        }
    }
}
