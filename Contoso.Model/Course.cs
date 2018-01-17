using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contoso.Model.common;
using System.ComponentModel.DataAnnotations;
namespace Contoso.Model
{
    public class Course: AuditableEntity
    {
        [StringLength (50,MinimumLength = 3)]
        public String Title { get; set; }
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
        public decimal Credit { get; set; }
    }
}
