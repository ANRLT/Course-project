using CourseProject.Domain.Models.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject.Domain.Models.Templates
{
    public class TemplateAccess
    {
        public int TemplateId { get; set; }
        public Template Template { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }
    }
}
