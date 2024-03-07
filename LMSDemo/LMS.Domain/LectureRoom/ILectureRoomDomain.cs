using LMS.Models.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Domain.LectureRoom
{
    public interface ILectureRoomDomain
    {
        IEnumerable<LectureRoomDBModel> GetLectureRoom();
        bool InsertLectureRoom(LectureRoomDBModel lectureRoom);
        LectureRoomDBModel GetLectureRoom(int id);
        bool UpdateLectureRoom(LectureRoomDBModel lectureRoom);
        bool DeleteLectureRoom(int id);
    }
}
