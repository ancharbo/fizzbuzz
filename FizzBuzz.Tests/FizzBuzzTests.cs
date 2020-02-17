using Microsoft.VisualStudio.TestTools.UnitTesting;
using FizzBuzz.Library;

namespace FizzBuzz.Tests
{
    [TestClass]
    public class FizzBuzzTests
    {
        //have test class setup instance of FizzBuzz Service
        private FizzBuzzService _fizzbuzz;
        public FizzBuzzTests()
        {
            _fizzbuzz = new FizzBuzzService();
        }


        //Start with test for getting default behavior of returning the number that we give to the service.
        [TestMethod]

        public void ShouldPrintNumber()
        {
            Assert.AreEqual("1",_fizzbuzz.Print(1));
            Assert.AreEqual("2",_fizzbuzz.Print(2));
        }
    }
}
