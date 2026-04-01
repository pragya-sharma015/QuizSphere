using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace QuizSphere.Models
{
    public partial class Users
    {
        [Key]
        public long UserId { get; set; }
        public string? UserName { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public string? Role { get; set; }
        public long? DepartmentId { get; set; }
    }
}
