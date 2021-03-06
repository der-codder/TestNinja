using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests.Fundamentals
{
    [TestFixture]
    public class MathTests
    {
        private Math _math;

        [SetUp]
        public void SetUp()
        {
            _math = new Math();
        }

        [Test]
        [Ignore("Because I wanted to!")]
        public void Add_WhenCalled_ReturnsTheSumOfArguments()
        {
            var result = _math.Add(1, 2);

            Assert.That(result, Is.EqualTo(3));
        }

        [Test]
        [TestCase(2, 1, 2)]
        [TestCase(1, 2, 2)]
        [TestCase(2, 2, 2)]
        public void Max_WhenCalled_ReturnTheGreaterArgument(int a, int b, int expected)
        {
            var result = _math.Max(a, b);

            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void GetOddNumbers_LimitIsGreaterThenZero_ReturnOddNumbersUpToLimit()
        {
            var result = _math.GetOddNumbers(5);

            Assert.That(result, Is.EquivalentTo(new [] {1, 3, 5}));
        }
    }
}
