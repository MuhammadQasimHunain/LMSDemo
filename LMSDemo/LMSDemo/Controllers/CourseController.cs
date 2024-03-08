using LMS.DataAccess.DataModels;
using LMS.Domain.Course;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Reflection;

namespace LMSDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        public ICourseDomain CourseDomain { get; set; }
        public CourseController(ICourseDomain courseDomain)
        {
            CourseDomain = courseDomain;
        }

        [HttpGet]
        public IActionResult GetAllCources()
        {
            try
            {
                var courses = CourseDomain.GetCourses();

                return StatusCode((int)HttpStatusCode.OK, new
                {
                    Status = 1,
                    Data = courses
                });
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.OK, new
                {
                    Status = 0,
                    ex.Message
                });
            }
        }

        [HttpGet("{id}")]
        public IActionResult GetCourseByID(int id)
        {
            try
            {
                var courses = CourseDomain.GetCourse(id);

                return StatusCode((int)HttpStatusCode.OK, new
                {
                    Status = 1,
                    Data = courses
                });
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.OK, new
                {
                    Status = 0,
                    ex.Message
                });
            }
        }

        [HttpPut]
        public IActionResult UpdateCourse(CourseDBModel model)
        {
            try
            {
                var courses = CourseDomain.UpdateCourse(model);

                return StatusCode((int)HttpStatusCode.OK, new
                {
                    Status = 1,
                    Data = courses
                });
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.OK, new
                {
                    Status = 0,
                    ex.Message
                });
            }
        }

        [HttpPost]
        public IActionResult InsertCourse(CourseDBModel model)
        {
            try
            {
                var courses = CourseDomain.InsertCourse(model);

                return StatusCode((int)HttpStatusCode.OK, new
                {
                    Status = 1,
                    Data = courses
                });
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.OK, new
                {
                    Status = 0,
                    ex.Message
                });
            }
        }

        [HttpDelete]
        public IActionResult DeleteCourse(int id)
        {
            try
            {
                var courses = CourseDomain.DeleteCourse(id);

                return StatusCode((int)HttpStatusCode.OK, new
                {
                    Status = 1,
                    Data = courses
                });
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.OK, new
                {
                    Status = 0,
                    ex.Message
                });
            }
        }

    }
}
