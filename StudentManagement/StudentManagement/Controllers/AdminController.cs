using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentManagement.Logics;
using StudentManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagement.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Home()
        {
            string sid = HttpContext.Session.GetString("userid");
            StudentLogic sl = new StudentLogic();
            Student s = sl.getStudentById(sid);
            ViewBag.User = s;
            return View("/Views/Home.cshtml");
        }
        public IActionResult StudentList()
        {
            StudentLogic sl = new StudentLogic();
            MajorLogic ml = new MajorLogic();
            ClassLogic cl = new ClassLogic();
            List<Student> students = sl.getAll();
            List<Major> majors = ml.getAll();
            List<Class> classes = cl.getAll();
            ViewBag.MList = majors;
            ViewBag.CList = classes;
            ViewBag.SList = students;
            return View("/Views/StudentList.cshtml");
        }
        [HttpPost]
        public IActionResult StudentLists(string search)
        {

            StudentLogic sl = new StudentLogic();
            MajorLogic ml = new MajorLogic();
            ClassLogic cl = new ClassLogic();
            if (search != null)
            {
                List<Student> students = sl.getListStudentByname(search);
                ViewBag.SList = students;
            }

            else
            {
                List<Student> students = sl.getAll();
                ViewBag.SList = students;
            }
            List<Major> majors = ml.getAll();
            List<Class> classes = cl.getAll();
            ViewBag.MList = majors;
            ViewBag.CList = classes;
            
            if(search!=null)ViewBag.Search = search;
            return View("/Views/StudentList.cshtml");
        }
        public IActionResult EditStudent(string status, string? suc)
        {
            StudentLogic sl = new StudentLogic();
            Student s = sl.getStudentById(status);
            ViewBag.User = s;
            MajorLogic ml = new MajorLogic();
            ClassLogic cl = new ClassLogic();
            List<Major> majors = ml.getAll();
            List<Class> classes = cl.getListClassByMId(s.MajorId);
            DateTime d = (DateTime)s.StudentDob;
            string date = d.ToString("MM/dd/yyyy");
            ViewBag.Date = date;
            ViewBag.Major = majors;
            ViewBag.Class = classes;
            if (suc != null) ViewBag.Suc = suc;
            return View("/Views/EditStudent.cshtml");
        }
        [HttpPost] 
        public IActionResult EditStudents(string sid, string name, string password, string address, int inlineRadioOptions, string dob, string phone, string major, int classid, string submit)
        {
            string suc = null;
            
            if (!submit.Equals("submit"))
            {
                return RedirectToAction("editstudent", new { status =  sid});
            }
            else
            {
                StudentLogic sl = new StudentLogic();
                int? classids;
                if (classid == 0) classids = null;
                else classids = classid;
                Student student = new Student(sid, name, password, null, DateTime.ParseExact(dob, "MM/dd/yyyy", null), phone, address, classids, major, 1, inlineRadioOptions);
                sl.updateUser(student);
                suc = "Update student detail successfully!";
                return RedirectToAction("editstudent", new { status = sid, suc = suc });
            }
        }
        public IActionResult NewStudent(string? suc)
        {
            MajorLogic ml = new MajorLogic();
            ClassLogic cl = new ClassLogic();
            List<Major> majors = ml.getAll();
            List<Class> classes = cl.getAll();
            ViewBag.Major = majors;
            ViewBag.Class = classes;
            if (suc != null) ViewBag.Suc = suc;
            return View("/Views/NewStudent.cshtml");
        }
        [HttpPost]
        public IActionResult NewStudents(string name, string password, string address, int inlineRadioOptions, string dob, string phone, string major, int classid, string submit)
        {
            string suc = null;
            if (!submit.Equals("submit")  || inlineRadioOptions == 0)
            {
                MajorLogic ml = new MajorLogic();
                ClassLogic cl = new ClassLogic();
                List<Major> majors = ml.getAll();
                List<Class> classes = cl.getAll();
                if (!major.Equals("0"))
                {
                    classes = cl.getListClassByMId(major);
                }
                ViewBag.MajorSelect = major;
                ViewBag.ClassSelect = classid;
                ViewBag.Major = majors;
                ViewBag.Class = classes;
                suc = "No gender selected!";
                if (suc != null) ViewBag.Suc = suc;
                return RedirectToAction("newstudent", new { suc = suc });
            }
            else
            {
                StudentLogic sl = new StudentLogic();
                string stid = "";
                int sid, max = 0;
                List<Student> list = sl.getAll();
                List<int> listsid = new List<int>();
                foreach (Student s in list)
                {
                    sid = Convert.ToInt32(s.StudentId.Substring(2, 6));
                    listsid.Add(sid);
                }
                for (int i = 0; i < listsid.Count; i++)
                {
                    if (max < listsid[i])
                        max = listsid[i];
                }
                stid = major + (max + 1).ToString();
                int? classids;
                if (classid == 0) classids = null;
                else classids = classid;
                string majorid = null;
                if (!major.Equals("0")) majorid = major;
                Student student = new Student(stid, name, password, null, DateTime.ParseExact(dob, "MM/dd/yyyy", null), phone, address, classids, majorid, 1, inlineRadioOptions);
                sl.insertUser(student);
                suc = "Add new Student successfully!";
                return RedirectToAction("newstudent", new { suc = suc });
            }
        }
        public IActionResult ClassList(string? suc)
        {
            MajorLogic ml = new MajorLogic();
            ClassLogic cl = new ClassLogic();
            List<Major> majors = ml.getAll();
            List<Class> classes = cl.getAll();
            ViewBag.MList = majors;
            ViewBag.CList = classes;
            if (suc != null) ViewBag.Suc = suc;
            return View("/Views/ClassList.cshtml");
        }
        public IActionResult DeleteClass(int status)
        {
            string suc = null;
            StudentLogic sl = new StudentLogic();
            Student s = sl.checkClass(status);
            if (s != null)
            {
                suc = "Class has students, cannot be deleted";
                return RedirectToAction("classlist", new { suc = suc });
            }
            else
            {
                ClassLogic cl = new ClassLogic();
                Class c = cl.getClassById(status);
                cl.deleteClass(c);
                suc = "delete Class successfully!";
                return RedirectToAction("classlist", new { suc = suc });
            }
            
        }
        public IActionResult NewClass(string? suc)
        {
            MajorLogic ml = new MajorLogic();
            List<Major> majors = ml.getAll();
            ViewBag.MList = majors;
            if (suc != null) ViewBag.Suc = suc;
            return View("/Views/NewClass.cshtml");
        }
        [HttpPost]
        public IActionResult NewClasss(string major)
        {
            string suc = null;
            ClassLogic cl = new ClassLogic();
            string classname = "";
            int sid, max = 0;
            List<Class> list = cl.getAll();
            List<int> listsid = new List<int>();
            foreach (Class s in list)
            {
                sid = Convert.ToInt32(s.ClassName.Substring(2, 5));
                listsid.Add(sid);
            }
            for (int i = 0; i < listsid.Count; i++)
            {
                if (max < listsid[i])
                    max = listsid[i];
            }
            classname = major + (max+1).ToString();
            Class c = new Class(0, classname, null, major);
            cl.insertClass(c);
            suc = "Add new Class successfully!";
            return RedirectToAction("classlist", new { suc = suc });
        }
        public IActionResult MajorList(string? suc)
        {
            MajorLogic ml = new MajorLogic();
            List<Major> majors = ml.getAll();
            ViewBag.MList = majors;
            if (suc != null) ViewBag.Suc = suc;
            return View("/Views/MajorList.cshtml");
        }
        public IActionResult DeleteMajor(string status)
        {
            string suc = null;
            StudentLogic sl = new StudentLogic();
            Student s = sl.checkMajor(status);
            ClassLogic cl = new ClassLogic();
            Class c = cl.checkMajorC(status);
            if (s != null || c != null)
            {
                suc = "Major has class or students , cannot be deleted";
                return RedirectToAction("majorlist", new { suc = suc });
            }
            else
            {
                MajorLogic ml = new MajorLogic();
                Major m = ml.getMajorById(status);
                ml.deleteMajor(m);
                suc = "delete Major successfully!";
                return RedirectToAction("majorlist", new { suc = suc });
            }

        }
        public IActionResult NewMajor(string? suc)
        {
            if (suc != null) ViewBag.Suc = suc;
            return View("/Views/NewMajor.cshtml");
        }
        [HttpPost]
        public IActionResult NewMajors(string mid, string name, string desc)
        {
            string suc = null;
            MajorLogic ml = new MajorLogic();
            Major m = ml.checkMajor(mid);
            if (m != null)
            {
                suc = "MajorId already exists!";
                return RedirectToAction("newmajor", new { suc = suc });
            }
            else
            {
                Major major = new Major(mid, name, desc);
                ml.insertMajor(major);
                suc = "Add new Major successfully!";
                return RedirectToAction("newmajor", new { suc = suc });
            }
        }
        public IActionResult UpdateMajor(string status, string? suc)
        {
            MajorLogic ml = new MajorLogic();
            Major m = ml.getMajorById(status);
            ViewBag.Majors = m;
            if (suc != null) ViewBag.Suc = suc;
            return View("/Views/UpdateMajor.cshtml");
        }
        [HttpPost]
        public IActionResult Updatemajors(string mid, string name, string desc)
        {
            string suc = null;
            MajorLogic ml = new MajorLogic();
            Major major = new Major(mid, name, desc);
            ml.updateMajor(major);
            suc = "Update Major successfully!";
            return RedirectToAction("updatemajor", new { suc = suc });
        }
        
    }
}
