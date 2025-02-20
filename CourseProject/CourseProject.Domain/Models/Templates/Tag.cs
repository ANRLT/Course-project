using CourseProject.Domain.Models.BaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject.Domain.Models.Templates
{
    public class Tag : BaseEntity
    {
        public string Name { get; set; }
        public ICollection<TemplateTag> TemplateTags { get; set; }
    }
}
