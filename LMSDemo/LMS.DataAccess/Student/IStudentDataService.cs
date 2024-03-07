﻿using LMS.Models.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Application.Student
{
    public interface IStudentDataService
    {
        IEnumerable<StudentDBModel> GetStudents();
        bool InsertStudent(StudentDBModel student);
        StudentDBModel GetStudent(int id);
        bool UpdateStudent(StudentDBModel student);
        bool DeleteStudent(int id);
    }
}
