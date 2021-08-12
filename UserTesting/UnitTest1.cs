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
        public void GivenPasswordWhenMachWithRegexCheckShouldBeReturnTrue()
        {
            UserValidation userValidation = new UserValidation();
            bool result = userValidation.CheckPassword("akashPatil3");
            Assert.AreEqual(true, result);
        }
    }
}
