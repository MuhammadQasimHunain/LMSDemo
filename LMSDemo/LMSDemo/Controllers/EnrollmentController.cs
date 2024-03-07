using LMS.Application.Course;
using LMS.Application.Enrollment;
using LMS.Application.Student;
using LMS.Models.DataModels;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace LMSDemo.Controllers
{
    public class EnrollmentController : Controller
    {
        public IEnrollmentApplication EnrollmentApplication { get; set; }
        public EnrollmentController(IEnrollmentApplication enrollmentApplication)
        {
            EnrollmentApplication = enrollmentApplication;
        }


        [HttpPost("[action]")]
        public IActionResult InsertEnrollment(EnrollmentDBModel model)
        {
            try
            {
                var lectureRoom = EnrollmentApplication.InsertEnrollment(model);

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


        [HttpPut("[action]")]
        public IActionResult UpdateEnrollment(EnrollmentDBModel model)
        {
            try
            {
                var lectureRoom = EnrollmentApplication.UpdateEnrollment(model);

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


        [HttpGet("[action]")]
        public IActionResult GetAllEnrollments()
        {
            try
            {
                var courses = EnrollmentApplication.GetEnrollments();

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

        [HttpGet("[action]/{id}")]
        public IActionResult GetEnrollmentByID(int id)
        {
            try
            {
                var lectureRoom = EnrollmentApplication.GetEnrollment(id);

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

        [HttpGet("[action]/{id}")]
        public IActionResult GetEnrollmentsByStudentsID(int id)
        {
            try
            {
                var lectureRoom = EnrollmentApplication.GetEnrollmentByStudent(id);

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

        [HttpGet("[action]/{id}")]
        public IActionResult GetEnrollmentsByCourseID(int id)
        {
            try
            {
                var lectureRoom = EnrollmentApplication.GetEnrollmentByCources(id);

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
