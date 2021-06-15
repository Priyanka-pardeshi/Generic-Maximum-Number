using System;
using System.Collections.Generic;
using System.Text;

namespace MaxUsingGenerics
{
    public class MaxNumber
    {
        /// <summary>
        /// Mathod will sort the list and returned a Last number which is maximum value
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="val">Take multiple values</param>
        /// <returns></returns>
        public T MaximumGeneric<T>(params T[] val )
        {
            for (dynamic i = 0; i < val.Length - 1; i++)
            {
                for (dynamic j = 0; j < val.Length - i - 1; j++)
                {
                    if (Comparer<T>.Default.Compare(val[j],val[j+1])==1)
                    {
                        dynamic temp= val[j];
                        val[j] = val[j + 1];
                        val[j + 1] = temp;
                    }
                }
            }
            dynamic len = val.Length;
            Console.WriteLine("maximum  value is:"+val[len-1]);
            return val[len-1];
            
        }
    }
}
