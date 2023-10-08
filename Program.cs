
using System.Text.RegularExpressions;

namespace emailValidator
{
    class Program
    {
        public static void Main(string[] args)
        {
            Regex regex = new Regex(@"^[a-z\d]+\.?[a-z\d]+@{1}[a-z]+\.[a-z]{2,3}$");
            string userInput;

            do
            {
                Console.WriteLine("Type in email to validate \\ 'x' to Escape");
                Console.Write("Email: ");
                userInput = Console.ReadLine();

                if (userInput == "x")
                {
                    break;
                }

                if (regex.IsMatch(userInput))
                {
                    Console.WriteLine("\nEmail address is correct!");
                    break;
                }
                else
                {
                    Console.WriteLine("\nInvalid address...\n");
                }

            } while (userInput != "x");


        }

    }
}