using LMS.DataAccess.DataModels;
using LMS.DataAccess.LectureRoom;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Domain.LectureRoom
{
    public class LectureRoomDomain : ILectureRoomDomain
    {
        public ILectureRoomDataLayer LectureRoomDataService { get; set; }
        public LectureRoomDomain(ILectureRoomDataLayer lectureRoomData)
        {
            LectureRoomDataService = lectureRoomData;
        }
        public bool DeleteLectureRoom(int id)
        {
            return LectureRoomDataService.DeleteLectureRoom(id);
        }

        public IEnumerable<LectureRoomDBModel> GetLectureRoom()
        {
            return LectureRoomDataService.GetLectureRoom();
        }

        public LectureRoomDBModel GetLectureRoom(int id)
        {
            return LectureRoomDataService.GetLectureRoom(id);
        }

        public bool InsertLectureRoom(LectureRoomDBModel lectureRoom)
        {
            return LectureRoomDataService.InsertLectureRoom(lectureRoom);
        }

        public bool UpdateLectureRoom(LectureRoomDBModel lectureRoom)
        {
            return LectureRoomDataService.UpdateLectureRoom(lectureRoom);
        }
    }
}
