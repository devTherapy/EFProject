using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace EFProject.Commons
{
    public class Utilities
    {

        public static bool ContainsDigit(string input)
        {
            bool isDigitPresent = input.Any(c => char.IsDigit(c));
            return isDigitPresent;
        }
        /// <summary>
        /// Vidates the incoming email
        /// </summary>
        /// <param name="email"></param>
        public static void ValidateEmail(string email)
        {
            {
                string emailPattern = @"^[\w!#$%&'*+\-/=?\^_`{|}~]+(\.[\w!#$%&'*+\-/=?\^_`{|}~]+)*" + "@" + @"((([\-\w]+\.)+[a-zA-Z]{2,4})|(([0-9]{1,3}\.){3}[0-9]{1,3}))\z";
                bool isValidMail = Regex.IsMatch(email, emailPattern);
                if (!isValidMail)
                {
                    throw new FormatException("Invalid Email Format, Please Enter Correct Email");
                }
            }
        }
        /// <summary>
        /// validates an incoming phonenumber
        /// </summary>
        /// <param name="phoneNumber"></param>
        /// <returns></returns>
        public static string ValidatePhoneNumber(string phoneNumber)
        {
            // use regex to check that it is 14 characters long and contains country code
            // return string, else throw FormatException;
            if (Regex.IsMatch(phoneNumber, @"^(\+[0-9]{13})$"))
            {
                return phoneNumber;
            }
            throw new FormatException($"Phone Number not valid, Ensure you include " +
                                      $"country code and length is equal to 14");
        }

        public static string FirstCharacterToUpper(string val)
        {
            var str = val.Substring(0, 1).ToCharArray();
            var strCode = (int)str[0];
            if (strCode >= 97)
            {
                var strCaps = strCode - 32;
                if (val.Length > 1) return (char)strCaps + val.Substring(1);
            }



            return val;
        }
        /// <summary>
        /// Validates an incoming name
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static string ValidateName(string name)
        {
            // check that the string does not contain any special characters and numbers
            // Take the first char to make it capital
            // return string
            // else throw FormatException

            // Change first character to caps
            if (!string.IsNullOrEmpty(name) && Regex.IsMatch(name, @"^[A-Za-z]*$"))
                return FirstCharacterToUpper(name);
            throw new FormatException(
                $"{nameof(name)} should start with a capital letter and not contain numbers");
        }
        /// <summary>
        /// Validates an input
        /// </summary>
        /// <param name="input"></param>
        public static void ValidateInput(string input)
        {
            if (String.IsNullOrEmpty(input))
            {
                throw new Exception("All Fields must be filled before proceeding");
            }
        }
        /// <summary>
        /// Validate an incoming salary
        /// </summary>
        /// <param name="salary"></param>
        /// <param name="numericSalary"></param>
        /// <returns></returns>
        public static bool ValidateSalary(string salary, out double numericSalary)
        { 
            
            bool state =   double.TryParse(salary, out numericSalary);
             if (state == false)
             {
              throw new Exception("Please enter a valid numeric value in the salary field");
             }

             return state;
        }
    }
}
