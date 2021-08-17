using Microsoft.VisualStudio.TestTools.UnitTesting;
using Regex_User_Registration_problems;

namespace UserTesting
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        /// <summery>
        /// Test case Password contains exactly one special character else its not valid
        /// <summery>
        public void GivenEmailMachWithRegexCheckShouldBeReturnTrue()
        {
            UserValidation userValidation = new UserValidation();
            bool result = userValidation.CheckPassword("Aks3bxyz@");
            Assert.AreEqual(true, result);
        }
    }
}
