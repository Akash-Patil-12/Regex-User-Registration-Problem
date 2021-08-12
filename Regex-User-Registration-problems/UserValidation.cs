using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Regex_User_Registration_problems
{
    public class UserValidation
    {
        //constants
        public const string LAST_NAME = "^[A-Z]{1}[a-z]{2,}$";
        /// <summary>
        /// Check first name with regex and return true or false value 
        /// </summary>
        /// <returns></returns>
        public bool CheckLastName(string lastName)
        {
            Regex regex = new Regex(LAST_NAME);
            return regex.IsMatch(lastName);
        }
    }
}
