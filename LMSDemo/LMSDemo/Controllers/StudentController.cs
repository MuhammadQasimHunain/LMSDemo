using LMS.Application.LectureRoom;
using LMS.Application.Student;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace LMSDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        public IStudentApplication StudentApplication { get; set; }
        public StudentController(IStudentApplication studentApplication)
        {
            StudentApplication = studentApplication;
        }

        [HttpGet]
        public IActionResult GetAllStudents()
        {
            try
            {
                var courses = StudentApplication.GetStudents();

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
