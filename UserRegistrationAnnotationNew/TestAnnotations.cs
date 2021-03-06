﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace UserRegistrationAnnotations
{
    class TestAnnotations
    {
        public static void Display()
        {
            Console.WriteLine("User Registration Validation");
            Console.WriteLine(".............");
            UserRegistration obj = new UserRegistration();
            obj.FirstName = "Lokendra";
            obj.LastName = "Yeddula";
            obj.EmailId = "abc.x123yz@bl.co.in";
            obj.MobileNumber = "91 8919445458";
            obj.Password = "C#bcd1234";
            ValidationContext context = new ValidationContext(obj, null, null);
            List<ValidationResult> result = new List<ValidationResult>();
                bool valid = Validator.TryValidateObject(obj, context, result, true);
            if (!valid)
            {
                foreach (ValidationResult Totalresult in result)
                {
                    Console.WriteLine("member Name : {0}", Totalresult.MemberNames.First<string>(), Environment.NewLine);
                    Console.WriteLine("Error Msg :: {0} {1}", Totalresult.ErrorMessage, Environment.NewLine);
                }
            }
            else
            {
                Console.WriteLine("FirstName: " + obj.FirstName);
                Console.WriteLine("LastName: " + obj.LastName);
                Console.WriteLine("EmailId: " + obj.EmailId);
                Console.WriteLine("PhoneNumber: " + obj.MobileNumber);
                Console.WriteLine("Password: " + obj.Password);

            }
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();

        }
    }
}