using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Regex_User_Registration_problems
{
    public class UserValidation
    {
        //constants
        public const string SAMPLE_EMAIL = "^[a-zA-z]{3}([+-_ .]*[a-zA-Z0-9]+)*[@][a-zA-z0-9]+(.[a-z]{2,3})*$";
        /// <summary>
        /// check given email is valid or not  
        /// </summary>
        /// <returns></returns>
        public bool CheckEmail(string email)
        {
            Regex regex = new Regex(SAMPLE_EMAIL);
            return regex.IsMatch(email);
        }
    }
}
