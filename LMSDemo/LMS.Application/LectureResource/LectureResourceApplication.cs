using LMS.Domain.LectureResource;
using LMS.Models.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Application.LectureResource
{
    public class LectureResourceApplication : ILectureResourceApplication
    {
        public ILectureResourceDomain LectureResourceDomain { get; set; }
        public LectureResourceApplication(ILectureResourceDomain lectureResourceDomain)
        {
            LectureResourceDomain = lectureResourceDomain;
        }
        public bool DeleteLectureResource(int id)
        {
            return LectureResourceDomain.DeleteLectureResource(id);
        }

        public IEnumerable<LectureResourceDBModel> GetLectureResources()
        {
            return LectureResourceDomain.GetLectureResources();
        }

        public LectureResourceDBModel GetLectureResource(int id)
        {
            return LectureResourceDomain.GetLectureResource(id);
        }

        public bool InsertLectureResource(LectureResourceDBModel lectureResource)
        {
            return LectureResourceDomain.InsertLectureResource(lectureResource);
        }

        public bool UpdateLectureResource(LectureResourceDBModel lectureResource)
        {
            return LectureResourceDomain.UpdateLectureResource(lectureResource);
        }
    }
}
