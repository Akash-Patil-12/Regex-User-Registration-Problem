using System;

namespace Regex_User_Registration_problems
{
    class Program
    {       
        static void Main(string[] args)
        {
            string lastName;
            UserValidation userValidation = new UserValidation();
            Console.WriteLine("Enter a last name");
            lastName = Console.ReadLine();
            if (userValidation.CheckLastName(lastName))
                Console.WriteLine(lastName+ " : is valid");
            else
                Console.WriteLine(lastName + " : is not valid");
        }
    }
}
