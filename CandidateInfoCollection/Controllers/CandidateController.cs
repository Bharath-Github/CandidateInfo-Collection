using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CandidateInfoCollection.Models;
using System.IO;
using CandidateDB;

namespace CandidateInfoCollection.Controllers
{
    public class CandidateController : Controller
    {
        CandidateInfoEntities dbContext;

        public CandidateController()
        {
            dbContext = new CandidateInfoEntities();
        }
        
        // GET: Candidate
        [HttpGet]
        public ActionResult Index()
        {
            ViewBag.ActiveView = "BasicInformation";
            return View("Index");
        }

        [HttpGet]
        public ActionResult GetContactDetails()
        {
            ViewBag.ActiveView = "ContactDetails";
            return View("Index");
        }

        [HttpGet]
        public ActionResult GetEducationDetails()
        {
            ViewBag.ActiveView = "EducationDetails";
            return View("Index");
        }

        [HttpGet]
        public ActionResult GetCareerDetails()
        {
            ViewBag.ActiveView = "CareerDetails";
            return View("Index");
        }

        [HttpGet]
        public ActionResult GetBasicInformation()
        {
            ViewBag.ActiveView = "BasicInformation";
            return View("Index");
        }

        [HttpPost]
        public ActionResult BasicInformation(BasicInfoViewModel Model)
        {
            if (ModelState.IsValid)
            {
                Repository<BasicInfo> repository = new Repository<BasicInfo>();

                BasicInfo obj = new BasicInfo();
                obj.FirstName = Model.FirstName;
                obj.LastName = Model.LastName;
                obj.DateOfBirth = Model.DateOfBirth;
                obj.MiddleName = Model.MiddleName;

                repository.Insert(obj);
                repository.Save();
                ViewBag.ActiveView = "ContactDetails";                
            }
            else
            {
                ViewBag.ActiveView = "BasicInformation";                
            }
            return View("Index");
        }

        [HttpPost]
        public ActionResult ContactDetails(ContactDetailsViewModel Model)
        {
            if (ModelState.IsValid)
            {
                Repository<ContactDetail> repository = new Repository<ContactDetail>();

                ContactDetail obj = new ContactDetail();                   
                obj.StreetDetails = Model.StreetDetails;
                obj.Suburb = Model.Suburb;
                obj.NearestRailwayStation = Model.NearestRailwayStation;
                obj.PhoneNumber = Model.PhoneNumber;
                obj.MobileNumber = Model.MobileNumber;
                obj.Postcode = Model.Postcode;

                repository.Insert(obj);
                repository.Save();
                ViewBag.ActiveView = "EducationDetails";
            }
            else
            {
                ViewBag.ActiveView = "ContactDetails";                
            }
            return View("Index");
        }

        [HttpPost]
        public ActionResult EducationDetails(EducationDetailsViewModel Model)
        {
            if (ModelState.IsValid)
            {
                Repository<EducationDetail> repository = new Repository<EducationDetail>();

                EducationDetail obj = new EducationDetail();
                obj.HighestQualification = Model.HighestQualification;
                obj.GroupCategory = Model.GroupCategory;
                obj.YearOfCompletion = Model.YearOfCompletion;
                obj.UniversityDetails = Model.UniversityDetails;
                
                repository.Insert(obj);
                repository.Save();
                ViewBag.ActiveView = "CareerDetails";
            }
            else
            {
                ViewBag.ActiveView = "EducationDetails";               
            }
            return View("Index");
        }

        [HttpPost]
        public ActionResult CareerDetails(CareerDetailsViewModel Model)
        {
            if(ModelState.IsValid)            
            {
                if (Model.Resume.FileName.Length > 0)
                {
                    var fileName = Path.GetFileName(Model.Resume.FileName);
                    var path = Path.Combine(Server.MapPath("~/App_Data"), fileName);
                    Model.Resume.SaveAs(path);
                }

                if(Model.CoverLetter.FileName.Length > 0)
                {                    
                    var filename = Path.GetFileName(Model.CoverLetter.FileName);
                    var path = Path.Combine(Server.MapPath("~/App_Data"), filename);
                    Model.CoverLetter.SaveAs(path);
                }

                Repository<CareerDetail> repository = new Repository<CareerDetail>();
                CareerDetail obj = new CareerDetail();
                obj.RecentJobRole = Model.RecentJobRole;
                obj.DurationYears = Model.DurationYears;
                obj.DurationMonths = Model.DurationMonths;
                obj.StillInCurrentRole = Model.StillInCurrentRole;
                obj.Resume = Model.Resume.FileName;
                obj.CoverLetter = Model.CoverLetter.FileName;
                obj.IsPrivacyDetailsAccepted = Model.IsPrivacyDetailsAccepted;
                obj.IsDeclarationChecked = Model.IsDeclarationChecked;

                repository.Insert(obj);
                repository.Save();
                ViewBag.ActiveView = "BasicInformation";                
            }
            else
            {
                ViewBag.ActiveView = "CareerDetails";                
            }
            return View("Index");
        }
    }
}