using LMS.Application.Course;
using LMS.Application.LectureRoom;
using LMS.DataAccess.Enrollment;
using LMS.Domain.LectureRoom;
using LMS.Models.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Domain.Enrollment
{
    public class EnrollmentDomain : IEnrollmentDomain
    {
        public IEnrollmentDataService EnrollmentDataService { get; set; }
        public ILectureRoomDataService LectureRoomDataService { get; set; }
        public EnrollmentDomain(IEnrollmentDataService enrollmentDataService, ILectureRoomDataService lectureRoomDataService)
        {
            EnrollmentDataService = enrollmentDataService;
            LectureRoomDataService = lectureRoomDataService;
        }
        public bool DeleteEnrollment(int id)
        {
            return EnrollmentDataService.DeleteEnrollment(id);
        }

        public EnrollmentDBModel GetEnrollment(int id)
        {
            return EnrollmentDataService.GetEnrollment(id);
        }

        public IEnumerable<EnrollmentDBModel> GetEnrollmentByCources(int id)
        {
            return EnrollmentDataService.GetEnrollmentByCources(id);
        }

        public IEnumerable<EnrollmentDBModel> GetEnrollmentByStudent(int id)
        {
            return EnrollmentDataService.GetEnrollmentByStudent(id);
        }

        public IEnumerable<EnrollmentDBModel> GetEnrollments()
        {
            return EnrollmentDataService.GetEnrollments();
        }

        public bool InsertEnrollment(EnrollmentDBModel enrollment)
        {
            var enrolledStudents = EnrollmentDataService.GetEnrollmentByCources(enrollment.CourseID).Count();
            var lectureRoomCapasity = LectureRoomDataService.GetLectureRoom(enrollment.LectureRoomID).Capaicty;
            var enrollSubjectByStudent = EnrollmentDataService.GetEnrollmentByStudent(enrollment.StudentID).Count();
            if (enrolledStudents >= lectureRoomCapasity)
            {
                return false;
            }
            if (enrollSubjectByStudent >= 10)
            {
                return false;
            }
            return EnrollmentDataService.InsertEnrollment(enrollment);
        }

        public bool UpdateEnrollment(EnrollmentDBModel enrollment)
        {
            return EnrollmentDataService.UpdateEnrollment(enrollment);
        }
    }
}
