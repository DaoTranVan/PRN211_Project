using System;
using System.Collections.Generic;

#nullable disable

namespace StudentManagement.Models
{
    public partial class Class
    {
        public Class()
        {
            Students = new HashSet<Student>();
        }

        public Class(int classId, string className, string classDesc, string majorId)
        {
            ClassId = classId;
            ClassName = className;
            ClassDesc = classDesc;
            MajorId = majorId;
        }

        public int ClassId { get; set; }
        public string ClassName { get; set; }
        public string ClassDesc { get; set; }
        public string MajorId { get; set; }

        public virtual Major Major { get; set; }
        public virtual ICollection<Student> Students { get; set; }
    }
}
