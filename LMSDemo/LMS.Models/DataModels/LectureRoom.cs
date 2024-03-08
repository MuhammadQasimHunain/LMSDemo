using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Models.DataModels
{
    /// <summary>
    /// This defines the Lecture Rooms DataBase Entity
    /// </summary>
    public class LectureRoomDBModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Capaicty { get; set; }

    }
}
