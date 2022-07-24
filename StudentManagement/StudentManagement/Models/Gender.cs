using System;
using System.Collections.Generic;

#nullable disable

namespace StudentManagement.Models
{
    public partial class Gender
    {
        public Gender()
        {
            Students = new HashSet<Student>();
        }

        public int GenderId { get; set; }
        public string GenderName { get; set; }

        public virtual ICollection<Student> Students { get; set; }
    }
}
