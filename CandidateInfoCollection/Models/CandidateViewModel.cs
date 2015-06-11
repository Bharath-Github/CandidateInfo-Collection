using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace CandidateInfoCollection.Models
{
    public class BasicInfoViewModel
    {
        [Required(ErrorMessage = "Please enter the First Name")]
        [Display(Name = "First Name")]
        [DataType(DataType.Text)]
        public string FirstName { get; set; }

        [Display(Name = "Middle Name")]
        [DataType(DataType.Text)]
        public string MiddleName { get; set; }

        [Required(ErrorMessage = "Please enter the Last Name")]
        [Display(Name = "Last Name")]
        [DataType(DataType.Text)]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Please provide the Date of Birth")]
        [Display(Name = "Date Of Birth")]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }
    }

    public class ContactDetailsViewModel
    {
        [Required(ErrorMessage = "Please enter the street details")]
        [Display(Name = "Street Details")]
        [DataType(DataType.Text)]
        public string StreetDetails { get; set; }

        [Required(ErrorMessage = "Please enter the Suburb/Town")]
        [Display(Name = "Suburb/Town")]
        [DataType(DataType.Text)]
        public string Suburb { get; set; }

        [Required(ErrorMessage = "Please enter the nearby Railway station")]
        [Display(Name = "Nearby Railwaystation")]
        [DataType(DataType.Text)]
        public string NearestRailwayStation { get; set; }

        [Required(ErrorMessage = "Please enter the Post code")]
        [Display(Name = "Post Code")]
        [MaxLength(4, ErrorMessage = "Postcode cannot be longer than 4 characters.")]
        [DataType(DataType.PostalCode)]
        public string Postcode { get; set; }

        [Display(Name = "Please provide the Phone Number")]
        [DataType(DataType.PhoneNumber)]
        [MaxLength(10, ErrorMessage = "Phone number cannot be longer than 10 characters.")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Please provide the mobile number")]
        [Display(Name = "Mobile Number")]
        [MaxLength(10, ErrorMessage = "Mobile number cannot be longer than 10 characters.")]
        [DataType(DataType.PhoneNumber)]
        public string MobileNumber { get; set; }
    }

    public class EducationDetailsViewModel
    {
        [Required(ErrorMessage = "Please enter the Highest qualification")]
        [Display(Name = "Highest Qualification")]
        [DataType(DataType.Text)]
        public string HighestQualification { get; set; }

        [Required(ErrorMessage = "Please provide you major group or subject studied")]
        [Display(Name = "Group Category")]
        [DataType(DataType.Text)]
        public string GroupCategory { get; set; }

        [Required(ErrorMessage = "Please enter the date of Completion")]
        [Display(Name = "Completion Date")]
        [DataType(DataType.Date)]
        public System.DateTime YearOfCompletion { get; set; }

        [Required(ErrorMessage = "Please enter your University Details")]
        [Display(Name = "University Details")]
        [DataType(DataType.Text)]
        public string UniversityDetails { get; set; }
    }

    public class CareerDetailsViewModel
    {
        [Required(ErrorMessage = "Please provide your recent job details")]
        [Display(Name = "Recent JobRole")]
        [DataType(DataType.Text)]
        public string RecentJobRole { get; set; }

        [Required(ErrorMessage = "Please enter the No of years worked")]
        [Display(Name = "DurationYears")]
        [MaxLength(2, ErrorMessage = "No of years cannot be longer than 2 characters.")]
        public string DurationYears { get; set; }

        [Required(ErrorMessage = "Please enter the No of months worked")]
        [Display(Name = "DurationMonths")]
        [MaxLength(2, ErrorMessage = "No of months cannot be longer than 2 characters.")]
        public string DurationMonths { get; set; }

        [Required(ErrorMessage = "Please provide details of your current employment")]
        [Display(Name = "Still In CurrentRole")]
        public bool StillInCurrentRole { get; set; }

        [Required(ErrorMessage = "Please upload your Resume")]
        [Display(Name = "Resume")]
        [DataType(DataType.Upload)]
        public HttpPostedFileBase Resume { get; set; }
        

        [Required(ErrorMessage = "Please upload your Cover Letter")]
        [Display(Name = "Cover Letter")]
        [DataType(DataType.Upload)]
        public HttpPostedFileBase CoverLetter { get; set; }

        [Required(ErrorMessage = "Please accept privacy details")]
        [Display(Name = "Is Privacy Details Accepted")]
        public bool IsPrivacyDetailsAccepted { get; set; }

        [Required(ErrorMessage = "Please declare")]
        [Display(Name = "Is Declarated")]
        public bool IsDeclarationChecked { get; set; }
    }
}