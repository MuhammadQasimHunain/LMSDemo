using LMS.DataAccess.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Domain.LectureResource
{
    public interface ILectureResourceDomain
    {
        IEnumerable<LectureResourceDBModel> GetLectureResources();
        bool InsertLectureResource(LectureResourceDBModel lectureResource);
        LectureResourceDBModel GetLectureResource(int id);
        bool UpdateLectureResource(LectureResourceDBModel lectureResource);
        bool DeleteLectureResource(int id);
    }
}
