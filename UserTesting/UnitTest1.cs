using Microsoft.VisualStudio.TestTools.UnitTesting;
using Regex_User_Registration_problems;

namespace UserTesting
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        /// <summery>
        /// Test 1
        /// <summery>
        public void GivenMobileNumberCheckShouldBeReturnTrue()
        {
            UserValidation userValidation = new UserValidation();
            bool result = userValidation.CheckLastName("91 9960708015");
            Assert.AreEqual(true, result);
        }
    }
}
