using CourseProject.Domain.Enums;
using CourseProject.Domain.Models.BaseModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject.Domain.Models.Users
{
    public class User : BaseUser
    {
        public string PasswordHash { get; set; } = string.Empty;
        public string Salt { get; set; } = string.Empty;
    }    
}
