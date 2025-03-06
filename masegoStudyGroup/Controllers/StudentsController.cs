using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace masegoStudyGroup.Controllers
{
    public class StudentsController : Controller
    {
        // GET: Students
        public ActionResult ListStudents()
        {
            List<Models.StudentModel> students = new List<Models.StudentModel>();

            students.Add(new Models.StudentModel { StudentNumber = "u18221166", Name = "Masego", Surname = "Mahlangu", EmailAddress = "mc.mahlangu@tuks.co.za" });
            students.Add(new Models.StudentModel { StudentNumber = "u21523516", Name = "Lesego", Surname = "Booi", EmailAddress = "lc.booi@tuks.co.za" });
            students.Add(new Models.StudentModel { StudentNumber = "u22125364", Name = "Christopher", Surname = "Ditsehgo", EmailAddress = "ch.ditshego@tuks.co.za" });
            students.Add(new Models.StudentModel { StudentNumber = "u27215364", Name = "Harry", Surname = "Styles", EmailAddress = "ht.styles@tuks.co.za" });
            students.Add(new Models.StudentModel { StudentNumber = "u27351624", Name = "Taylor", Surname = "Swift", EmailAddress = "ts.swift@tuks.co.za" });

            return View(students);
        }
    }
}