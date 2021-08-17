using System;

namespace Regex_User_Registration_problems
{
    class Program
    {       
        static void Main(string[] args)
        {
            string email;
            UserValidation userValidation = new UserValidation();
            Console.WriteLine("Enter a password");
            email = Console.ReadLine();
            if (userValidation.CheckEmail(email))
                Console.WriteLine(email+ " : is valid.");
            else
                Console.WriteLine(email + " : is not valid.");
        }
    }
}
