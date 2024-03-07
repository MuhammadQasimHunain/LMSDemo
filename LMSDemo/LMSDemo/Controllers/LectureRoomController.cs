using LMS.Application.Course;
using LMS.Application.LectureResource;
using LMS.Application.LectureRoom;
using LMS.Models.DataModels;
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
                var lectureRooms = LectureRoomApplication.GetLectureRoom();

                return StatusCode((int)HttpStatusCode.OK, new
                {
                    Status = 1,
                    Data = lectureRooms
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
        public IActionResult GetLectureRoomsByID(int id)
        {
            try
            {
                var lectureRoom = LectureRoomApplication.GetLectureRoom(id);

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
        public IActionResult UpdateLectureResource(LectureRoomDBModel model)
        {
            try
            {
                var lectureRoom = LectureRoomApplication.UpdateLectureRoom(model);

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
        public IActionResult InsertLectureResource(LectureRoomDBModel model)
        {
            try
            {
                var lectureRoom = LectureRoomApplication.InsertLectureRoom(model);

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
        public IActionResult DeleteLectureResource(int id)
        {
            try
            {
                var lectureRoom = LectureRoomApplication.DeleteLectureRoom(id);

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
