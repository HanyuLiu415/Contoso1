using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contoso.Model;

namespace Contoso.Data
{
    public class PersonRepository : Repository<People>, IPersonRepository
    {
        public PersonRepository(ContosoDbContext context) : base(context)
        {

        }
        public People GetByLastName(string lastName)
        {
            var person = _context.People.Where(p => p.LastName == lastName).FirstOrDefault();
            return person;
        }
    }
    public interface IPersonRepository : IRepository<People>
    {
        People GetByLastName(string lastName);
    }
}
