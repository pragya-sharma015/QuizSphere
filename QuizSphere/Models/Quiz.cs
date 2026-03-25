using System;
using System.Collections.Generic;

namespace QuizSphere.Models
{
    public partial class Quiz
    {
        public long QuizzesId { get; set; }
        public string? Title { get; set; }
        public long? TeacherId { get; set; }
        public long? DepartmentId { get; set; }
        public int? TimeLimit { get; set; }
        public DateTime? EndTime { get; set; }
        public DateTime? StartTime { get; set; }
    }
}
