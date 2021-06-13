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
            int firstValue = 300, secondValue = 50, thiredValue = 100;
            int expected = firstValue;
            int result = objMaxDigit.MaximumInt(firstValue, secondValue, thiredValue);

            Assert.AreEqual(expected, result);
        }
        [Test]
        public void Test2()
        {
            int firstValue = 30, secondValue = 200, thiredValue = 10;
            int expected = secondValue;
            int result = objMaxDigit.MaximumInt(firstValue, secondValue, thiredValue);

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Test3()
        {
        int firstValue = 30, secondValue = 20, thiredValue = 100;
        int expected = thiredValue;
        int result = objMaxDigit.MaximumInt(firstValue, secondValue, thiredValue);

        Assert.AreEqual(expected, result);
        }
        [Test]
        public void Test4()
        {
            double firstValue = 300.67, secondValue = 50.99, thiredValue = 100.10;
            double expected = firstValue;
            double result = objMaxDigit.MaximumDouble(firstValue, secondValue, thiredValue);

            Assert.AreEqual(expected, result);
        }
        [Test]
        public void Test5()
        {
            double firstValue = 30.3, secondValue = 200.56, thiredValue = 10.54;
            double expected = secondValue;
            double result = objMaxDigit.MaximumDouble(firstValue, secondValue, thiredValue);

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Test6()
        {
            double firstValue = 30, secondValue = 20, thiredValue = 100;
            double expected = thiredValue;
            double result = objMaxDigit.MaximumDouble(firstValue, secondValue, thiredValue);

            Assert.AreEqual(expected, result);
        }




    }
}