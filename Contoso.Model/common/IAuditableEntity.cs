using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contoso.Model.common
{
    public interface IAuditableEntity
    {   //properties
        //only some tables inherit this interface
         DateTime? CreateDate { get; set; }
         DateTime? UpdatedDate { get; set; }
         string CreatedBy { get; set; }
         string UpdatedBy { get; set; }
    }
}
