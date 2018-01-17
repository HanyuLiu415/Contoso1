using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contoso.Model.common;
namespace Contoso.Model
{
    public class Enrollment : AuditableEntity
    {
        public int CourseId { get; set; }
        public Course Course { get; set; }
        public int StudentId { get; set; }
        public Student student { get; set; }
        public int Grade { get; set; }
    }
}
