using LMS.Application.Course;
using LMS.Application.LectureResource;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace LMSDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LectureResourceController : ControllerBase
    {

        public ILectureResourceApplication LectureResourceApplication { get; set; }
        public LectureResourceController(ILectureResourceApplication lectureResourceApplication)
        {
            LectureResourceApplication = lectureResourceApplication;
        }


        [HttpGet]
        public IActionResult GetAllLectureResources()
        {
            try
            {
                var lectureResources = LectureResourceApplication.GetLectureResources();

                return StatusCode((int)HttpStatusCode.OK, new
                {
                    Status = 1,
                    Data = lectureResources
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
