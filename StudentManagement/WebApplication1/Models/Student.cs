using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication1.Models
{
    public partial class Student
    {
        public string StudentId { get; set; }
        public string StudentName { get; set; }
        public string Password { get; set; }
        public string StudentImg { get; set; }
        public DateTime? StudentDob { get; set; }
        public string StudentPhone { get; set; }
        public string StudentAddress { get; set; }
        public int? ClassId { get; set; }
        public string MajorId { get; set; }
        public int? RoleId { get; set; }
        public int? GenderId { get; set; }

        public virtual Class Class { get; set; }
        public virtual Gender Gender { get; set; }
        public virtual Major Major { get; set; }
        public virtual Role Role { get; set; }
    }
}
