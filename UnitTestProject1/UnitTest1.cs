using AutomationTest.Controllers;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using Assert = NUnit.Framework.Assert;


namespace UnitTestProject1
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void can_userauth_as_admin()
        {
            var test = new HomeController();
            var result = test.Can_view_page("admin");
            Assert.That(result, Is.EqualTo(true));
        }

    }

    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void can_userauth_as_user()
        {
            var test = new HomeController();
            var result = test.Can_view_page("USER");
            Assert.That(result, Is.EqualTo(true));
        }

    }

    [TestClass]
    public class UnitTest3
    {
        [TestMethod]
        public void can_userauth_as_other()
        {
            var test = new HomeController();
            var result = test.Can_view_page("");
            Assert.That(result, Is.EqualTo(false));
        }

    }

}
