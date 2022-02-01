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
    }
}
