using LMS.DataAccess.DataModels;
using LMS.DataAccess.LectureResource;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Domain.LectureResource
{
    public class LectureResourceDomain : ILectureResourceDomain
    {
        public ILectureResourceDataLayer LectureResourcDataService { get; set; }
        public LectureResourceDomain(ILectureResourceDataLayer lectureResourcDataService)
        {
            LectureResourcDataService = lectureResourcDataService;
        }
        public bool DeleteLectureResource(int id)
        {
            return LectureResourcDataService.DeleteLectureResource(id);
        }

        public IEnumerable<LectureResourceDBModel> GetLectureResources()
        {
            return LectureResourcDataService.GetLectureResources();
        }

        public LectureResourceDBModel GetLectureResource(int id)
        {
            return LectureResourcDataService.GetLectureResource(id);
        }

        public bool InsertLectureResource(LectureResourceDBModel lectureResource)
        {
            return LectureResourcDataService.InsertLectureResource(lectureResource);
        }

        public bool UpdateLectureResource(LectureResourceDBModel lectureResource)
        {
            return LectureResourcDataService.UpdateLectureResource(lectureResource);
        }
    }
}
