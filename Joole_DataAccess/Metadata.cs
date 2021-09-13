using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Joole_DataAccess
{
    public class UserMetadata 
    {
        [DisplayName("Username")]
        [Required(ErrorMessage = "This field is required.")]
        public string User_Name { get; set; }

        [DisplayName("Email Address")]
        [Required(ErrorMessage = "This field is required.")]
        public string User_Email { get; set; }

        [DisplayName("Password")]
        [Required(ErrorMessage = "This field is required.")]
        [DataType(DataType.Password)]
        public string User_Password { get; set; }

        [DisplayName("Confirm Password")]
        [DataType(DataType.Password)]
        [Compare("User_Password")]
        public string Confirm_Password { get; set; }
    }
}
