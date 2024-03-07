using LMS.Application.LectureResource;
using LMS.Application.LectureRoom;
using LMS.Models.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Domain.LectureResource
{
    public class LectureResourceDomain : ILectureResourceDomain
    {
        public ILectureResourceDataService LectureResourcDataService { get; set; }
        public LectureResourceDomain(ILectureResourceDataService lectureResourcDataService)
        {
            LectureResourcDataService = lectureResourcDataService;
        }
        public bool DeleteLectureRoom(int id)
        {
            return LectureResourcDataService.DeleteLectureRoom(id);
        }

        public IEnumerable<LectureResourceDBModel> GetLectureResources()
        {
            return LectureResourcDataService.GetLectureResources();
        }

        public LectureResourceDBModel GetLectureRoom(int id)
        {
            return LectureResourcDataService.GetLectureRoom(id);
        }

        public bool InsertLectureResource(LectureResourceDBModel lectureResource)
        {
            return LectureResourcDataService.InsertLectureResource(lectureResource);
        }

        public bool UpdateLectureRoom(LectureResourceDBModel lectureResource)
        {
            return LectureResourcDataService.UpdateLectureRoom(lectureResource);
        }
    }
}
