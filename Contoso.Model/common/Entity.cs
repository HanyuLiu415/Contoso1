using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contoso.Model.common;
namespace Contoso.Model.common
{
    public class Entity : IEntity
    {
        public virtual int Id { get; set; }
    }
}
