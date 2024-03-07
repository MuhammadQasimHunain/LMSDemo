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
        public bool DeleteLectureRoom(int id)
        {
            return LectureResourceDomain.DeleteLectureRoom(id);
        }

        public IEnumerable<LectureResourceDBModel> GetLectureResources()
        {
            return LectureResourceDomain.GetLectureResources();
        }

        public LectureResourceDBModel GetLectureRoom(int id)
        {
            return LectureResourceDomain.GetLectureRoom(id);
        }

        public bool InsertLectureResource(LectureResourceDBModel lectureResource)
        {
            return LectureResourceDomain.InsertLectureResource(lectureResource);
        }

        public bool UpdateLectureRoom(LectureResourceDBModel lectureResource)
        {
            return LectureResourceDomain.UpdateLectureRoom(lectureResource);
        }
    }
}
