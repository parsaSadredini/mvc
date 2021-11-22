using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MVC.SimpleJobs;
using MVC.Controllers;
namespace UnitTestLayer
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            SimpleJobs simple = new SimpleJobs();
            int result = simple.sum(4,2);
            Assert.AreEqual(6, result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            // arrange
            TestController controller = new TestController();
            // act
            string value= controller.Get(1);
            // assert
            Assert.IsInstanceOfType(value, typeof(String));
        }

       
    }
}
