using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication1.Models
{
    public partial class Role
    {
        public Role()
        {
            Students = new HashSet<Student>();
        }

        public int RoleId { get; set; }
        public string RoleName { get; set; }

        public virtual ICollection<Student> Students { get; set; }
    }
}
