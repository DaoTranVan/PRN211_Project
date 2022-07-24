using StudentManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagement.Logics
{
    public class MajorLogic
    {
        StudentManagementContext SContext;

        public MajorLogic()
        {
            SContext = new StudentManagementContext();
        }
        public List<Major> getAll()
        {
            return SContext.Majors.ToList();
        }
        public Major getMajorById(string id)
        {
            return SContext.Majors.FirstOrDefault(x => x.MajorId.Equals(id));
        }
        public int deleteMajor(Major m)
        {
            SContext.Majors.Remove(m);
            return SContext.SaveChanges();
        }
        public int insertMajor(Major m)
        {
            SContext.Majors.Add(m);
            return SContext.SaveChanges();
        }
        public Major checkMajor(string id)
        {
            return SContext.Majors.FirstOrDefault(x => x.MajorId.Equals(id));
        }
        public int updateMajor(Major m)
        {
            SContext.Majors.Update(m);
            return SContext.SaveChanges();
        }

    }
}
