using System;

namespace Regex_User_Registration_problems
{
    class Program
    {       
        static void Main(string[] args)
        {
            string firstName;
            UserValidation userValidation = new UserValidation();
            Console.WriteLine("Enter a first name");
            firstName = Console.ReadLine();
            if (userValidation.CheckFirstName(firstName))
                Console.WriteLine(firstName + " : is valid");
            else
                Console.WriteLine(firstName + " : is not valid");
        }
    }
}
