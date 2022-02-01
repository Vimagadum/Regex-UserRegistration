using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistration
{
    public class ValidUserRegistraton
    {
        //declaring pattern
        public const string FIRST_NAME = "^[A-Z][a-zA-Z]{2}";
        public const string LAST_NAME = "^[A-Z][a-zA-Z]{2}";
        public const string EMAIL = "^[0-9a-zA-Z]+[.+-_]{0,1}[0-9a-zA-Z]+[@][a-zA-Z]+[.][a-zA-Z]{2,3}([.][a-zA-Z]{2,3}){0,1}";


        public void ValidateFName(string fName)
        {
            //assigning pattern in regex constructor
            Regex regex = new Regex(FIRST_NAME);

            if (regex.IsMatch(fName))
            {
                Console.WriteLine("first name is matched with pattern");
            }
            else
            {
                Console.WriteLine("first name does not match with pattern");
            }
        }
        public void ValidateLName(string lName)
        {
            //assigning pattern in regex constructor
            Regex regex = new Regex(LAST_NAME);

            if (regex.IsMatch(lName))
            {
                Console.WriteLine("last name is matched with pattern");
            }
            else
            {
                Console.WriteLine("last name does not match with pattern");
            }
        }
        public void ValidateEmail(string emailId)
        {
            //assigning pattern in regex constructor
            Regex regex = new Regex(EMAIL);

            if (regex.IsMatch(emailId))
            {
                Console.WriteLine("Email is matched with pattern");
            }
            else
            {
                Console.WriteLine("email does not match with pattern");
            }
        }
    }
}
