
using System;
using System.Text.RegularExpressions;

namespace emailValidator
{
    class EmailValidationErrorPrinter
    {
        public static void printErrors(string email)
        {
            Regex regex_1 = new Regex(@"^[a-z\d]");

            if (!regex_1.IsMatch(email))
            {
                Console.WriteLine("Email should begin with letters and/or digits");
            }

            Regex regex_2 = new Regex(@"\.[a-z]{2,3}$");

            if (!regex_2.IsMatch(email)) 
            {
                Console.WriteLine("Email should end with '.<domain_name>' with length of 2 to 3 letters");
            }

            Regex regex_3 = new Regex(@"\w+@{1}\w+");

            if (!regex_3.IsMatch(email))
            {
                Console.WriteLine("Email should have digits and/or letters just before and after '@'");
            }

            Regex regex_4 = new Regex(@"\w+@{1}\w+");

            if (!regex_4.IsMatch(email))
            {
                Console.WriteLine("Email must contain single '@' symbol");
            }

        }
    }
}