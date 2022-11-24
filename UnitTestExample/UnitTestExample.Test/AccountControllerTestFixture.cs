using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestExample.Controllers;
using UnitTestExample.Test;
using NUnit;
using Moq;
using System.Text.RegularExpressions;



namespace UnitTestExample.Test
{
    public class AccountControllerTestFixture
    {
        [
            Test,
            TestCase("abcd1234", false),
            TestCase("irf@uni-corvinus",false),
            TestCase("irf.uni-corvinus.hu",false),
            TestCase("irf@uni-corvinus.hu",true)

        ]
        public void TestValidateEmail(string email, bool expectedResult)
        {
            var accountController = new AccountController();
            var actualResult = accountController.ValidateEmail(email);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [
            Test,
            TestCase("ABCD1234",false),
            TestCase("Ab1234",false),
            TestCase("Abcd1234",true),
            TestCase("abcd1234",false),
            TestCase("abcdABCD",false)
            ]
        public void TestValidatePassword(string pword, bool expectedResult)
        {
            var accountController = new AccountController();
            var actualResult = accountController.ValidatePassword(pword);
            Assert.AreEqual(expectedResult, actualResult);
    
        }



    }
}
