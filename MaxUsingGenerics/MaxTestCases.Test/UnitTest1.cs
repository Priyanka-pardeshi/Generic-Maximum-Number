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
            int firstValue = 30;
            int secondValue = 20;
            int thiredValue = 10;
            int expected = 30;

            int result = objMaxInt.Maximum(firstValue, secondValue, thiredValue);

            Assert.AreEqual(expected,result);
        }
    }
}