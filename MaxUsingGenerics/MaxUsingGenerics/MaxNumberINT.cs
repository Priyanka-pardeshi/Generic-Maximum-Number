using System;
using System.Collections.Generic;
using System.Text;

namespace MaxUsingGenerics
{
    class MaxNumberINT
    {
        public void Maximum(int firstNumber, int secondNumber,int thiredNumber)
        {
            if (firstNumber.CompareTo(secondNumber) == 1 & firstNumber.CompareTo(thiredNumber) == 1)
            {
                Console.WriteLine(firstNumber + " is greater");
            }
            if (secondNumber.CompareTo(firstNumber)==1 & secondNumber.CompareTo(thiredNumber) == 1)
            {
                Console.WriteLine(secondNumber+" is greater");
            }
            if (thiredNumber.CompareTo(firstNumber)==1 & thiredNumber.CompareTo(secondNumber)==1)
            {
                Console.WriteLine(thiredNumber + " is greater");
            }
        }
    }
}
