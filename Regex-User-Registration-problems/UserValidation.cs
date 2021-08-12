using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Regex_User_Registration_problems
{
    public class UserValidation
    {
        //constants
        public const string PASSWORD = "^[a-z]{8,}$";
        /// <summary>
        /// check password is valid or no
        /// </summary>
        /// <returns></returns>
        public bool CheckPassword(string password)
        {
            Regex regex = new Regex(PASSWORD);
            return regex.IsMatch(password);
        }
    }
}
