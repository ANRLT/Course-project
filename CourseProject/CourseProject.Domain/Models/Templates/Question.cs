using CourseProject.Domain.Enums;
using CourseProject.Domain.Models.BaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject.Domain.Models.Templates
{
    public class Question : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public FieldType FieldType { get; set; }       
        public int Order {  get; set; }
        public int TemplateId { get; set; }
        public Template Template { get; set; }
    }
}
