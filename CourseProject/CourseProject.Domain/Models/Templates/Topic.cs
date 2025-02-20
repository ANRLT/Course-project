using CourseProject.Domain.Models.BaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject.Domain.Models.Templates
{
    public class Topic : BaseEntity
    {
        public string Name { get; set; } = null!;
        public ICollection<Template> Templates { get; set; } = new List<Template>();
    }
}
