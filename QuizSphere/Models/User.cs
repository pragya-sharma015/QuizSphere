using System;
using System.Collections.Generic;

namespace QuizSphere.Models
{
    public partial class User
    {
        public long UserId { get; set; }
        public string? UserName { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public string? Role { get; set; }
        public long? DepartmentId { get; set; }
    }
}
