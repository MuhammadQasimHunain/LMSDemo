using LMS.DataAccess.DataModels;
using LMS.Domain.LectureRoom;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace LMSDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LectureRoomController : ControllerBase
    {
        public ILectureRoomDomain LectureRoomDomain { get; set; }
        public LectureRoomController(ILectureRoomDomain lectureRoomDomain)
        {
            LectureRoomDomain = lectureRoomDomain;
        }

        [HttpGet]
        public IActionResult GetAllLectureRooms()
        {
            try
            {
                var lectureRooms = LectureRoomDomain.GetLectureRoom();

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
                var lectureRoom = LectureRoomDomain.GetLectureRoom(id);

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
                var lectureRoom = LectureRoomDomain.UpdateLectureRoom(model);

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
                var lectureRoom = LectureRoomDomain.InsertLectureRoom(model);

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
                var lectureRoom = LectureRoomDomain.DeleteLectureRoom(id);

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
