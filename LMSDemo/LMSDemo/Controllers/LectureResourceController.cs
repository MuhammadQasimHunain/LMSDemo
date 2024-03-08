using LMS.DataAccess.DataModels;
using LMS.Domain.LectureResource;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace LMSDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LectureResourceController : ControllerBase
    {

        public ILectureResourceDomain LectureResourceDomain { get; set; }
        public LectureResourceController(ILectureResourceDomain lectureResourceDomain)
        {
            LectureResourceDomain = lectureResourceDomain;
        }

        [HttpGet]
        public IActionResult GetAllLectureResources()
        {
            try
            {
                var lectureResources = LectureResourceDomain.GetLectureResources();

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
                var lectureResource = LectureResourceDomain.GetLectureResource(id);

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
                var lectureResource = LectureResourceDomain.UpdateLectureResource(model);

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
                var lectureResource = LectureResourceDomain.InsertLectureResource(model);

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
                var lectureResource = LectureResourceDomain.DeleteLectureResource(id);

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
