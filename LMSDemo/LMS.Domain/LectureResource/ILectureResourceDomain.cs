using LMS.Models.DataModels;
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
        LectureResourceDBModel GetLectureRoom(int id);
        bool UpdateLectureRoom(LectureResourceDBModel lectureResource);
        bool DeleteLectureRoom(int id);
    }
}
