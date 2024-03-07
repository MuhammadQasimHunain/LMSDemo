using LMS.Domain.Course;
using LMS.Models.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Application.Course
{
    public class CourseApplication : ICourseApplication
    {
        public ICourseDomain CourseDomain { get; set; }
        public CourseApplication(ICourseDomain courseDomain)
        {
            CourseDomain = courseDomain;
        }
        public bool DeleteCourse(int id)
        {
            return CourseDomain.DeleteCourse(id);
        }

        public CourseDBModel GetCourse(int id)
        {
            return CourseDomain.GetCourse(id);
        }

        public IEnumerable<CourseDBModel> GetCourses()
        {
            return CourseDomain.GetCourses();
        }

        public bool InsertCourse(CourseDBModel course)
        {
            return CourseDomain.InsertCourse(course);
        }

        public bool UpdateCourse(CourseDBModel course)
        {
            return CourseDomain.UpdateCourse(course);
        }
    }
}
