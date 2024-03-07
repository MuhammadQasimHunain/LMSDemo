using LMS.Application.Course;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace LMSDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        public ICourseApplication CourseApplication { get; set; }
        public CourseController(ICourseApplication courseApplication)
        {
            CourseApplication = courseApplication;
        }

        [HttpGet]
        public IActionResult GetAllCources()
        {
            try
            {
                var courses = CourseApplication.GetCourses();

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
