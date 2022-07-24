using StudentManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagement.Logics
{
    public class StudentLogic
    {
        StudentManagementContext SContext;

        public StudentLogic()
        {
            SContext = new StudentManagementContext();
        }

        public List<Student> getAll()
        {
            return SContext.Students.ToList();
        }
        public Student getStudentById(string id)
        {
            return SContext.Students.FirstOrDefault(x => x.StudentId.Equals(id));
        }
        public Student checkUser(string id, string password)
        {
            return SContext.Students.FirstOrDefault(x => x.StudentId.Equals(id) && x.Password.Equals(password));
        }
        public int insertUser(Student s)
        {
            SContext.Students.Add(s);
            return SContext.SaveChanges();
        }
        public int updateUser(Student s)
        {
            SContext.Students.Update(s);
            return SContext.SaveChanges();
        }
        public int changePassword(string sid, string newpass)
        {
            Student x = SContext.Students.FirstOrDefault(x => x.StudentId.Equals(sid));
            x.Password = newpass;
            return SContext.SaveChanges();
        }
        public Student checkClass(int cid)
        {
            return SContext.Students.FirstOrDefault(x => x.ClassId == cid);
        }
        public Student checkMajor(string mid)
        {
            return SContext.Students.FirstOrDefault(x => x.MajorId.Equals(mid));
        }
        public List<Student> getListStudentByname(string name)
        {
            return SContext.Students.Where(x => x.StudentName.ToLower().Contains(name.ToLower())).ToList();
        }
        public List<Student> getListStudentByThree(string? mid,int? cid,int? gid)
        {
            List<Student> list = new List<Student>();      
            List<Student> list2 = new List<Student>();
            List<Student> list3 = new List<Student>();
            List<Student> list4 = new List<Student>();

                list = SContext.Students.ToList();

            if (mid != null)
            {
                
                    //list2 = list.Where(x => x.MajorId.Equals(mid)).ToList();
                
            }
            else { list2 = list; }
            
            
            if (cid != null)
            {

                    list3 = list2.Where(x => x.ClassId == cid).ToList();

            }
            else { list3 = list2; }
                
                
            if (gid != null)
            {
                list4 = list3.Where(x => x.GenderId == gid).ToList();
            }
            else { list4 = list3; }
                
            return list4;
                
        }
    }
}
