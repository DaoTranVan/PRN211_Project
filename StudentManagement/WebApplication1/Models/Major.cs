using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication1.Models
{
    public partial class Major
    {
        public Major()
        {
            Classes = new HashSet<Class>();
            Students = new HashSet<Student>();
        }

        public string MajorId { get; set; }
        public string MajorName { get; set; }
        public string MajorDesc { get; set; }

        public virtual ICollection<Class> Classes { get; set; }
        public virtual ICollection<Student> Students { get; set; }
    }
}
