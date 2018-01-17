using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contoso.Model;
namespace Contoso.Data
{
    public class RoleRepository : Repository<Role>,IRoleRepository
    {
        public RoleRepository(ContosoDbContext context) : base(context)
        {

        }

        

        public IEnumerable<Role> GetAllRoles()
        {
            return _context.Roles.ToList();
        }
    }
    public interface IRoleRepository : IRepository<Role>
    {
        IEnumerable<Role> GetAllRoles();
    }
}
