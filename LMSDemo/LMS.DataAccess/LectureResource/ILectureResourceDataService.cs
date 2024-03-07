using LMS.Models.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Application.LectureResource
{
    public interface ILectureResourceDataService
    {
        IEnumerable<LectureResourceDBModel> GetLectureResources();
        bool InsertLectureResource(LectureResourceDBModel lectureResource);
        LectureResourceDBModel GetLectureRoom(int id);
        bool UpdateLectureRoom(LectureResourceDBModel lectureResource);
        bool DeleteLectureRoom(int id);
    }
}
