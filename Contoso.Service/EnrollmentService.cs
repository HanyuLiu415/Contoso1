using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contoso.Data;
using Contoso.Model;

namespace Contoso.Service
{
    public class EnrollmentService : IEnrollmentService
    {
        private readonly IEnrollmentRepository _enrollmentRepository;
        public EnrollmentService(IEnrollmentRepository enrollmentRepository)
        {
            _enrollmentRepository = enrollmentRepository;
        }
        public IEnumerable<Enrollment> GetAllEnrollment()
        {
            return _enrollmentRepository.GetAllEnrollment();
        }

        public IEnumerable<Enrollment> GetEnrollmentByCourseId(int id)
        {
            return _enrollmentRepository.GetEnrollmentByCourseId(id);
        }
    }
    public interface IEnrollmentService
    {
        IEnumerable<Enrollment> GetAllEnrollment();
        IEnumerable<Enrollment> GetEnrollmentByCourseId(int id);
    }
}
