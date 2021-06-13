using System;
using System.Collections.Generic;
using System.Text;

namespace MaxUsingGenerics
{
    public class MaxNumber
    {
        public int MaximumInt(int firstNumber, int secondNumber, int thiredNumber)
        {
            if (firstNumber.CompareTo(secondNumber) == 1 & firstNumber.CompareTo(thiredNumber) == 1)
            {
                Console.WriteLine(firstNumber + " is greater");
                return firstNumber;
            }
            if (secondNumber.CompareTo(firstNumber) == 1 & secondNumber.CompareTo(thiredNumber) == 1)
            {
                Console.WriteLine(secondNumber + " is greater");
                return secondNumber;
            }
            if (thiredNumber.CompareTo(firstNumber) == 1 & thiredNumber.CompareTo(secondNumber) == 1)
            {
                Console.WriteLine(thiredNumber + " is greater");
                return thiredNumber;
            }
            return 0;
        }

        public double MaximumDouble(double firstNumber, double secondNumber,double thirdNumber)
        {
            if (firstNumber.CompareTo(secondNumber) == 1 & firstNumber.CompareTo(thirdNumber) == 1)
            {
                Console.WriteLine(firstNumber + " is greater");
                return firstNumber;
            }
            if (secondNumber.CompareTo(firstNumber) == 1 & secondNumber.CompareTo(thirdNumber) == 1)
            {
                Console.WriteLine(secondNumber + " is greater");
                return secondNumber;
            }
            if (thirdNumber.CompareTo(firstNumber) == 1 & thirdNumber.CompareTo(secondNumber) == 1)
            {
                Console.WriteLine(thirdNumber + " is greater");
                return thirdNumber;
            }
            return 0.0;
        }
    }
}
