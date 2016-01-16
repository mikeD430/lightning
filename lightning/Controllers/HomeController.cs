using lightning.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace lightning.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private SubjectTrackingDB db = new SubjectTrackingDB();
        private DateTime yesterday = DateTime.Now.Date.AddDays(-1);
        private DateTime lastweek = DateTime.Now.Date.AddDays(-7);
        private string subject;
        private string username;
        

        public ActionResult Index()
        {
            SetViewSubjectItems();
            return View();
        }

        public ActionResult Summary()
        {
            SetViewSubjectItems();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult DetailSummary()
        {
            ViewBag.Message = "Detail Summary";
            SetViewSubjectItems();
            return View(db.Subjects.ToList());
        }

        private void SetViewSubjectItems()
        {
            username = User.Identity.GetUserName();
            if (db.Subjects.Where(t => t.Title == "Biology").Count() > 0)
            {
                subject = "Biology";
                ViewBag.CountBiology = db.Subjects.Where(t => t.Title == subject && t.UserName == username).Count().ToString();
                ViewBag.CountBiologyComplete1 = db.Subjects.Where(t => t.Title == subject && t.complete1 == true && t.UserName == username).Count().ToString();
                ViewBag.CountBiologyComplete1Yesterday = db.Subjects.Where(t => t.Title == subject && t.complete1 == true && t.ModifiedDate >= yesterday && t.UserName == username).Count().ToString();
                ViewBag.CountBiologyComplete1Lastweek = db.Subjects.Where(t => t.Title == subject && t.complete1 == true && t.ModifiedDate >= lastweek && t.UserName == username).Count().ToString();
                ViewBag.CountBiologyComplete2 = db.Subjects.Where(t => t.Title == subject && t.complete2 == true && t.UserName == username).Count().ToString();
                ViewBag.CountBiologyComplete2Yesterday = db.Subjects.Where(t => t.Title == subject && t.complete2 == true && t.ModifiedDate >= yesterday && t.UserName == username).Count().ToString();
                ViewBag.CountBiologyComplete2Lastweek = db.Subjects.Where(t => t.Title == subject && t.complete2 == true && t.ModifiedDate >= lastweek && t.UserName == username).Count().ToString();
                ViewBag.CountBiologyComplete3 = db.Subjects.Where(t => t.Title == subject && t.complete3 == true && t.UserName == username).Count().ToString();
                ViewBag.CountBiologyComplete3Yesterday = db.Subjects.Where(t => t.Title == subject && t.complete3 == true && t.ModifiedDate >= yesterday && t.UserName == username).Count().ToString();
                ViewBag.CountBiologyComplete3Lastweek = db.Subjects.Where(t => t.Title == subject && t.complete3 == true && t.ModifiedDate >= lastweek && t.UserName == username).Count().ToString();
                ViewBag.CountBiologyComplete4 = db.Subjects.Where(t => t.Title == subject && t.complete4 == true && t.UserName == username).Count().ToString();
                ViewBag.CountBiologyComplete4Yesterday = db.Subjects.Where(t => t.Title == subject && t.complete4 == true && t.ModifiedDate >= yesterday && t.UserName == username).Count().ToString();
                ViewBag.CountBiologyComplete4Lastweek = db.Subjects.Where(t => t.Title == subject && t.complete4 == true && t.ModifiedDate >= lastweek && t.UserName == username).Count().ToString();
                ViewBag.CountBiologyComplete5 = db.Subjects.Where(t => t.Title == subject && t.complete5 == true && t.UserName == username).Count().ToString();
                ViewBag.CountBiologyComplete5Yesterday = db.Subjects.Where(t => t.Title == subject && t.complete5 == true && t.ModifiedDate >= yesterday && t.UserName == username).Count().ToString();
                ViewBag.CountBiologyComplete5Lastweek = db.Subjects.Where(t => t.Title == subject && t.complete5 == true && t.ModifiedDate >= lastweek && t.UserName == username).Count().ToString();
                ViewBag.CountBiologyComplete6 = db.Subjects.Where(t => t.Title == subject && t.complete6 == true && t.UserName == username).Count().ToString();
                ViewBag.CountBiologyComplete6Yesterday = db.Subjects.Where(t => t.Title == subject && t.complete6 == true && t.ModifiedDate >= yesterday && t.UserName == username).Count().ToString();
                ViewBag.CountBiologyComplete6Lastweek = db.Subjects.Where(t => t.Title == subject && t.complete6 == true && t.ModifiedDate >= lastweek && t.UserName == username).Count().ToString();
            }
            if (db.Subjects.Where(t => t.Title == "Chemistry").Count() > 0)
            {
                subject = "Chemistry";
                ViewBag.CountChemistry = db.Subjects.Where(t => t.Title == subject && t.UserName == username).Count().ToString();
                ViewBag.CountChemistryComplete1 = db.Subjects.Where(t => t.Title == subject && t.complete1 == true && t.UserName == username).Count().ToString();
                ViewBag.CountChemistryComplete1Yesterday = db.Subjects.Where(t => t.Title == subject && t.complete1 == true && t.ModifiedDate >= yesterday && t.UserName == username).Count().ToString();
                ViewBag.CountChemistryComplete1Lastweek = db.Subjects.Where(t => t.Title == subject && t.complete1 == true && t.ModifiedDate >= lastweek && t.UserName == username).Count().ToString();
                ViewBag.CountChemistryComplete2 = db.Subjects.Where(t => t.Title == subject && t.complete2 == true && t.UserName == username).Count().ToString();
                ViewBag.CountChemistryComplete2Yesterday = db.Subjects.Where(t => t.Title == subject && t.complete2 == true && t.ModifiedDate >= yesterday && t.UserName == username).Count().ToString();
                ViewBag.CountChemistryComplete2Lastweek = db.Subjects.Where(t => t.Title == subject && t.complete2 == true && t.ModifiedDate >= lastweek && t.UserName == username).Count().ToString();
                ViewBag.CountChemistryComplete3 = db.Subjects.Where(t => t.Title == subject && t.complete3 == true && t.UserName == username).Count().ToString();
                ViewBag.CountChemistryComplete3Yesterday = db.Subjects.Where(t => t.Title == subject && t.complete3 == true && t.ModifiedDate >= yesterday && t.UserName == username).Count().ToString();
                ViewBag.CountChemistryComplete3Lastweek = db.Subjects.Where(t => t.Title == subject && t.complete3 == true && t.ModifiedDate >= lastweek && t.UserName == username).Count().ToString();
                ViewBag.CountChemistryComplete4 = db.Subjects.Where(t => t.Title == subject && t.complete4 == true && t.UserName == username).Count().ToString();
                ViewBag.CountChemistryComplete4Yesterday = db.Subjects.Where(t => t.Title == subject && t.complete4 == true && t.ModifiedDate >= yesterday && t.UserName == username).Count().ToString();
                ViewBag.CountChemistryComplete4Lastweek = db.Subjects.Where(t => t.Title == subject && t.complete4 == true && t.ModifiedDate >= lastweek && t.UserName == username).Count().ToString();
                ViewBag.CountChemistryComplete5 = db.Subjects.Where(t => t.Title == subject && t.complete5 == true && t.UserName == username).Count().ToString();
                ViewBag.CountChemistryComplete5Yesterday = db.Subjects.Where(t => t.Title == subject && t.complete5 == true && t.ModifiedDate >= yesterday && t.UserName == username).Count().ToString();
                ViewBag.CountChemistryComplete5Lastweek = db.Subjects.Where(t => t.Title == subject && t.complete5 == true && t.ModifiedDate >= lastweek && t.UserName == username).Count().ToString();
                ViewBag.CountChemistryComplete6 = db.Subjects.Where(t => t.Title == subject && t.complete6 == true && t.UserName == username).Count().ToString();
                ViewBag.CountChemistryComplete6Yesterday = db.Subjects.Where(t => t.Title == subject && t.complete6 == true && t.ModifiedDate >= yesterday && t.UserName == username).Count().ToString();
                ViewBag.CountChemistryComplete6Lastweek = db.Subjects.Where(t => t.Title == subject && t.complete6 == true && t.ModifiedDate >= lastweek && t.UserName == username).Count().ToString();
            }
            if (db.Subjects.Where(t => t.Title == "Maths").Count() > 0)
            {
                subject = "Maths";
                ViewBag.CountMaths = db.Subjects.Where(t => t.Title == subject && t.UserName == username).Count().ToString();
                ViewBag.CountMathsComplete1 = db.Subjects.Where(t => t.Title == subject && t.complete1 == true && t.UserName == username).Count().ToString();
                ViewBag.CountMathsComplete1Yesterday = db.Subjects.Where(t => t.Title == subject && t.complete1 == true && t.ModifiedDate >= yesterday && t.UserName == username).Count().ToString();
                ViewBag.CountMathsComplete1Lastweek = db.Subjects.Where(t => t.Title == subject && t.complete1 == true && t.ModifiedDate >= lastweek && t.UserName == username).Count().ToString();
                ViewBag.CountMathsComplete2 = db.Subjects.Where(t => t.Title == subject && t.complete2 == true && t.UserName == username).Count().ToString();
                ViewBag.CountMathsComplete2Yesterday = db.Subjects.Where(t => t.Title == subject && t.complete2 == true && t.ModifiedDate >= yesterday && t.UserName == username).Count().ToString();
                ViewBag.CountMathsComplete2Lastweek = db.Subjects.Where(t => t.Title == subject && t.complete2 == true && t.ModifiedDate >= lastweek && t.UserName == username).Count().ToString();
                ViewBag.CountMathsComplete3 = db.Subjects.Where(t => t.Title == subject && t.complete3 == true && t.UserName == username).Count().ToString();
                ViewBag.CountMathsComplete3Yesterday = db.Subjects.Where(t => t.Title == subject && t.complete3 == true && t.ModifiedDate >= yesterday && t.UserName == username).Count().ToString();
                ViewBag.CountMathsComplete3Lastweek = db.Subjects.Where(t => t.Title == subject && t.complete3 == true && t.ModifiedDate >= lastweek && t.UserName == username).Count().ToString();
                ViewBag.CountMathsComplete4 = db.Subjects.Where(t => t.Title == subject && t.complete4 == true && t.UserName == username).Count().ToString();
                ViewBag.CountMathsComplete4Yesterday = db.Subjects.Where(t => t.Title == subject && t.complete4 == true && t.ModifiedDate >= yesterday && t.UserName == username).Count().ToString();
                ViewBag.CountMathsComplete4Lastweek = db.Subjects.Where(t => t.Title == subject && t.complete4 == true && t.ModifiedDate >= lastweek && t.UserName == username).Count().ToString();
                ViewBag.CountMathsComplete5 = db.Subjects.Where(t => t.Title == subject && t.complete5 == true && t.UserName == username).Count().ToString();
                ViewBag.CountMathsComplete5Yesterday = db.Subjects.Where(t => t.Title == subject && t.complete5 == true && t.ModifiedDate >= yesterday && t.UserName == username).Count().ToString();
                ViewBag.CountMathsComplete5Lastweek = db.Subjects.Where(t => t.Title == subject && t.complete5 == true && t.ModifiedDate >= lastweek && t.UserName == username).Count().ToString();
                ViewBag.CountMathsComplete6 = db.Subjects.Where(t => t.Title == subject && t.complete6 == true && t.UserName == username).Count().ToString();
                ViewBag.CountMathsComplete6Yesterday = db.Subjects.Where(t => t.Title == subject && t.complete6 == true && t.ModifiedDate >= yesterday && t.UserName == username).Count().ToString();
                ViewBag.CountMathsComplete6Lastweek = db.Subjects.Where(t => t.Title == subject && t.complete6 == true && t.ModifiedDate >= lastweek && t.UserName == username).Count().ToString();
            }

            if (db.Subjects.Where(t => t.Title == "PE").Count() > 0)
            {
                subject = "PE";
                ViewBag.CountPE = db.Subjects.Where(t => t.Title == subject && t.UserName == username).Count().ToString();
                ViewBag.CountPEComplete1 = db.Subjects.Where(t => t.Title == subject && t.complete1 == true && t.UserName == username).Count().ToString();
                ViewBag.CountPEComplete1Yesterday = db.Subjects.Where(t => t.Title == subject && t.complete1 == true && t.ModifiedDate >= yesterday && t.UserName == username).Count().ToString();
                ViewBag.CountPEComplete1Lastweek = db.Subjects.Where(t => t.Title == subject && t.complete1 == true && t.ModifiedDate >= lastweek && t.UserName == username).Count().ToString();
                ViewBag.CountPEComplete2 = db.Subjects.Where(t => t.Title == subject && t.complete2 == true && t.UserName == username).Count().ToString();
                ViewBag.CountPEComplete2Yesterday = db.Subjects.Where(t => t.Title == subject && t.complete2 == true && t.ModifiedDate >= yesterday && t.UserName == username).Count().ToString();
                ViewBag.CountPEComplete2Lastweek = db.Subjects.Where(t => t.Title == subject && t.complete2 == true && t.ModifiedDate >= lastweek && t.UserName == username).Count().ToString();
                ViewBag.CountPEComplete3 = db.Subjects.Where(t => t.Title == subject && t.complete3 == true && t.UserName == username).Count().ToString();
                ViewBag.CountPEComplete3Yesterday = db.Subjects.Where(t => t.Title == subject && t.complete3 == true && t.ModifiedDate >= yesterday && t.UserName == username).Count().ToString();
                ViewBag.CountPEComplete3Lastweek = db.Subjects.Where(t => t.Title == subject && t.complete3 == true && t.ModifiedDate >= lastweek && t.UserName == username).Count().ToString();
                ViewBag.CountPEComplete4 = db.Subjects.Where(t => t.Title == subject && t.complete4 == true && t.UserName == username).Count().ToString();
                ViewBag.CountPEComplete4Yesterday = db.Subjects.Where(t => t.Title == subject && t.complete4 == true && t.ModifiedDate >= yesterday && t.UserName == username).Count().ToString();
                ViewBag.CountPEComplete4Lastweek = db.Subjects.Where(t => t.Title == subject && t.complete4 == true && t.ModifiedDate >= lastweek && t.UserName == username).Count().ToString();
                ViewBag.CountPEComplete5 = db.Subjects.Where(t => t.Title == subject && t.complete5 == true && t.UserName == username).Count().ToString();
                ViewBag.CountPEComplete5Yesterday = db.Subjects.Where(t => t.Title == subject && t.complete5 == true && t.ModifiedDate >= yesterday && t.UserName == username).Count().ToString();
                ViewBag.CountPEComplete5Lastweek = db.Subjects.Where(t => t.Title == subject && t.complete5 == true && t.ModifiedDate >= lastweek && t.UserName == username).Count().ToString();
                ViewBag.CountPEComplete6 = db.Subjects.Where(t => t.Title == subject && t.complete6 == true && t.UserName == username).Count().ToString();
                ViewBag.CountPEComplete6Yesterday = db.Subjects.Where(t => t.Title == subject && t.complete6 == true && t.ModifiedDate >= yesterday && t.UserName == username).Count().ToString();
                ViewBag.CountPEComplete6Lastweek = db.Subjects.Where(t => t.Title == subject && t.complete6 == true && t.ModifiedDate >= lastweek && t.UserName == username).Count().ToString();
            }
            if (db.Subjects.Where(t => t.Title == "Physics").Count() > 0)
            {
                subject = "Physics";
                ViewBag.CountPhysics = db.Subjects.Where(t => t.Title == subject && t.UserName == username).Count().ToString();
                ViewBag.CountPhysicsComplete1 = db.Subjects.Where(t => t.Title == subject && t.complete1 == true && t.UserName == username).Count().ToString();
                ViewBag.CountPhysicsComplete1Yesterday = db.Subjects.Where(t => t.Title == subject && t.complete1 == true && t.ModifiedDate >= yesterday && t.UserName == username).Count().ToString();
                ViewBag.CountPhysicsComplete1Lastweek = db.Subjects.Where(t => t.Title == subject && t.complete1 == true && t.ModifiedDate >= lastweek && t.UserName == username).Count().ToString();
                ViewBag.CountPhysicsComplete2 = db.Subjects.Where(t => t.Title == subject && t.complete2 == true && t.UserName == username).Count().ToString();
                ViewBag.CountPhysicsComplete2Yesterday = db.Subjects.Where(t => t.Title == subject && t.complete2 == true && t.ModifiedDate >= yesterday && t.UserName == username).Count().ToString();
                ViewBag.CountPhysicsComplete2Lastweek = db.Subjects.Where(t => t.Title == subject && t.complete2 == true && t.ModifiedDate >= lastweek && t.UserName == username).Count().ToString();
                ViewBag.CountPhysicsComplete3 = db.Subjects.Where(t => t.Title == subject && t.complete3 == true && t.UserName == username).Count().ToString();
                ViewBag.CountPhysicsComplete3Yesterday = db.Subjects.Where(t => t.Title == subject && t.complete3 == true && t.ModifiedDate >= yesterday && t.UserName == username).Count().ToString();
                ViewBag.CountPhysicsComplete3Lastweek = db.Subjects.Where(t => t.Title == subject && t.complete3 == true && t.ModifiedDate >= lastweek && t.UserName == username).Count().ToString();
                ViewBag.CountPhysicsComplete4 = db.Subjects.Where(t => t.Title == subject && t.complete4 == true && t.UserName == username).Count().ToString();
                ViewBag.CountPhysicsComplete4Yesterday = db.Subjects.Where(t => t.Title == subject && t.complete4 == true && t.ModifiedDate >= yesterday && t.UserName == username).Count().ToString();
                ViewBag.CountPhysicsComplete4Lastweek = db.Subjects.Where(t => t.Title == subject && t.complete4 == true && t.ModifiedDate >= lastweek && t.UserName == username).Count().ToString();
                ViewBag.CountPhysicsComplete5 = db.Subjects.Where(t => t.Title == subject && t.complete5 == true && t.UserName == username).Count().ToString();
                ViewBag.CountPhysicsComplete5Yesterday = db.Subjects.Where(t => t.Title == subject && t.complete5 == true && t.ModifiedDate >= yesterday && t.UserName == username).Count().ToString();
                ViewBag.CountPhysicsComplete5Lastweek = db.Subjects.Where(t => t.Title == subject && t.complete5 == true && t.ModifiedDate >= lastweek && t.UserName == username).Count().ToString();
                ViewBag.CountPhysicsComplete6 = db.Subjects.Where(t => t.Title == subject && t.complete6 == true && t.UserName == username).Count().ToString();
                ViewBag.CountPhysicsComplete6Yesterday = db.Subjects.Where(t => t.Title == subject && t.complete6 == true && t.ModifiedDate >= yesterday && t.UserName == username).Count().ToString();
                ViewBag.CountPhysicsComplete6Lastweek = db.Subjects.Where(t => t.Title == subject && t.complete6 == true && t.ModifiedDate >= lastweek && t.UserName == username).Count().ToString();
            }
            if (db.Subjects.Where(t => t.Title == "French").Count() > 0)
            {
                subject = "French";
                ViewBag.CountFrench = db.Subjects.Where(t => t.Title == subject && t.UserName == username).Count().ToString();
                ViewBag.CountFrenchComplete1 = db.Subjects.Where(t => t.Title == subject && t.complete1 == true && t.UserName == username).Count().ToString();
                ViewBag.CountFrenchComplete1Yesterday = db.Subjects.Where(t => t.Title == subject && t.complete1 == true && t.ModifiedDate >= yesterday && t.UserName == username).Count().ToString();
                ViewBag.CountFrenchComplete1Lastweek = db.Subjects.Where(t => t.Title == subject && t.complete1 == true && t.ModifiedDate >= lastweek && t.UserName == username).Count().ToString();
                ViewBag.CountFrenchComplete2 = db.Subjects.Where(t => t.Title == subject && t.complete2 == true && t.UserName == username).Count().ToString();
                ViewBag.CountFrenchComplete2Yesterday = db.Subjects.Where(t => t.Title == subject && t.complete2 == true && t.ModifiedDate >= yesterday && t.UserName == username).Count().ToString();
                ViewBag.CountFrenchComplete2Lastweek = db.Subjects.Where(t => t.Title == subject && t.complete2 == true && t.ModifiedDate >= lastweek && t.UserName == username).Count().ToString();
                ViewBag.CountFrenchComplete3 = db.Subjects.Where(t => t.Title == subject && t.complete3 == true && t.UserName == username).Count().ToString();
                ViewBag.CountFrenchComplete3Yesterday = db.Subjects.Where(t => t.Title == subject && t.complete3 == true && t.ModifiedDate >= yesterday && t.UserName == username).Count().ToString();
                ViewBag.CountFrenchComplete3Lastweek = db.Subjects.Where(t => t.Title == subject && t.complete3 == true && t.ModifiedDate >= lastweek && t.UserName == username).Count().ToString();
                ViewBag.CountFrenchComplete4 = db.Subjects.Where(t => t.Title == subject && t.complete4 == true && t.UserName == username).Count().ToString();
                ViewBag.CountFrenchComplete4Yesterday = db.Subjects.Where(t => t.Title == subject && t.complete4 == true && t.ModifiedDate >= yesterday && t.UserName == username).Count().ToString();
                ViewBag.CountFrenchComplete4Lastweek = db.Subjects.Where(t => t.Title == subject && t.complete4 == true && t.ModifiedDate >= lastweek && t.UserName == username).Count().ToString();
                ViewBag.CountFrenchComplete5 = db.Subjects.Where(t => t.Title == subject && t.complete5 == true && t.UserName == username).Count().ToString();
                ViewBag.CountFrenchComplete5Yesterday = db.Subjects.Where(t => t.Title == subject && t.complete5 == true && t.ModifiedDate >= yesterday && t.UserName == username).Count().ToString();
                ViewBag.CountFrenchComplete5Lastweek = db.Subjects.Where(t => t.Title == subject && t.complete5 == true && t.ModifiedDate >= lastweek && t.UserName == username).Count().ToString();
                ViewBag.CountFrenchComplete6 = db.Subjects.Where(t => t.Title == subject && t.complete6 == true && t.UserName == username).Count().ToString();
                ViewBag.CountFrenchComplete6Yesterday = db.Subjects.Where(t => t.Title == subject && t.complete6 == true && t.ModifiedDate >= yesterday && t.UserName == username).Count().ToString();
                ViewBag.CountFrenchComplete6Lastweek = db.Subjects.Where(t => t.Title == subject && t.complete6 == true && t.ModifiedDate >= lastweek && t.UserName == username).Count().ToString();
            }
            if (db.Subjects.Where(t => t.Title == "French").Count() > 0)
            {
                subject = "French";
                ViewBag.CountFrench = db.Subjects.Where(t => t.Title == subject && t.UserName == username).Count().ToString();
                ViewBag.CountFrenchComplete1 = db.Subjects.Where(t => t.Title == subject && t.complete1 == true && t.UserName == username).Count().ToString();
                ViewBag.CountFrenchComplete1Yesterday = db.Subjects.Where(t => t.Title == subject && t.complete1 == true && t.ModifiedDate >= yesterday && t.UserName == username).Count().ToString();
                ViewBag.CountFrenchComplete1Lastweek = db.Subjects.Where(t => t.Title == subject && t.complete1 == true && t.ModifiedDate >= lastweek && t.UserName == username).Count().ToString();
                ViewBag.CountFrenchComplete2 = db.Subjects.Where(t => t.Title == subject && t.complete2 == true && t.UserName == username).Count().ToString();
                ViewBag.CountFrenchComplete2Yesterday = db.Subjects.Where(t => t.Title == subject && t.complete2 == true && t.ModifiedDate >= yesterday && t.UserName == username).Count().ToString();
                ViewBag.CountFrenchComplete2Lastweek = db.Subjects.Where(t => t.Title == subject && t.complete2 == true && t.ModifiedDate >= lastweek && t.UserName == username).Count().ToString();
                ViewBag.CountFrenchComplete3 = db.Subjects.Where(t => t.Title == subject && t.complete3 == true && t.UserName == username).Count().ToString();
                ViewBag.CountFrenchComplete3Yesterday = db.Subjects.Where(t => t.Title == subject && t.complete3 == true && t.ModifiedDate >= yesterday && t.UserName == username).Count().ToString();
                ViewBag.CountFrenchComplete3Lastweek = db.Subjects.Where(t => t.Title == subject && t.complete3 == true && t.ModifiedDate >= lastweek && t.UserName == username).Count().ToString();
                ViewBag.CountFrenchComplete4 = db.Subjects.Where(t => t.Title == subject && t.complete4 == true && t.UserName == username).Count().ToString();
                ViewBag.CountFrenchComplete4Yesterday = db.Subjects.Where(t => t.Title == subject && t.complete4 == true && t.ModifiedDate >= yesterday && t.UserName == username).Count().ToString();
                ViewBag.CountFrenchComplete4Lastweek = db.Subjects.Where(t => t.Title == subject && t.complete4 == true && t.ModifiedDate >= lastweek && t.UserName == username).Count().ToString();
                ViewBag.CountFrenchComplete5 = db.Subjects.Where(t => t.Title == subject && t.complete5 == true && t.UserName == username).Count().ToString();
                ViewBag.CountFrenchComplete5Yesterday = db.Subjects.Where(t => t.Title == subject && t.complete5 == true && t.ModifiedDate >= yesterday && t.UserName == username).Count().ToString();
                ViewBag.CountFrenchComplete5Lastweek = db.Subjects.Where(t => t.Title == subject && t.complete5 == true && t.ModifiedDate >= lastweek && t.UserName == username).Count().ToString();
                ViewBag.CountFrenchComplete6 = db.Subjects.Where(t => t.Title == subject && t.complete6 == true && t.UserName == username).Count().ToString();
                ViewBag.CountFrenchComplete6Yesterday = db.Subjects.Where(t => t.Title == subject && t.complete6 == true && t.ModifiedDate >= yesterday && t.UserName == username).Count().ToString();
                ViewBag.CountFrenchComplete6Lastweek = db.Subjects.Where(t => t.Title == subject && t.complete6 == true && t.ModifiedDate >= lastweek && t.UserName == username).Count().ToString();
            }
            if (db.Subjects.Where(t => t.Title == "Geography").Count() > 0)
            {
                subject = "Geography";
                ViewBag.CountGeography = db.Subjects.Where(t => t.Title == subject && t.UserName == username).Count().ToString();
                ViewBag.CountGeographyComplete1 = db.Subjects.Where(t => t.Title == subject && t.complete1 == true && t.UserName == username).Count().ToString();
                ViewBag.CountGeographyComplete1Yesterday = db.Subjects.Where(t => t.Title == subject && t.complete1 == true && t.ModifiedDate >= yesterday && t.UserName == username).Count().ToString();
                ViewBag.CountGeographyComplete1Lastweek = db.Subjects.Where(t => t.Title == subject && t.complete1 == true && t.ModifiedDate >= lastweek && t.UserName == username).Count().ToString();
                ViewBag.CountGeographyComplete2 = db.Subjects.Where(t => t.Title == subject && t.complete2 == true && t.UserName == username).Count().ToString();
                ViewBag.CountGeographyComplete2Yesterday = db.Subjects.Where(t => t.Title == subject && t.complete2 == true && t.ModifiedDate >= yesterday && t.UserName == username).Count().ToString();
                ViewBag.CountGeographyComplete2Lastweek = db.Subjects.Where(t => t.Title == subject && t.complete2 == true && t.ModifiedDate >= lastweek && t.UserName == username).Count().ToString();
                ViewBag.CountGeographyComplete3 = db.Subjects.Where(t => t.Title == subject && t.complete3 == true && t.UserName == username).Count().ToString();
                ViewBag.CountGeographyComplete3Yesterday = db.Subjects.Where(t => t.Title == subject && t.complete3 == true && t.ModifiedDate >= yesterday && t.UserName == username).Count().ToString();
                ViewBag.CountGeographyComplete3Lastweek = db.Subjects.Where(t => t.Title == subject && t.complete3 == true && t.ModifiedDate >= lastweek && t.UserName == username).Count().ToString();
                ViewBag.CountGeographyComplete4 = db.Subjects.Where(t => t.Title == subject && t.complete4 == true && t.UserName == username).Count().ToString();
                ViewBag.CountGeographyComplete4Yesterday = db.Subjects.Where(t => t.Title == subject && t.complete4 == true && t.ModifiedDate >= yesterday && t.UserName == username).Count().ToString();
                ViewBag.CountGeographyComplete4Lastweek = db.Subjects.Where(t => t.Title == subject && t.complete4 == true && t.ModifiedDate >= lastweek && t.UserName == username).Count().ToString();
                ViewBag.CountGeographyComplete5 = db.Subjects.Where(t => t.Title == subject && t.complete5 == true && t.UserName == username).Count().ToString();
                ViewBag.CountGeographyComplete5Yesterday = db.Subjects.Where(t => t.Title == subject && t.complete5 == true && t.ModifiedDate >= yesterday && t.UserName == username).Count().ToString();
                ViewBag.CountGeographyComplete5Lastweek = db.Subjects.Where(t => t.Title == subject && t.complete5 == true && t.ModifiedDate >= lastweek && t.UserName == username).Count().ToString();
                ViewBag.CountGeographyComplete6 = db.Subjects.Where(t => t.Title == subject && t.complete6 == true && t.UserName == username).Count().ToString();
                ViewBag.CountGeographyComplete6Yesterday = db.Subjects.Where(t => t.Title == subject && t.complete6 == true && t.ModifiedDate >= yesterday && t.UserName == username).Count().ToString();
                ViewBag.CountGeographyComplete6Lastweek = db.Subjects.Where(t => t.Title == subject && t.complete6 == true && t.ModifiedDate >= lastweek && t.UserName == username).Count().ToString();
            }
        }

       


    }
}