using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contoso.Model.common;
namespace Contoso.Model
{   [System.ComponentModel.DataAnnotations.Schema.Table("Student")]
    public class Student : People
    {
        public DateTime? EnrollmentDate { get; set; }
    }
}
