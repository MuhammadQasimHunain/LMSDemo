using LMS.Domain.Enrollment;
using LMS.Domain.LectureResource;
using LMS.Models.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Application.Enrollment
{
    public class EnrollmentApplication : IEnrollmentApplication
    {
        public IEnrollmentDomain EnrollmentDomain { get; set; }
        public EnrollmentApplication(IEnrollmentDomain enrollmentDomain)
        {
            EnrollmentDomain = enrollmentDomain;
        }
        public bool DeleteEnrollment(int id)
        {
            return EnrollmentDomain.DeleteEnrollment(id);
        }

        public EnrollmentDBModel GetEnrollment(int id)
        {
            return EnrollmentDomain.GetEnrollment(id);
        }

        public IEnumerable<EnrollmentDBModel> GetEnrollmentByCources(int id)
        {
            return EnrollmentDomain.GetEnrollmentByCources(id);
        }

        public IEnumerable<EnrollmentDBModel> GetEnrollmentByStudent(int id)
        {
            return EnrollmentDomain.GetEnrollmentByStudent(id);
        }

        public IEnumerable<EnrollmentDBModel> GetEnrollments()
        {
            return EnrollmentDomain.GetEnrollments();
        }

        public bool InsertEnrollment(EnrollmentDBModel enrollment)
        {
            return EnrollmentDomain.InsertEnrollment(enrollment);
        }

        public bool UpdateEnrollment(EnrollmentDBModel enrollment)
        {
            return EnrollmentDomain.UpdateEnrollment(enrollment);
        }

    }
}
