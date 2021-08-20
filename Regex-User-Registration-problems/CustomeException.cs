using System;
using System.Collections.Generic;
using System.Text;

namespace Regex_User_Registration_problems
{
    public class CustomeException:Exception
    {
        public readonly ExceptionType type;
        public enum ExceptionType
        {
            INVALID_FIRSTNAME,INVALID_LASTNAME,INVALID_MNO,INVALID_PASSWORD,INVALID_EMAIL
        }
        public CustomeException(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }
    }
}
