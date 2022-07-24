using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using StudentManagement.Logics;
using StudentManagement.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagement.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Home()
        {
            string sid = HttpContext.Session.GetString("userid");
            if ( sid == null)
            {
                return View("/Views/Home.cshtml");
            }
            else
            {
                StudentLogic sl = new StudentLogic();
                Student s = sl.getStudentById(sid);
                ViewBag.User = s;
                return View("/Views/Home.cshtml");
            }
            
        }
        public IActionResult Login(string? suc)
        {
            if (suc != null) ViewBag.Suc = suc;
            return View("/Views/Login.cshtml");
        }
        public IActionResult Register(string? suc)
        {
            MajorLogic ml = new MajorLogic();
            ClassLogic cl = new ClassLogic();
            List<Major> majors = ml.getAll();
            List<Class> classes = cl.getAll();
            ViewBag.Major = majors;
            ViewBag.Class = classes;
            if (suc != null) ViewBag.Suc = suc;
            return View("/Views/Register.cshtml");
        }
        [HttpPost]
        public IActionResult Logins(string id, string password)
        {
            string suc = null; 
            StudentLogic sl = new StudentLogic();
            Student s = sl.checkUser(id,password);
            if (s != null)
            {
                HttpContext.Session.SetString("userid", s.StudentId);
                ViewBag.User = s;
                return RedirectToAction("home");
            }
            else
            {
                suc = "StudentId or password invalid!";
                return RedirectToAction("login", new { suc = suc });
            }
        }
        public IActionResult Logout()
        {
            HttpContext.Session.SetString("userid", "0");
            ViewBag.User = 0;
            return RedirectToAction("login");
        }
        [HttpPost]
        public IActionResult Registers(string name, string password, string address, int inlineRadioOptions, string dob, string phone, string major, int classid,string submit)
        {
            string suc = null;
            if (!submit.Equals("submit") || inlineRadioOptions == 0)
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
                return RedirectToAction("register", new { suc = suc });
            }
            else
            {
                StudentLogic sl = new StudentLogic();
                string stid= "";
                int sid, max = 0;
                List<Student> list = sl.getAll();
                List<int> listsid = new List<int>();
                foreach(Student s in list)
                {
                    sid = Convert.ToInt32( s.StudentId.Substring(2, 6));
                    listsid.Add(sid);
                }
                for (int i = 0; i < listsid.Count; i++)
                {
                    if (max < listsid[i])
                        max = listsid[i];
                }
                stid = major + (max+1).ToString();
                int? classids;
                if (classid == 0) classids = null;
                else classids = classid;
                string majorid = null;
                if (!major.Equals("0")) majorid = major;
                Student student = new Student(stid, name, password, null, DateTime.ParseExact(dob, "MM/dd/yyyy", null), phone, address, classids, majorid, 1, inlineRadioOptions);
                sl.insertUser(student);
                suc = "Registration successfully!";
                return RedirectToAction("register", new {suc = suc });
            }
        }
        public IActionResult UserProfile(string? suc)
        {
            string sid = HttpContext.Session.GetString("userid");
            StudentLogic sl = new StudentLogic();
            Student s = sl.getStudentById(sid);
            DateTime d = (DateTime)s.StudentDob;
            string date = d.ToString("MM/dd/yyyy");
            MajorLogic ml = new MajorLogic();
            ClassLogic cl = new ClassLogic();
            List<Major> majors = ml.getAll();
            List<Class> classes = cl.getAll();
            ViewBag.Major = majors;
            ViewBag.Class = classes;
            ViewBag.Date = date;
            ViewBag.User = s;
            if (suc != null) ViewBag.Suc = suc;
            return View("/Views/UserProfile.cshtml");
        }
        [HttpPost]
        public IActionResult UpdateProfile(string name, string password, string address, int inlineRadioOptions, string dob, string phone, string major, int classid, string submit)
        {
            string suc = null;
            string sid = HttpContext.Session.GetString("userid");
            if (!submit.Equals("submit"))
            {
                return RedirectToAction("userprofile");
            }
            else
            {
                StudentLogic sl = new StudentLogic();
                Student student = new Student(sid, name, password, null, DateTime.ParseExact(dob, "MM/dd/yyyy", null), phone, address, classid, major, 1, inlineRadioOptions);
                sl.updateUser(student);
                suc = "Update user profile successfully!";
                return RedirectToAction("userprofile", new { suc = suc });
            }
        }

        public IActionResult ChangePassword(string? suc)
        {          
            string sid = HttpContext.Session.GetString("userid");
            StudentLogic sl = new StudentLogic();
            Student s = sl.getStudentById(sid);
            ViewBag.User = s;
            if (suc != null) ViewBag.Suc = suc;
            return View("/Views/ChangePassword.cshtml");
        }
        [HttpPost]
        public IActionResult ChangePasswords(string oldpassword, string newpassword, string confirmpassword)
        {
            string suc = null;
            string sid = HttpContext.Session.GetString("userid");
            StudentLogic sl = new StudentLogic();
            Student s = sl.getStudentById(sid);
            //suc = s.Password+"-" + oldpassword;
            //return RedirectToAction("changepassword", new { suc = suc });
            if (!oldpassword.Equals(s.Password))
            {
                suc = "Old password invalid!";
                return RedirectToAction("changepassword", new { suc = suc });
            }
            else if (!newpassword.Equals(confirmpassword))
            {
                suc = "Confirm password invalid!";
                return RedirectToAction("changepassword", new { suc = suc });
            }
            else
            {
                sl.changePassword(sid,newpassword);
                suc = "Change password successfully!";
                return RedirectToAction("changepassword", new { suc = suc });
            }          
        }
        public IActionResult ChangeClass(string? suc)
        {
            string sid = HttpContext.Session.GetString("userid");
            StudentLogic sl = new StudentLogic();
            Student s = sl.getStudentById(sid);
            ClassLogic cl = new ClassLogic();
            List<Class> classes = cl.getListClassByMId(s.MajorId);
            ViewBag.Class = classes;
            ViewBag.User = s;
            if (suc != null) ViewBag.Suc = suc;
            return View("/Views/SClass.cshtml");
        }
        [HttpPost]
        public IActionResult ChangeClasss(int classid)
        {
            string suc = null;
            string sid = HttpContext.Session.GetString("userid");
            StudentLogic sl = new StudentLogic();
            Student s = sl.getStudentById(sid);
            s.ClassId = classid;
            sl.updateUser(s);
            suc = "Change class successfully!";          
            if (suc != null) ViewBag.Suc = suc;
            return RedirectToAction("changeclass", new { suc = suc });
        }
        public IActionResult RegisterClass(string? suc)
        {
            string sid = HttpContext.Session.GetString("userid");
            StudentLogic sl = new StudentLogic();
            Student s = sl.getStudentById(sid);
            ClassLogic cl = new ClassLogic();
            List<Class> classes = cl.getListClassByMId(s.MajorId);
            ViewBag.Class = classes;
            ViewBag.User = s;
            ViewBag.Register = "register";
            if (suc != null) ViewBag.Suc = suc;
            return View("/Views/RSClass.cshtml");
        }
        [HttpPost]
        public IActionResult RegisterClasss(int classid)
        {
            string suc = null;
            string sid = HttpContext.Session.GetString("userid");
            StudentLogic sl = new StudentLogic();
            Student s = sl.getStudentById(sid);
            s.ClassId = classid;
            sl.updateUser(s);
            suc = "Change class successfully!";
            if (suc != null) ViewBag.Suc = suc;
            return RedirectToAction("registerclass", new { suc = suc });
        }
        public IActionResult ChangeMajor(string? suc)
        {
            string sid = HttpContext.Session.GetString("userid");
            StudentLogic sl = new StudentLogic();
            Student s = sl.getStudentById(sid);
            MajorLogic ml = new MajorLogic();
            List<Major> majors = ml.getAll();
            ViewBag.Major = majors;
            ViewBag.User = s;
            if (suc != null) ViewBag.Suc = suc;
            return View("/Views/SMajor.cshtml");
        }
        [HttpPost]
        public IActionResult ChangeMajors(string major)
        {
            string suc = null;
            string sid = HttpContext.Session.GetString("userid");
            StudentLogic sl = new StudentLogic();
            Student s = sl.getStudentById(sid);
            s.MajorId = major;
            s.ClassId = null;
            sl.updateUser(s);
            suc = "Change class successfully!";
            if (suc != null) ViewBag.Suc = suc;
            return RedirectToAction("changemajor", new { suc = suc });
        }
        public IActionResult RegisterMajor(string? suc)
        {
            string sid = HttpContext.Session.GetString("userid");
            StudentLogic sl = new StudentLogic();
            Student s = sl.getStudentById(sid);
            MajorLogic ml = new MajorLogic();
            List<Major> majors = ml.getAll();
            ViewBag.Major = majors;
            ViewBag.User = s;
            ViewBag.Register = "register";
            if (suc != null) ViewBag.Suc = suc;
            return View("/Views/RSMajor.cshtml");
        }
        public IActionResult RegisterMajors(string major)
        {
            string suc = null;
            string sid = HttpContext.Session.GetString("userid");
            StudentLogic sl = new StudentLogic();
            Student s = sl.getStudentById(sid);
            s.MajorId = major;
            s.ClassId = null;
            sl.updateUser(s);
            suc = "Change class successfully!";
            if (suc != null) ViewBag.Suc = suc;
            return RedirectToAction("registermajor", new { suc = suc });
        }
        
    }
}
