using LMS.Models.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Domain.Course
{
    public interface ICourseDomain
    {
        IEnumerable<CourseDBModel> GetCourses();
        bool InsertLectureResource(CourseDBModel course);
        CourseDBModel GetCourse(int id);
        bool UpdateCourse(CourseDBModel course);
        bool DeleteCourse(int id);
    }
}
