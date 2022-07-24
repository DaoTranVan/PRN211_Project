using System;
using System.Collections.Generic;

#nullable disable

namespace StudentManagement.Models
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

        public Student()
        {
        }


        public Student(string studentId, string studentName, string password, string studentImg, DateTime? studentDob, string studentPhone, string studentAddress, int? classId, string majorId, int? roleId, int? genderId)
        {
            StudentId = studentId;
            StudentName = studentName;
            Password = password;
            StudentImg = studentImg;
            StudentDob = studentDob;
            StudentPhone = studentPhone;
            StudentAddress = studentAddress;
            ClassId = classId;
            MajorId = majorId;
            RoleId = roleId;
            GenderId = genderId;
        }

        public virtual Class Class { get; set; }
        public virtual Gender Gender { get; set; }
        public virtual Major Major { get; set; }
        public virtual Role Role { get; set; }
    }
}
