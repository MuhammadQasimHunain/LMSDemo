using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Models.DataModels
{
    /// <summary>
    /// This defines the Student DataBase Entity
    /// </summary>
    public class StudentDBModel
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        
    }
}
