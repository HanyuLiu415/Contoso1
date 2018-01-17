using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contoso.Data;
using Contoso.Model;

namespace Contoso.Service
{
    public class DepartmentService : IDepartmentService
    {
        private readonly IDepartmentRepository _departmentRepository;

        public DepartmentService(IDepartmentRepository departmentRepository)
        {
            _departmentRepository = departmentRepository;
        }
        public void AddDepartment(Department department)
        {
            _departmentRepository.Add(department);
        }

        public IEnumerable<Department> GetAllDepartmentIncludeCourses()
        {
            return _departmentRepository.GetAllDepartmentsIncludeCourses();
        }

        public Department GetDepartmentById(int id)
        {
            return _departmentRepository.GetById(id);
        }

        public IEnumerable<Department> GetDepartments()
        {
            return _departmentRepository.GetAll();
        }

        public void UpdateDepartment(Department department)
        {
            _departmentRepository.Update(department);
        }
    }
    public interface IDepartmentService
    {
        IEnumerable<Department> GetDepartments();
        IEnumerable<Department> GetAllDepartmentIncludeCourses();
        void AddDepartment(Department department);
        Department GetDepartmentById(int id);
        void UpdateDepartment(Department department);
    }
}
