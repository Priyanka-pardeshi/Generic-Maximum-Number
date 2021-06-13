using System;

namespace MaxUsingGenerics
{
    public class Program
    {  
        public static void Main(string[] args)
        {
            MaxNumberINT objMax = new MaxNumberINT();
            Console.WriteLine("Welcome");
            objMax.Maximum(30, 20, 10);
            int firstValue = Convert.ToInt32(Console.ReadLine());
            int secondValue = Convert.ToInt32(Console.ReadLine());
            int thiredValue = Convert.ToInt32(Console.ReadLine());
            objMax.Maximum(firstValue, secondValue, thiredValue);
            Console.ReadKey();
        }
    }
}
