using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contoso.Data;
using Contoso.Model;

namespace Contoso.Service
{
    public class StudentService : IStudentService
    {
        protected readonly IStudentRepository _studnetRepository;
        public StudentService (IStudentRepository studentRepository)
        {
            _studnetRepository = studentRepository;
        }
        public IEnumerable<Student> GetStudents()
        {
            return _studnetRepository.GetAll();
        }

        public Student GetStudentByLastName(string lastName)
        {
            return _studnetRepository.GetStudentByLastName(lastName);
        }
    }
    public interface IStudentService
    {
        IEnumerable<Student> GetStudents();
        Student GetStudentByLastName(string lastName);
    }
}
