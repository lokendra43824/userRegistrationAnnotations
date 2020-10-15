﻿using System;
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
        [Required (ErrorMessage = "EmailId is required {0}")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string EmailId { get; set; }
        /*[Required (ErrorMessage = "phone number is required {0}")]
        [DataType(DataType.PhoneNumber)]
        [Phone]
        public string PhoneNumber { get; set; }*/

    }
}