using NUnit.Framework;
using MaxUsingGenerics;

namespace MaxTestCases.Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {

        }
        MaxNumberINT objMaxInt = new MaxNumberINT();

        [Test]
        public void Test1()
        {
            int firstValue = 300, secondValue = 50, thiredValue = 100;
            int expected = firstValue;

            int result = objMaxInt.Maximum(firstValue, secondValue, thiredValue);

            Assert.AreEqual(expected, result);
        }
        [Test]
        public void Test2()
        {
            int firstValue = 30, secondValue = 200, thiredValue = 10;
            int expected = secondValue;

            int result = objMaxInt.Maximum(firstValue, secondValue, thiredValue);

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Test3()
        {
        int firstValue = 30;
        int secondValue = 20;
        int thiredValue = 100;
        int expected = thiredValue;
        int result = objMaxInt.Maximum(firstValue, secondValue, thiredValue);

        Assert.AreEqual(expected, result);
        }
    }
}