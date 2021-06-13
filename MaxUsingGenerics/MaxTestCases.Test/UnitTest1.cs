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
            int firstValue = 30, secondValue = 50, thiredValue = 100;
            int expected = thiredValue;

            int result = objMaxInt.Maximum(firstValue, secondValue, thiredValue);

            Assert.AreEqual(expected,result);
        }

    }
}