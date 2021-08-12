using System;

namespace Regex_User_Registration_problems
{
    class Program
    {       
        static void Main(string[] args)
        {
            string phoneNumber;
            UserValidation userValidation = new UserValidation();
            Console.WriteLine("Enter a phone number");
            phoneNumber = Console.ReadLine();
            if (userValidation.CheckLastName(phoneNumber))
                Console.WriteLine(phoneNumber+ " : is valid");
            else
                Console.WriteLine(phoneNumber + " : is not valid");
        }
    }
}
