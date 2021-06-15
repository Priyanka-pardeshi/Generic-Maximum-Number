using NUnit.Framework;
using MaxUsingGenerics;

namespace MaxTestCases.Test
{
    public class Tests
    {
        
        MaxNumber objMaxDigit = new MaxNumber();
       [Test]
        public void Test1()
        {
            int firstValue = 300, secondValue = 50, thirdValue = 100;
            int expected = firstValue;
            int result = objMaxDigit.MaximumGeneric<int>(firstValue, secondValue, thirdValue);
            Assert.AreEqual(expected, result);
        }
        
        [Test]
        public void Test4()
        {
            double firstValue = 300.67, secondValue = 50.99, thiredValue = 100.10;
            double expected = firstValue;
            double result = objMaxDigit.MaximumGeneric(firstValue, secondValue, thiredValue);

            Assert.AreEqual(expected, result);
        }
        

        [Test]
        public void test7()
        {
            string firstStr = "sidh", secondStr = "sidho", thirdStr = "sid";
            string expected = secondStr;
            string result = objMaxDigit.MaximumGeneric(firstStr, secondStr, thirdStr);
            Assert.AreEqual(expected, result);
        }

    }
}