using System;
using System.Collections.Generic;

namespace QuizSphere.Models
{
    public partial class Attempt
    {
        public long AttemptsId { get; set; }
        public long? StudentId { get; set; }
        public long? QuizId { get; set; }
        public string? Score { get; set; }
        public DateTime? SubmittedAt { get; set; }
    }
}
