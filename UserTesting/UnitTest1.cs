using Microsoft.VisualStudio.TestTools.UnitTesting;
using Regex_User_Registration_problems;
using System;

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
            try
            {
                UserValidation userValidation = new UserValidation();
                bool result = userValidation.CheckEmail("abc@yahoo.com");
                Assert.AreEqual(true, result);
               
            }
            catch (CustomeException e)
            {
               Console.WriteLine(e.Message);
            }
        }
        [TestMethod]
        ///<summary>
        /// Test case check user entry is valid return Happy
        /// </summary>
        public void GivenUserEntryWithRegexCheckShouldBeReturnHappy()
        {
            try
            {
                UserValidation userValidation = new UserValidation();
                string expect = userValidation.UserEntry("Akash", "Patil", "91 9960801597", "Akash12patil", "abc@yahoo.com");
                Assert.AreEqual("Happy", expect);
            }
            catch(CustomeException e)
            {
                Console.WriteLine(e.Message);
            }
        }
        
        [TestMethod]
        ///<summary>
        /// Test case check multiple entrys of email if all valid return true else return false
        /// </summary>
        public void GivenMultipleEntryForEmailWithRegexCheckShouldBeReturnTrue()
        {
            bool expect = true ;
            try
            {
                string[] emailList = { "abc@yahoo.com", "Akash@gmail.com", "Sam233@gmail.ocm", "dddd" };
                UserValidation userValidation = new UserValidation();
                expect = userValidation.MultipleEntyForEmail(emailList);
            }
            catch (CustomeException)
            {
                Assert.AreEqual(false, expect);
            }
        }
    }
}
