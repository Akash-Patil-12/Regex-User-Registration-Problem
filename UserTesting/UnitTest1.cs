using Microsoft.VisualStudio.TestTools.UnitTesting;
using Regex_User_Registration_problems;

namespace UserTesting
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        /// <summery>
        /// Test case check email is valid or not 
        /// <summery>
        public void GivenEmailMachWithRegexCheckShouldBeReturnTrue()
        {
            UserValidation userValidation = new UserValidation();
            bool result = userValidation.CheckEmail("abc@yahoo.com");
            Assert.AreEqual(true, result);
        }
        [TestMethod]
        ///<summary>
        /// Test case check user entry is valid return Happy
        /// </summary>
        public void GivenUserEntryWithRegexCheckShouldBeReturnHappy()
        {
            UserValidation userValidation = new UserValidation();
            string expect = userValidation.UserEntry("Akash", "Patil", "91 9960801597", "Akash12patil", "abc@yahoo.com");
            Assert.AreEqual("Happy", expect);
        }
        [TestMethod]
        ///<summary>
        /// Test case check user entry is not valid return Sad
        /// </summary>
        public void GivenUserEntryWithRegexCheckShouldBeReturnSad()
        {
            UserValidation userValidation = new UserValidation();
            string expect = userValidation.UserEntry("Akash", "Patil", "91 99608015", "Akash12patil", "abc@yahoo.com");
            Assert.AreEqual("Sad", expect);
        }
    }
}
