using System;

namespace MaxUsingGenerics
{
    class Program
    {  
        static void Main(string[] args)
        {
            MaxNumberINT objMax = new MaxNumberINT();
            Console.WriteLine("Enter three numbers:");
            int firstValue = Convert.ToInt32(Console.ReadLine());
            int secondValue = Convert.ToInt32(Console.ReadLine());
            int thiredValue = Convert.ToInt32(Console.ReadLine());
            objMax.Maximum(firstValue,secondValue,thiredValue);
            Console.ReadKey();
        }
    }
}
