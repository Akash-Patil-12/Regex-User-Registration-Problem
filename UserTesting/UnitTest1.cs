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
        public void GivenFirstNameWhenCheckShouldBeReturnTrue()
        {
            UserValidation userValidation = new UserValidation();
            bool result = userValidation.CheckFirstName("Akash");
            Assert.AreEqual(true, result);
        }
    }
}
