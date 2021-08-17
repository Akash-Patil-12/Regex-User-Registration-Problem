using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Regex_User_Registration_problems
{
    public class UserValidation
    {
        //constants
        public const string PASSWORD = "^(?=.*[0-9])(?=.*[a-z])(?=.*[A-Z])([a-zA-Z0-9]+){8,}$";
        /// <summary>
        /// check given password is valid or not 
        /// </summary>
        /// <returns></returns>
        public bool CheckPassword(string password)
        {
            Regex regex = new Regex(PASSWORD);
            return regex.IsMatch(password);
        }
    }
}
