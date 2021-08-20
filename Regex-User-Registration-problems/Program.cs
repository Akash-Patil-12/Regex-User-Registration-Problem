using System;

namespace Regex_User_Registration_problems
{
    class Program
    {       
        static void Main(string[] args)
        {
            UserValidation userValidation = new UserValidation();
            Console.WriteLine("Return value is :"+userValidation.UserEntry("Akash", "Patil", "91 9960801597", "Akash12patil", "abc@yahoo.com"));
        }
    }
}
