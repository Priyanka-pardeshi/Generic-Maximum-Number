using System;
using System.Collections.Generic;
using System.Text;

namespace MaxUsingGenerics
{
    public class MaxNumber
    {
        public dynamic MaximumGeneric<T>(T first,  T second, T third)
        {
            //Console.WriteLine(Comparer<T>.Default.Compare(first,second)==1);

            if(Comparer<T>.Default.Compare(first, second)==1 & Comparer<T>.Default.Compare(first,third)==1)
            {
                Console.WriteLine(first + " is greater");
                return first;
            }
            if (Comparer<T>.Default.Compare(second,third)==1 & Comparer<T>.Default.Compare(second,first)==1)
            {
                Console.WriteLine(second + " is greater");
                return second;
            }
            if (Comparer<T>.Default.Compare(third,first)==1 & Comparer<T>.Default.Compare(third,second)==1)
            {
                Console.WriteLine(third + " is greater");
                return third;
            }
            return 0;
            
        }
    }
}
