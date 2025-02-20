using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject.Domain.Models.BaseModels
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        DateTime UpdatedAt { get; set; }
        DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
