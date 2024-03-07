using LMS.Domain.LectureRoom;
using LMS.Models.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Application.LectureRoom
{
    public class LectureRoomApplication : ILectureRoomApplication
    {
        public ILectureRoomDomain LectureRoomDomain { get; set; }
        public LectureRoomApplication(ILectureRoomDomain lectureRoomDomain)
        {
            LectureRoomDomain = lectureRoomDomain;
        }
        public bool DeleteLectureRoom(int id)
        {
            return LectureRoomDomain.DeleteLectureRoom(id);
        }

        public IEnumerable<LectureRoomDBModel> GetLectureRoom()
        {
            return LectureRoomDomain.GetLectureRoom();
        }

        public LectureRoomDBModel GetLectureRoom(int id)
        {
            return LectureRoomDomain.GetLectureRoom(id);
        }

        public bool InsertLectureRoom(LectureRoomDBModel lectureRoom)
        {
            return LectureRoomDomain.InsertLectureRoom(lectureRoom);
        }

        public bool UpdateLectureRoom(LectureRoomDBModel lectureRoom)
        {
            return LectureRoomDomain.UpdateLectureRoom(lectureRoom);
        }
    }
}
