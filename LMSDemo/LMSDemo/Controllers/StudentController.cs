using LMS.Application.LectureRoom;
using LMS.Application.Student;
using LMS.Models.DataModels;
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


        [HttpGet("{id}")]
        public IActionResult GetStudentByID(int id)
        {
            try
            {
                var lectureRoom = StudentApplication.GetStudent(id);

                return StatusCode((int)HttpStatusCode.OK, new
                {
                    Status = 1,
                    Data = lectureRoom
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
        public IActionResult UpdateStudent(StudentDBModel model)
        {
            try
            {
                var lectureRoom = StudentApplication.UpdateStudent(model);

                return StatusCode((int)HttpStatusCode.OK, new
                {
                    Status = 1,
                    Data = lectureRoom
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
        public IActionResult InsertStudent(StudentDBModel model)
        {
            try
            {
                var lectureRoom = StudentApplication.InsertStudent(model);

                return StatusCode((int)HttpStatusCode.OK, new
                {
                    Status = 1,
                    Data = lectureRoom
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
        public IActionResult DeleteStudent(int id)
        {
            try
            {
                var lectureRoom = StudentApplication.DeleteStudent(id);

                return StatusCode((int)HttpStatusCode.OK, new
                {
                    Status = 1,
                    Data = lectureRoom
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
