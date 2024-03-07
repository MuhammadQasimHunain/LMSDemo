﻿using LMS.Domain.LectureRoom;
using LMS.Models.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Application.LectureRoom
{
    public interface ILectureRoomApplication
    {
        IEnumerable<LectureRoomDBModel> GetLectureRoom();
        bool InsertLectureRoom(LectureRoomDBModel lectureRoom);
        LectureRoomDBModel GetLectureRoom(int id);
        bool UpdateLectureRoom(StudentDBModel lectureRoom);
        bool DeleteLectureRoom(int id);
    }
}
