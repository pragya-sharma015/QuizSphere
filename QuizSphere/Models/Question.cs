using System;
using System.Collections.Generic;

namespace QuizSphere.Models
{
    public partial class Question
    {
        public long QuestionsId { get; set; }
        public long? QuizId { get; set; }
        public string? Text { get; set; }
    }
}
