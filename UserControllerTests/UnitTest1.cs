using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MaraphonApp;
using MaraphonApp.Controllers;

namespace UserControllerTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string email = "abcd@gmail.com";
            string firstName = "Ivan";
            string lastName = "Ivanov";
            string role = "Бегун";
            string gender = "Мужской";
            string password = "Password123*";

            bool result = UserController.SaveRunnerData(email, firstName, lastName, role, gender, password);

            Assert.IsTrue(result);
        }
    }
}
