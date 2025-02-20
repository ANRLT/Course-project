using CourseProject.Domain.Models.BaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject.Domain.Models.Templates
{
    public class Answer : BaseEntity
    {
        public int FormId { get; set; }
        public Form Form { get; set; }
        public int QuestionId { get; set; }
        public Question Question { get; set; }
    }

    public class TextAnswer : Answer
    {
        public string? TextAnswerValue { get; set; }
    }

    public class IntegerAnswer : Answer
    {
        public long? IntegerAnswerValue { get; set; }
    }

    public class CheckboxAnswer : Answer
    {
        public bool? CheckboxAnswerValue { get; set; }
    }
    public class DateTimeAnswer : Answer
    {
        public bool? DateTimeAnswerValue { get; set; }
    }
}
