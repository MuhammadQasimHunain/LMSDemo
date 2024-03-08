using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.DataAccess.DataModels
{
    /// <summary>
    /// This defines the Lecture resources DataBase Entity
    /// </summary>
    public class LectureResourceDBModel
    {
        public int ID { get; set; }
        public int CourseID { get; set; }
        public byte[] Resource { get; set; }
        public string Extension { get; set; }
    }
}
