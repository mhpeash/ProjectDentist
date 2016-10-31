using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DentistAppoinmentWebApp.Models
{
    public class Users
    {

        public int Id { get; set; }




        [Display(Name = "Full Name")]
        public string Name { get; set; }



        [Display(Name = " Designation and Workplace")]
        public string Designation { get; set; }



        [StringLength(20, ErrorMessage = "Please Provide a valid Area.", MinimumLength = 4)]
        public string Area { get; set; }



        [StringLength(11, ErrorMessage = "Proviode a valid Number", MinimumLength = 11)]
        [Display(Name = "Mobile Number")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{4})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid Phone number")]
        public string Phone { get; set; }



        [StringLength(20, ErrorMessage = "The {0} Must Be at least {2} Character Long", MinimumLength = 6)]
        [DataType(DataType.Password)]
        public string Password { get; set; }



        [Display(Name = "Visiting Hours")]
        [StringLength(20, ErrorMessage = "Ex: XXAM-ZZPM", MinimumLength = 7)]
        public string VisitingHours { get; set; }



        [StringLength(9, ErrorMessage = " Provide a Currect Day", MinimumLength = 6)]
        public string Offday { get; set; }



        [Display(Name = "Chamber Address")]
        [DataType(DataType.MultilineText)]
        [StringLength(50, ErrorMessage = " Ex: House:, Road, Block etc", MinimumLength = 10)]
        public string ChamberAddress { get; set; }


        public string Image { get; set; }


        [DataType(DataType.EmailAddress, ErrorMessage = "Provide a valid Email ")]
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "E-mail is not valid")]
        public string Email { get; set; }


        [Display(Name = "Registration No")]
        [RegularExpression(("^[0-9]+$"), ErrorMessage = "Invalid Registration Number")]
        [StringLength(5, ErrorMessage = "The BDS Number is Invalid", MinimumLength = 4)]

        public string RegistrationNo { get; set; }

        private int _tempvalue = 1;

        public int Tempvalue { get { return _tempvalue; } set { _tempvalue = value; } }

    }
}