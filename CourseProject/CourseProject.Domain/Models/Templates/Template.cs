using CourseProject.Domain.Models.BaseModels;
using CourseProject.Domain.Models.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CourseProject.Domain.Models.Templates
{
    public class Template : BaseEntity
    {
        public string Title { get; set; } = null!;

        public string Description { get; set; } = null!;
        public string ImageUrl { get; set; } = null!;

        public bool IsPublic { get; set; }

        public string AuthorId { get; set; }
        public User Author { get; set; }

        public string TopicId { get; set; }
        public Topic Topic { get; set; }

        public ICollection<Question> Questions { get; set; } = new List<Question>();
        public ICollection<Form> Forms { get; set; } = new List<Form>();
        public ICollection<Commentary> Comments { get; set; } = new List<Commentary>();
        public ICollection<Like> Likes { get; set; } = new List<Like>();
        public ICollection<TemplateAccess> AllowedUsers { get; set; } = new List<TemplateAccess>();
        public ICollection<TemplateTag> TemplateTags { get; set; } = new List<TemplateTag>();


        [Column(TypeName = "tsvector")]
        public string SearchVector { get; set; } = null!;
    }
}
