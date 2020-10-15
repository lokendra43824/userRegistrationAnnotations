using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace UserRegistrationAnnotations
{
    public class UserRegistration
    {
        [Required(ErrorMessage = "Username {0} is required")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "Firstname starts with capital letter and should have minimum 3 charcters")]
        [DataType(DataType.Text)]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Username {0} is required")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "Lastname starts with capital letter and should have minimum 3 charcters")]
        [DataType(DataType.Text)]
        public string LastName { get; set; }
        [Required(ErrorMessage = "EmailId is required {0}")]
        [DataType(DataType.EmailAddress)]
        [RegularExpression(@"^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}$")]
        [EmailAddress]
        public string EmailId { get; set; }
        
        [Display(Name = "Mobile Number:")]
        [Required(ErrorMessage = "Mobile Number is required.")]
        [RegularExpression(@"^((\+){1}91){1}[1-9]{1}[0-9]{9})$", ErrorMessage = "Invalid Mobile Number.")]
        public string MobileNumber { get; set; }


    }
}