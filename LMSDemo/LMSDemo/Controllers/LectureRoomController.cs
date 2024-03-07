using LMS.Application.Course;
using LMS.Application.LectureResource;
using LMS.Application.LectureRoom;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace LMSDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LectureRoomController : ControllerBase
    {
        public ILectureRoomApplication LectureRoomApplication { get; set; }
        public LectureRoomController(ILectureRoomApplication lectureRoomApplication)
        {
            LectureRoomApplication = lectureRoomApplication;
        }

        [HttpGet]
        public IActionResult GetAllLectureRooms()
        {
            try
            {
                var courses = LectureRoomApplication.GetLectureRoom();

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
