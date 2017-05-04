using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyApp.Controllers;
using MyApp.Model;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http.Results;

namespace MyApp.Tests
{
    [TestClass]
    public class TestHelloWorldController
    {
        /// <summary>
        /// This Unit Test is to test the Get() method of teh Controller.
        /// Similarly we can write Unit Tests for other action methods in teh controller.
        /// </summary>
        [TestMethod]
        public void Get_ShouldReturnHelloWorld()
        {
            
            var test = GetTestHelloWorld();
            
            var controller = new HelloworldController();

            var result = controller.Get();
            
            Assert.AreEqual(test.Id, result.Id);
            Assert.AreEqual(test.Name, result.Name);
        }

          
        /// <summary>
        /// Unit Test Method to return single object for HelloWorld class
        /// Count = 1
        /// </summary>
        /// <returns></returns>
        private HelloWorld GetTestHelloWorld()
        {
            var testHelloWorld = new HelloWorld(){ Id = 1, Name = "Hello World"};
            return testHelloWorld;
        }
    }
}