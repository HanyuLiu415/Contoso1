using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Contoso.Model;

namespace Contoso.Data
{
    public class EnrollmentRepository : Repository<Enrollment>,IEnrollmentRepository
    {
        public EnrollmentRepository(ContosoDbContext context) : base(context)
        {
                
        }

        public IEnumerable<Enrollment> GetAllEnrollment()
        {
            return _context.Enrollments.ToList();
        }

        public IEnumerable<Enrollment> GetEnrollmentByCourseId(int id)
        {
            return _context.Enrollments.Where(e => e.CourseId == id).ToList();
        }
    }

    public interface IEnrollmentRepository : IRepository<Enrollment>
    {
        IEnumerable<Enrollment> GetAllEnrollment();
        IEnumerable<Enrollment> GetEnrollmentByCourseId(int id);
    }
}
