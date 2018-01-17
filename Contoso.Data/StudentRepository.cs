using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contoso.Model;

namespace Contoso.Data
{
    public class StudentRepository : Repository<Student>, IStudentRepository
    {
        public StudentRepository(ContosoDbContext context) : base(context)
        {
                
        }
        public Student GetStudentByLastName(string lastName)
        {
            var student = _context.People.OfType<Student>().FirstOrDefault(s => s.LastName == lastName);
            return student;
        }

        public IEnumerable<Student> GetStudents()
        {
            var students = _context.Students.ToList();
            return students;
        }
    }
    public interface IStudentRepository : IRepository<Student>
    {
        IEnumerable<Student> GetStudents();
        Student GetStudentByLastName(string lastName);
    }
}
