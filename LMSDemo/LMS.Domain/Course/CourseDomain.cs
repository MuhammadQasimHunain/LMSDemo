using LMS.DataAccess.Course;
using LMS.DataAccess.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Domain.Course
{
    public class CourseDomain : ICourseDomain
    {
        public ICourseDataLayer CourseDataService { get; set; }
        public CourseDomain(ICourseDataLayer courseDataService)
        {
            CourseDataService = courseDataService;
        }
        public bool DeleteCourse(int id)
        {
            return CourseDataService.DeleteCourse(id);
        }

        public CourseDBModel GetCourse(int id)
        {
            return CourseDataService.GetCourse(id);
        }

        public IEnumerable<CourseDBModel> GetCourses()
        {
            return CourseDataService.GetCourses();
        }

        public bool InsertCourse(CourseDBModel course)
        {
            return CourseDataService.InsertCourse(course);
        }

        public bool UpdateCourse(CourseDBModel course)
        {
            return CourseDataService.UpdateCourse(course);
        }
    }
}
