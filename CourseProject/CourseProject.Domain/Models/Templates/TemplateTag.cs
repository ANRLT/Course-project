using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CourseProject.Domain.Models.Templates
{
    public class TemplateTag
    {
        public int TagId { get; set; }
        public Tag Tag { get; set; }        
        public int TemplateId { get; set; }
        public Template Template { get; set; }
    }
}
