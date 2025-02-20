using CourseProject.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject.Domain.Models.BaseModels
{
    public class BaseUser 
    {
        public int Id { get; set; }        
        public string Name { get; set; }
        public string Email { get; set; }
        public Status Status { get; set; } = Status.Active;
        DateTime UpdatedAt { get; set; }
        DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
