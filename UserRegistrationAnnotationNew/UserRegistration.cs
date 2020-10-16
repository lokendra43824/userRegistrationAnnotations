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

    }
}