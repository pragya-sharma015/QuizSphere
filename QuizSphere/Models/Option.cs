using System;
using System.Collections.Generic;

namespace QuizSphere.Models
{
    public partial class Option
    {
        public long OptionId { get; set; }
        public long? QuestionId { get; set; }
        public string? Text { get; set; }
        public bool? IsCorrect { get; set; }
    }
}
