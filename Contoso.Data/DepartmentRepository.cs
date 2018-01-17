using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contoso.Model;

namespace Contoso.Data
{
    public class DepartmentRepository : Repository<Department>,IDepartmentRepository        
    {
        public DepartmentRepository(ContosoDbContext context) : base(context)
        {
            
        }

        public IEnumerable<Department> GetAllDepartmentsIncludeCourses()
        {
            var departments = _context.Departments.ToList();
            return departments;
        }
    }
    public interface IDepartmentRepository : IRepository<Department>
    {
        IEnumerable<Department> GetAllDepartmentsIncludeCourses();
    }
}
