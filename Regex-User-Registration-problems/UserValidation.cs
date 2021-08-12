using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Regex_User_Registration_problems
{
    public class UserValidation
    {
        //constants
        public const string PHONE_NUMBER = "^[91]{2}\\s[0-9]{10}$";
        /// <summary>
        /// Check mobile number is valid or not 
        /// </summary>
        /// <returns></returns>
        public bool CheckLastName(string phoneNumber)
        {
            Regex regex = new Regex(PHONE_NUMBER);
            return regex.IsMatch(phoneNumber);
        }
    }
}
