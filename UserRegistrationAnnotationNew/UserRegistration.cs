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
        [RegularExpression(@"^[A-z]{1}[a-zA-Z]{2,}$")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Username {0} is required")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "Lastname starts with capital letter and should have minimum 3 charcters")]
        [DataType(DataType.Text)]
        [RegularExpression(@"^[A-z]{1}[a-zA-Z]{2,}$")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "EmailId is required {0}")]
        [DataType(DataType.EmailAddress)]
        [RegularExpression("^[\\w-\\+]+(\\.[\\w]+)*@[\\w-]+(\\.[\\w]+)*(\\.[a-z]{2,})$")]
        public string EmailId { get; set; }

        [Display(Name = "Mobile Number:")]
        [Required(ErrorMessage = "Mobile Number is required.")]
        [RegularExpression(@"(^[1-9]{1,}[0-9\\-]{0,}[ ]{1}[1-9]{1}[0-9]{9}$)")]
        public string MobileNumber { get; set; }
        [Display(Name = "Password:")]
        [Required(ErrorMessage = "password is required.")]
        [RegularExpression(@"(^[a-zA-Z0-9!@#$%&*()-+=^]{8,}$)")]
        public string Password { get; set; }

    }
}