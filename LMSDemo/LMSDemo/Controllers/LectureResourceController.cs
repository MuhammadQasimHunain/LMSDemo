using LMS.Application.Course;
using LMS.Application.LectureResource;
using LMS.Models.DataModels;
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


        [HttpGet("{id}")]
        public IActionResult GetLectureResourceByID(int id)
        {
            try
            {
                var lectureResource = LectureResourceApplication.GetLectureResource(id);

                return StatusCode((int)HttpStatusCode.OK, new
                {
                    Status = 1,
                    Data = lectureResource
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
        public IActionResult UpdateLectureResource(LectureResourceDBModel model)
        {
            try
            {
                var lectureResource = LectureResourceApplication.UpdateLectureResource(model);

                return StatusCode((int)HttpStatusCode.OK, new
                {
                    Status = 1,
                    Data = lectureResource
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
        public IActionResult InsertLectureResource(LectureResourceDBModel model)
        {
            try
            {
                var lectureResource = LectureResourceApplication.InsertLectureResource(model);

                return StatusCode((int)HttpStatusCode.OK, new
                {
                    Status = 1,
                    Data = lectureResource
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
                var lectureResource = LectureResourceApplication.DeleteLectureResource(id);

                return StatusCode((int)HttpStatusCode.OK, new
                {
                    Status = 1,
                    Data = lectureResource
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
