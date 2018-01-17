using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contoso.Data;
using Contoso.Model;

namespace Contoso.Service
{
    public class RoleService : IRoleService
    {
        private readonly IRoleRepository _roleRepository;
        public RoleService(IRoleRepository roleRepository)
        {
            _roleRepository = roleRepository;
        }
        public IEnumerable<Role> GetAllRoles()
        {
            return _roleRepository.GetAllRoles();
        }
        public void AddRole(Role role)
        {
            _roleRepository.Add(role);
            _roleRepository.SaveChanges();
        }
    }
    public interface IRoleService
    {
        IEnumerable<Role> GetAllRoles();
    }
}
