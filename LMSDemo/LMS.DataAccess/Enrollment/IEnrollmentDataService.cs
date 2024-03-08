using LMS.Models.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.DataAccess.Enrollment
{
    public interface IEnrollmentDataService
    {
        IEnumerable<EnrollmentDBModel> GetEnrollments();
        bool InsertEnrollment(EnrollmentDBModel enrollment);
        EnrollmentDBModel GetEnrollment(int id);
        IEnumerable<EnrollmentDBModel> GetEnrollmentByCources(int id);
        IEnumerable<EnrollmentDBModel> GetEnrollmentByStudent(int id);
        IEnumerable<EnrollmentDBModel> GetEnrollmentByLectureRoom(int id);
        bool UpdateEnrollment(EnrollmentDBModel enrollment);
        bool DeleteEnrollment(int id);
    }
}
