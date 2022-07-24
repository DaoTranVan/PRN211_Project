using StudentManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagement.Logics
{
    public class ClassLogic
    {
        StudentManagementContext SContext;

        public ClassLogic()
        {
            SContext = new StudentManagementContext();
        }
        public List<Class> getAll()
        {
            return SContext.Classes.ToList();
        }
        public List<Class> getListClassByMId(string mid)
        {
            return SContext.Classes.Where(x => x.MajorId.Equals(mid)).ToList();
        }
        public Class getClassById(int id)
        {
            return SContext.Classes.FirstOrDefault(x => x.ClassId == id);
        }
        public int deleteClass(Class c)
        {
            SContext.Classes.Remove(c);
            return SContext.SaveChanges();
        }
        public int insertClass(Class c)
        {
            SContext.Classes.Add(c);
            return SContext.SaveChanges();
        }
        public Class checkMajorC(string mid)
        {
            return SContext.Classes.FirstOrDefault(x => x.MajorId.Equals(mid));
        }
    }
}
