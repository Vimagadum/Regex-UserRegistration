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
        public const string MOBILE = "^([9][1])+[ ]+[6789]{1}[0-9]{9}$";
        public const string PASSWORD_RULE1= "^[a-z]{8}";
        public const string PASSWORD_RULE2 = "^(?=.*[a-z])(?=.*[A-Z]).{8,}$";
        public const string PASSWORD_RULE3 = "^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9]).{8,}$";
        public const string PASSWORD_RULE4 = "^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?=.*[@#$%^&-+=()]).{8,}$";

        //declaring Array
       public string[] sample = { "abc@yahoo.com", "abc-100@yahoo.com", "abc.100@yahoo.com", "abc-100@abc.net", "abc.100@abc.com.au",
                 "abc@1.com", "abc@gmail.com.com", "abc+100@gmail.com" ,"abc","abc@.com","abc123@gmail.a", "abc123@.com" ,
                 "abc123@.com.com",".abc@abc.com","abc()*@gmail.com","abc@%*.com","abc.@gmail.com","abc@abc@gmail.com","abc@gmail.com.1a"};



        //method to check first name is valid or not
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
        //method to check last is valid or not
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
        //method to check email is valid or not
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
        //method to check mbile number is valid or not 
        public void ValidateMobile(string mnum)
        {
            //assigning pattern in regex constructor
            Regex regex = new Regex(MOBILE);

            if (regex.IsMatch(mnum))
            {
                Console.WriteLine("Mobile Number is matched with pattern");
            }
            else
            {
                Console.WriteLine("Mobile Number does not match with pattern");
            }
        }
        //method to check passwrd is valid or not 
        public void ValidatePassword(string psswrd)
        {
            //assigning pattern in regex constructor
            Regex regex = new Regex(PASSWORD_RULE1);

            if (regex.IsMatch(psswrd))
            {
                Console.WriteLine("PassWord is matched with pattern");
            }
            else
            {
                Console.WriteLine("PassWord Number does not match with pattern");
            }
        }
        //method to check passwrd is valid or not 
        public void ValidatePassword2(string psswrd2)
        {
            //assigning pattern in regex constructor
            Regex regex = new Regex(PASSWORD_RULE2);

            if (regex.IsMatch(psswrd2))
            {
                Console.WriteLine("PassWord is matched with pattern");
            }
            else
            {
                Console.WriteLine("PassWord does not match with pattern");
            }
        }
        //method to check passwrd is valid or not. it should be contain at least one uppercase and one number 
        public void ValidatePassword3(string psswrd3)
        {
            //assigning pattern in regex constructor
            Regex regex = new Regex(PASSWORD_RULE3);

            if (regex.IsMatch(psswrd3))
            {
                Console.WriteLine("PassWord is matched with pattern");
            }
            else
            {
                Console.WriteLine("PassWord does not match with pattern");
            }
        }
        //method to check passwrd is valid or not. it should be contain at least one uppercase and one number and one special character 
        public void ValidatePassword4(string psswrd4)
        {
            //assigning pattern in regex constructor
            Regex regex = new Regex(PASSWORD_RULE4);

            if (regex.IsMatch(psswrd4))
            {
                Console.WriteLine("PassWord is matched with pattern");
            }
            else
            {
                Console.WriteLine("PassWord does not match with pattern");
            }
        }
        //method to check sample emails are valid or invalid 
        public void ValidateSample()
        {
            //assigning pattern in regex constructor
            Regex regex = new Regex(EMAIL);
            for(int i = 0; i < sample.Length; i++)
            {
                if(regex.IsMatch(sample[i]))
                {
                    Console.WriteLine(sample[i]+" Is Valid");
                }
                else
                {
                    Console.WriteLine(sample[i]+" is Invalid");
                }
            }
           
        }
    }
}
