using LMS.Models.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Application.Course
{
    public interface ICourseApplication
    {
        IEnumerable<CourseDBModel> GetCourses();
        bool InsertCourse(CourseDBModel course);
        CourseDBModel GetCourse(int id);
        bool UpdateCourse(CourseDBModel course);
        bool DeleteCourse(int id);
    }
}
