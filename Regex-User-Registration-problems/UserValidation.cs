using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Regex_User_Registration_problems
{
    public class UserValidation
    {
        //variables
        bool checkValidate = true;
        //constants
        public const string FIRST_NAME = "^[A-Z]{1}[a-z]{2,}$", LAST_NAME = "^[A-Z]{1}[a-z]{2,}$", PHONE_NUMBER = "^[91]{2}\\s[0-9]{10}$", PASSWORD = "^(?=.*[0-9])(?=.*[a-z])(?=.*[A-Z])([a-zA-Z0-9]+){8,}$";
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
        /// <summary>
        /// User Entry matches return Happy or it return Sad
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="mobileNo"></param>
        /// <param name="password"></param>
        /// <param name="email"></param>
        /// <returns></returns>
        public string UserEntry(string firstName,string lastName, string mobileNo,string password, string email)
        {
            Regex regex = new Regex(FIRST_NAME);
            checkValidate= regex.IsMatch(firstName);
            if (checkValidate != true)
            {
                return "Sad" ;
            }
            Regex regexLastName = new Regex(LAST_NAME);
            checkValidate= regexLastName.IsMatch(lastName);
            if (checkValidate != true)
            {
                return "Sad";
            }
            Regex regexMobileNo = new Regex(PHONE_NUMBER);
            checkValidate = regexMobileNo.IsMatch(mobileNo);
            if (checkValidate != true)
            {
                return "Sad";
            }
            Regex regexPassword = new Regex(PASSWORD);
            checkValidate = regexPassword.IsMatch(password);
            if (checkValidate != true)
            {
                return "Sad";
            }
            Regex regexEmail = new Regex(SAMPLE_EMAIL);
            checkValidate = regexEmail.IsMatch(email);
            if (checkValidate != true)
            {
                return "Sad";
            }
            return "Happy";
        }
    }
}
