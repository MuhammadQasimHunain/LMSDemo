using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.DataAccess.DataModels
{
    /// <summary>
    /// This defines the Course DataBase Entity
    /// </summary>
    public class CourseDBModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Semester { get; set; }
        public int CreditUnits { get; set; }

    }
}
