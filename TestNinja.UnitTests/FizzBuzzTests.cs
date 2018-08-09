using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class FizzBuzzTests
    {
        [Test]
        [TestCase(3)]
        [TestCase(27)]
        public void GetOutput_InputIsDivisibleOnlyBy3_ReturnFizz(int number)
        {
            var result = FizzBuzz.GetOutput(number);

            Assert.That(result, Is.EqualTo("Fizz"));
        }

        [Test]
        [TestCase(5)]
        [TestCase(35)]
        public void GetOutput_InputIsDivisibleOnlyBy5_ReturnBuzz(int number)
        {
            var result = FizzBuzz.GetOutput(number);

            Assert.That(result, Is.EqualTo("Buzz"));
        }

        [Test]
        [TestCase(15)]
        [TestCase(30)]
        public void GetOutput_InputIsDivisibleBy3And5_ReturnBuzz(int number)
        {
            var result = FizzBuzz.GetOutput(number);

            Assert.That(result, Is.EqualTo("FizzBuzz"));
        }

        [Test]
        [TestCase(2)]
        [TestCase(7)]
        public void GetOutput_InputIsNotDivisibleBy3Or5_ReturnNumberString(int number)
        {
            var result = FizzBuzz.GetOutput(number);

            Assert.That(result, Is.EqualTo(number.ToString()));
        }
    }
}
