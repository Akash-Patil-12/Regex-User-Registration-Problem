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
    }
}
