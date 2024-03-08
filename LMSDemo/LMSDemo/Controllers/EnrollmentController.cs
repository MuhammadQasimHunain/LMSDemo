using LMS.DataAccess.DataModels;
using LMS.Domain.Course;
using LMS.Domain.Enrollment;
using LMS.Domain.Student;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace LMSDemo.Controllers
{
    public class EnrollmentController : Controller
    {
        public IEnrollmentDomain EnrollmentDomain { get; set; }
        public EnrollmentController(IEnrollmentDomain enrollmentDomain)
        {
            EnrollmentDomain = enrollmentDomain;
        }


        [HttpPost("[action]")]
        public IActionResult InsertEnrollment(EnrollmentDBModel model)
        {
            try
            {
                var lectureRoom = EnrollmentDomain.InsertEnrollment(model);

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
                var lectureRoom = EnrollmentDomain.UpdateEnrollment(model);

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
                var courses = EnrollmentDomain.GetEnrollments();

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
                var lectureRoom = EnrollmentDomain.GetEnrollment(id);

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
                var lectureRoom = EnrollmentDomain.GetEnrollmentByStudent(id);

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
                var lectureRoom = EnrollmentDomain.GetEnrollmentByCources(id);

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
